namespace Xam.Prism.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new Xam.Prism.App(new UWPInitializer()));
        }
    }
}
