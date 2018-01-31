using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam.Prism.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public CustomMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new CustomMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class CustomMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<CustomMasterDetailPageMenuItem> MenuItems { get; set; }
            
            public CustomMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<CustomMasterDetailPageMenuItem>(new[]
                {
                    new CustomMasterDetailPageMenuItem { Id = 0, Title = "Page 1" },
                    new CustomMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
                    new CustomMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    new CustomMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    new CustomMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}