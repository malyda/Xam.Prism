using Prism;
using Prism.Ioc;
using Xam.Prism.View.Pages;
using Xam.Prism.View.Pages.MasterDetailPageRoot;
using Xam.Prism.ViewModels;
using Xamarin.Forms;
using static Xam.Prism.Enums.NavigationEnums;
using Xam.Prism.View.Pages.DetailPages;

namespace Xam.Prism
{
    public partial class App
    {
        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register MasterDetailPage with ViewModel
            containerRegistry.RegisterForNavigation<CustomMasterDetailPage, CustomMasterDetailPageViewModel>(
                RootPagesForNavigation.CustomMasterDetailPage.ToString());
            containerRegistry.RegisterForNavigation<CustomMasterDetailPageDetail>();

            // Register base pages for navigation

            // Register page with its ViewModel
            containerRegistry.RegisterForNavigation<FirstPage, FirstPageViewModel>(
                PagesForNavigation.FirstPage.ToString());

            // Register pages without ViewModels
            containerRegistry.RegisterForNavigation<SecondPage>(PagesForNavigation.SecondPage.ToString());
            containerRegistry.RegisterForNavigation<ThirdPage>(PagesForNavigation.ThirdPage.ToString());
            containerRegistry.RegisterForNavigation<SimplePage>(PagesForNavigation.SimplePage.ToString());

            // Register base NavigationPage
            containerRegistry.RegisterForNavigation<NavigationPage>(RootPagesForNavigation.NavigationPage.ToString());
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync(PrismExtensionNavigation.GetBaseMasterDetailPageUri());
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}