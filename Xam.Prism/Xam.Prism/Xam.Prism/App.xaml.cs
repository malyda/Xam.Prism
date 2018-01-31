using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xam.Prism.View;
using Xam.Prism.ViewModel;
using Xamarin.Forms;

namespace Xam.Prism
{
	public partial class App : PrismApplication
	{
		public App (IPlatformInitializer initializer = null): base(initializer) { }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

	    protected override void RegisterTypes(IContainerRegistry containerRegistry)
	    {
	        containerRegistry.RegisterForNavigation<CustomMasterDetailPage, CustomMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
	    }

	    protected override void OnInitialized()
	    {
	        InitializeComponent();
	    }

	    protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
