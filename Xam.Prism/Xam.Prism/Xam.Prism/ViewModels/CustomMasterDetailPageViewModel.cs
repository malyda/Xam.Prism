using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xam.Prism.View;
using Xamarin.Forms;

namespace Xam.Prism.ViewModels
{
    class CustomMasterDetailPageViewModel : BindableBase
    {
        INavigationService _navigationService;
        public DelegateCommand<string> OnNavigateCommand { get; set; }

        CustomMasterDetailPageMenuItem _selectedMenuItem;
        public CustomMasterDetailPageMenuItem SelectedMenuItem
        {
            get
            {
                return _selectedMenuItem;
            }
            set
            {
                SetProperty(ref _selectedMenuItem, value);
            }
        }
        public ObservableCollection<CustomMasterDetailPageMenuItem> MenuItems { get; set; }
        public CustomMasterDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            MenuItems = new ObservableCollection<CustomMasterDetailPageMenuItem>(new[]
              {
                    new CustomMasterDetailPageMenuItem { Id = 0, Title = "Page 1", Page = "asdad"},
                    new CustomMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
                    new CustomMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    new CustomMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    new CustomMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
                });
            OnNavigateCommand = new DelegateCommand<string>(NavigateAsync);
        }

        async void NavigateAsync(string page)
        {
            var x = _selectedMenuItem;
           // await _navigationService.NavigateAsync(new Uri(page, UriKind.Relative));
        }
    }
}
