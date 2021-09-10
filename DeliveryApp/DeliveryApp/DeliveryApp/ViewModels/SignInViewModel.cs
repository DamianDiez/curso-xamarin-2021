using DeliveryApp.Models;
using DeliveryApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DeliveryApp.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        public ICommand SignInCommand { get; private set; }

        private async Task SignIn()
        {
            var user = HardCodeService.SignIn(Email, Password);

            if (user != null)
            {
                App.CurrentUser = user;
                await App.Current.MainPage.DisplayAlert("Success!", $"Welcome, {user.UserName}", "OK");

                App.Current.MainPage = new Views.AppShellMenu();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error!", "Incorrect data", "OK");
            }

        }

        public SignInViewModel()
        {
            SignInCommand = new Command(async () => await SignIn());
        }
    }
}
