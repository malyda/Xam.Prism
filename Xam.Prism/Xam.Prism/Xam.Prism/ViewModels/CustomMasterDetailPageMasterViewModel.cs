using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Prism.Events;
using Xam.Prism.Enums;
using Xam.Prism.View.Events;
using Xam.Prism.View.Pages.MasterDetailPageRoot;
using static Xam.Prism.Enums.NavigationEnums;

namespace Xam.Prism.ViewModels
{
    class CustomMasterDetailPageMasterViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;
        public DelegateCommand OnNavigateCommand { get; set; }

        CustomMasterDetailPageMenuItem _selectedMenuItem;

        public CustomMasterDetailPageMenuItem SelectedMenuItem
        {
            get => _selectedMenuItem;
            set => SetProperty(ref _selectedMenuItem, value);
        }

        public ObservableCollection<CustomMasterDetailPageMenuItem> MenuItems { get; set; }

        public CustomMasterDetailPageMasterViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

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

        void NavigateAsync()
        {
            _eventAggregator.GetEvent<MenuPageNavigationEvent>().Publish(SelectedMenuItem.NavigationTo);
        }
    }
}