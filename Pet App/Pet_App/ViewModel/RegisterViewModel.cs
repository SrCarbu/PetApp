using Pet_App.Model;
using Pet_App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pet_App.ViewModel
{
    public class RegisterViewModel : ViewModelBase
    {
        private User user;

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set {
                SetProperty(ref firstName, value);
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set {
                SetProperty(ref lastName, value);
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value);
                IsPasswordCorrect();
                IsConfirmPasswordCorrect();
            }
        }

        private string passwordMessage;

        public string PasswordMessage
        {
            get { return passwordMessage; }
            set { SetProperty(ref passwordMessage, value); }
        }


        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                SetProperty(ref confirmPassword, value);
                IsConfirmPasswordCorrect();
            }
        }

        private string confirmPasswordMessage;

        public string ConfirmPasswordMessage
        {
            get { return confirmPasswordMessage; }
            set { SetProperty(ref confirmPasswordMessage, value); }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set
            {
                SetProperty(ref username, value);
                IsUsernameCorrect();
            }
        }

        private string usernameMessage;

        public string UsernameMessage
        {
            get { return usernameMessage; }
            set { SetProperty(ref usernameMessage, value); }
        }

        private string mail;

        public string Mail
        {
            get { return mail; }
            set
            {
                SetProperty(ref mail, value);
                IsMailCorrect();
            }
        }

        private string mailMessage;

        public string MailMessage
        {
            get { return mailMessage; }
            set { SetProperty(ref mailMessage, value); }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set
            {
                
                SetProperty(ref phone, value);
                IsNumeric(Phone);
            }
        }

        private string phoneMessage;

        public string PhoneMessage
        {
            get { return phoneMessage; }
            set { SetProperty(ref phoneMessage, value); }
        }

        private bool isFormValid;

        public bool IsFormValid
        {
            get {
                return !string.IsNullOrWhiteSpace(LastName)
                  && !string.IsNullOrWhiteSpace(FirstName)
                  && IsPasswordCorrect()
                  && IsConfirmPasswordCorrect()
                  && IsUsernameCorrect()
                  && IsNumeric(Phone);
            }
            set { SetProperty(ref isFormValid, value); }
        }
        public bool IsNumeric(string valor)
        {
            int result;
            if (!string.IsNullOrWhiteSpace(Phone))
            {
                if (!int.TryParse(valor, out result))
                {
                    PhoneMessage = "Use only numbers";
                    return false;
                }
                PhoneMessage = "";
                return true;
            }
            PhoneMessage = "";
            return false;

        }

        private bool IsUsernameCorrect()
        {

            if (!string.IsNullOrWhiteSpace(Username))
            {
                if (Username.Equals("rata"))
                {
                    UsernameMessage = "Username Already Exists";

                    return false;
                }

                UsernameMessage = "";

                return true;
            }

            UsernameMessage = "";

            return false;
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }


        public ICommand RegisterCommand { get; set; }
        public INavigation Navigation { get; set; }

        public RegisterViewModel()
        {
            RegisterCommand = new Command(Register);
            confirmPassword = "";
        }

        private bool IsPasswordCorrect()
        {
            if (!string.IsNullOrWhiteSpace(Password))
            {
                char[] letters = Password.ToCharArray();
                bool mayus = false, minus = false, num = false, length = false;
                length = letters.Length >= 6;
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] >= 'A' && letters[i] <= 'Z')
                    {
                        mayus = true;
                    }
                    if (letters[i] >= 'a' && letters[i] <= 'z')
                    {
                        minus = true;
                    }
                    if (letters[i] >= '0' && letters[i] <= '9')
                    {
                        num = true;
                    }
                }

                if (mayus && minus && num && length)
                {
                    PasswordMessage = "Correct";
                    return true;
                }
                else
                {
                    PasswordMessage = "Incorrect Password (1 Upper, 1 Lower, 1 Number) 6 Length"; ;
                    return false;
                }
            }
            else
            {
                PasswordMessage = "";
                return false;
            }
        }

        private bool IsConfirmPasswordCorrect()
        {
            if (!string.IsNullOrWhiteSpace(Password))
            {
                if (!ConfirmPassword.Equals(Password))
                {
                    ConfirmPasswordMessage = "Passwords don't match";
                    return false;
                }
                else
                {
                    ConfirmPasswordMessage = "Correct";
                    return true;
                }
            }
            else
            {
                ConfirmPasswordMessage = "";
                return false;
            }
        }

        private bool IsMailCorrect()
        {  
            if (!string.IsNullOrWhiteSpace(Mail))
            {
                string expresion;
                expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (Regex.IsMatch(Mail, expresion))
                {
                    if (Regex.Replace(Mail, expresion, string.Empty).Length == 0)
                    {
                        MailMessage = "Correct";
                        return true;
                    }
                    else
                    {
                        MailMessage = "No Correct";
                        return false;
                    }
                }
                else
                {
                    MailMessage = "No Correct";
                    return false;
                }
            }
            else
            {
                MailMessage = "";
                return false;
            }
        }

        private async void Register()
        {
            try
            {
                if (IsFormValid)
                {
                    user = new User
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        Password = Password,
                        UserName = Username,
                        Mail = Mail,
                        Phone = Phone
                    };

                    await Navigation.PushAsync(new RegisterSplashView());
                }
                else
                {
                    Message = "Todos los campos son obligatorios";
                }
            }
            catch (Exception e)
            {

                
            }
        } 
    }
}
