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
    class LoginViewModel : ViewModelBase
    {
        public ICommand LoginCommand { get; set; }
        public ICommand SinginCommand { get; set; }
        public INavigation Navigation { get; set; }

        public LoginViewModel()
        {
            SinginCommand = new Command(Register);
            LoginCommand = new Command(Register);
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value);
                OnPropertyChanged("IsFormValid");
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set {
                SetProperty(ref password, value);
                OnPropertyChanged("IsFormValid");
            }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }


        private bool isFormValid;

        public bool IsFormValid
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Username)
                  && !string.IsNullOrWhiteSpace(Password);
            }
            set { SetProperty(ref isFormValid, value); }
        }

        private async void Register()
        {

            try
            {
                await Navigation.PushAsync(new MainView());
            }
            catch (Exception e)
            {


            }
        }

    }
}
