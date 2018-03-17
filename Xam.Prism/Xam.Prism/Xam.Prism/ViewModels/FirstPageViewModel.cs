using Prism.Commands;
using Prism.Navigation;
using System;
using System.Diagnostics;
using Prism.Events;
using Prism.Mvvm;
using Xam.Prism.View.Events;
using static Xam.Prism.Enums.NavigationEnums;

namespace Xam.Prism.ViewModels
{
    class FirstPageViewModel: BindableBase
    {
        readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;
        public DelegateCommand<string> OnNavigateCommand { get; set; }

        public string NavigateTo { get; set; } = PagesForNavigation.SimplePage.ToString();

        public FirstPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;
            OnNavigateCommand = new DelegateCommand<string>(NavigateAsync);
        }

         void NavigateAsync(string navigateToPage)
        {
            var uri = new Uri($"{navigateToPage}",UriKind.Relative);
            _navigationService.NavigateAsync(uri);
        }
    }
}