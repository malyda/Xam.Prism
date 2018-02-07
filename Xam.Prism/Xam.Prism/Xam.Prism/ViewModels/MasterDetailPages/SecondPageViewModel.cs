using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;

namespace Xam.Prism.ViewModels.MasterDetailPages
{
    class SecondPageViewModel : INavigationAware
    {
        public SecondPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            var firstParameter = parameters["Parameter1"];
        }
    }
}
