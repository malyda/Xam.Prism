using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Unity;
using Xam.Prism.Enums;
using Xam.Prism.View.Events;

namespace Xam.Prism.ViewModels
{
    class CustomMasterDetailPageViewModel : BindableBase
    {
        static INavigationService _navigationService;

        public CustomMasterDetailPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            _navigationService = navigationService;
            eventAggregator.GetEvent<MenuPageNavigationEvent>().Subscribe(MenuItemNavigateTo);
        }

        private async void MenuItemNavigateTo(NavigationEnums.PagesForNavigation navigateTo)
        {
            var uri = new Uri ($"{NavigationEnums.RootPagesForNavigation.NavigationPage}/{navigateTo}",UriKind.Relative);
            await _navigationService.NavigateAsync(uri);
        }
    }
}