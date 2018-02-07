using Prism.Navigation;

namespace Xam.Prism.ViewModels.MasterDetailPages
{
    class FirstPageViewModel: INavigationAware
    {
        public FirstPageViewModel()
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
