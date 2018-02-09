using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_App.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pet_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdoptView : ContentPage
    {
        private AdoptViewModel viewModel;
        public AdoptView()
        {
            InitializeComponent();
            viewModel = new AdoptViewModel("Gatos");
            BindingContext = viewModel;
            viewModel.Navigation = Navigation;
        }
    }
}