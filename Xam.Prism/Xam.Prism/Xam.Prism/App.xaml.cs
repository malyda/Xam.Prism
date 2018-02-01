using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xam.Prism.View;
using Xam.Prism.ViewModels;
using Xamarin.Forms;

namespace Xam.Prism
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CustomMasterDetailPage, CustomMasterDetailPageViewModel>();
         
            containerRegistry.RegisterForNavigation<NavigationPage>();

          // containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<CustomMasterDetailPageDetail>();
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
