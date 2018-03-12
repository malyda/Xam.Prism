using Prism.Commands;
using Prism.Navigation;
using System;
using System.Diagnostics;
using static Xam.Prism.Enums.NavigationEnums;

namespace Xam.Prism.ViewModels
{
    class FirstPageViewModel
    {
        readonly INavigationService _navigationService;
        private DelegateCommand<string> OnNavigateCommand { get; set; }

        public string NavigateTo { get; set; } = PagesForNavigation.SimplePage.ToString();

        public FirstPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            OnNavigateCommand = new DelegateCommand<string>(NavigateAsync);
        }

        async void NavigateAsync(string navigateToPage)
        {
            await _navigationService.NavigateAsync(new Uri(navigateToPage, UriKind.Relative));
        }
    }
}