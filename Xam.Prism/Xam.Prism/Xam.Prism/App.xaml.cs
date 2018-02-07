using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xam.Prism.View.MasterDetailPages;
using Xam.Prism.ViewModels;
using Xam.Prism.ViewModels.MasterDetailPages;
using Xamarin.Forms;

namespace Xam.Prism
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Registering Master Detail Page
            containerRegistry.RegisterForNavigation<CustomMasterDetailPage, CustomMasterDetailPageViewModel>();
         
            // Registering base type for navigation in MasterDetail and Tabbed Pages
            containerRegistry.RegisterForNavigation<NavigationPage>();

            // Registering pages
            containerRegistry.RegisterForNavigation<FirstPage, FirstPageViewModel>();
            containerRegistry.RegisterForNavigation<SecondPage, SecondPageViewModel>();
            containerRegistry.RegisterForNavigation<ThirdPage, ThirdPageViewModel>();

            // Registering based page
            containerRegistry.RegisterForNavigation<MainPage>();
        }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync(new Uri("CustomMasterDetailPage/NavigationPage/MainPage", UriKind.Relative));
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
