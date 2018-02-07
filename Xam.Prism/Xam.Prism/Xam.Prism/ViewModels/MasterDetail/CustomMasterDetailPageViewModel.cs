using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xam.Prism.View;
using Xam.Prism.View.MasterDetailPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam.Prism.ViewModels
{
    class CustomMasterDetailPageViewModel : BindableBase
    {
        INavigationService _navigationService;
        public DelegateCommand OnNavigateCommand { get; set; }

        MasterDetailPageMenuItem _selectedMenuItem;
        public MasterDetailPageMenuItem SelectedMenuItem
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
        public ObservableCollection<MasterDetailPageMenuItem> MenuItems { get; set; }
        public CustomMasterDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            MenuItems = new ObservableCollection<MasterDetailPageMenuItem>(new[]
              {
                    new MasterDetailPageMenuItem
                    {
                        Id = 0,
                        Title = "First Page",
                        Page = typeof(FirstPage).Name,
                        PageParameters = new NavigationParameters()
                        {
                            {"Parameter1", "first parameter value"}
                        }
                    },
                  new MasterDetailPageMenuItem
                  {
                      Id = 1,
                      Title = "Second Page",
                      Page = typeof(SecondPage).Name,
                      PageParameters = new NavigationParameters()
                      {
                          {"Parameter1", "first parameter value"}
                      }
                  },
                  new MasterDetailPageMenuItem
                  {
                      Id = 2,
                      Title = "Third Page",
                      Page = typeof(ThirdPage).Name,
                      PageParameters = new NavigationParameters()
                      {
                          {"Parameter1", "first parameter value"}
                      }
                  },

                });
            OnNavigateCommand = new DelegateCommand(NavigateAsync);
        }

        async void NavigateAsync()
        {
            if (_selectedMenuItem is MasterDetailPageMenuItem item)
            {
                 await _navigationService.NavigateAsync(new Uri("NavigationPage/"+item.Page, UriKind.Relative),item.PageParameters);
            }
        }
    }
}
