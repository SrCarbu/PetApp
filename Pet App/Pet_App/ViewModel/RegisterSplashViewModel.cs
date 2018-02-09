using Pet_App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pet_App.ViewModel
{
    class RegisterSplashViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }
        public ICommand TouchScreenCommand { get; set; }
        public RegisterSplashViewModel()
        {
            TouchScreenCommand = new Command(async () => await TouchScreen());
        }

        private async Task TouchScreen()
        {
            try
            {
                await Navigation.PushAsync(new LoginView());
            }
            catch (Exception e)
            {


            }
        }
    }
}
