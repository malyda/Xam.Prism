using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam.Prism.View.MasterDetailPages
{ 
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomMasterDetailPage : MasterDetailPage
    {
        public CustomMasterDetailPage()
        {
            InitializeComponent();
        }
    }
}