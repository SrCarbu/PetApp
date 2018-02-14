using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Pet_App.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pet_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainViewMaster : ContentPage
    {
        public ListView ListView;

        public MainViewMaster()
        {
            InitializeComponent();

            BindingContext = new MainViewMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainViewMenuItem> MenuItems { get; set; }
            
            public MainViewMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainViewMenuItem>(new[]
                {
                    new MainViewMenuItem { Id = 0, Title = "Animales Perdidos", TargetType = typeof(MainView) },
                    new MainViewMenuItem { Id = 1, Title = "Perros", TargetType = typeof(AdoptView) },
                    new MainViewMenuItem { Id = 2, Title = "Gatos", TargetType = typeof(AdoptView) },
                    new MainViewMenuItem { Id = 3, Title = "Pajaros", TargetType = typeof(AdoptView) },
                    new MainViewMenuItem { Id = 4, Title = "Roedores", TargetType = typeof(AdoptView) },
                    new MainViewMenuItem { Id = 5, Title = "Reptiles", TargetType = typeof(AdoptView) },
                    new MainViewMenuItem { Id = 6, Title = "Otros Servicios", TargetType = typeof(MainView) },
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