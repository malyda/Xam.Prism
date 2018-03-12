using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.ObjectModel;
using Xam.Prism.View.Pages.MasterDetailPageRoot;
using static Xam.Prism.Enums.NavigationEnums;

namespace Xam.Prism.ViewModels
{
    class CustomMasterDetailPageViewModel : BindableBase
    {
        readonly INavigationService _navigationService;
        private DelegateCommand OnNavigateCommand { get; set; }

        CustomMasterDetailPageMenuItem _selectedMenuItem;

        public CustomMasterDetailPageMenuItem SelectedMenuItem
        {
            get => _selectedMenuItem;
            set => SetProperty(ref _selectedMenuItem, value);
        }

        private ObservableCollection<CustomMasterDetailPageMenuItem> MenuItems { get; set; }

        public CustomMasterDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            MenuItems = new ObservableCollection<CustomMasterDetailPageMenuItem>(new[]
            {
                new CustomMasterDetailPageMenuItem
                {
                    Id = 0,
                    Title = "Page 1",
                    NavigationTo = PagesForNavigation.FirstPage
                },
                new CustomMasterDetailPageMenuItem
                {
                    Id = 1,
                    Title = "Page 2",
                    NavigationTo = PagesForNavigation.SecondPage
                },
                new CustomMasterDetailPageMenuItem
                {
                    Id = 2,
                    Title = "Page 3",
                    NavigationTo = PagesForNavigation.ThirdPage
                },
            });
            OnNavigateCommand = new DelegateCommand(NavigateAsync);
        }

        async void NavigateAsync()
        {
            await _navigationService.NavigateAsync(new Uri(
                $"{PrismExtensionNavigation.GetBaseNavigationStack()}/{_selectedMenuItem.NavigationTo.ToString()}",
                UriKind.Relative));
        }
    }
}