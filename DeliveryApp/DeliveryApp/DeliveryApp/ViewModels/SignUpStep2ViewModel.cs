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
    public class SignUpStep2ViewModel : BaseViewModel
    {
        private User newUser;

        public User NewUser
        {
            get { return newUser; }
            set { SetProperty(ref newUser, value); }
        }

        private string passwordCheck;

        public string PasswordCheck
        {
            get { return passwordCheck; }
            set { SetProperty(ref passwordCheck, value); }
        }

        public ICommand SignUpCommand { get; private set; }

        private INavigation Navigation;

        private async Task SignUp()
        {
            if (PasswordCheck == NewUser.Password)
            {
                App.CurrentUser = NewUser;
                await App.Current.MainPage.DisplayAlert("Success!", $"Welcome, {NewUser.UserName}", "OK");

                App.Current.MainPage = new Views.AppShellMenu();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error!", "The passwords don't match", "OK");
            }
        }

        public SignUpStep2ViewModel(string phoneNumber)
        {
            NewUser = new User()
            {
                PhoneNumber = phoneNumber
            };

            SignUpCommand = new Command(async () => await SignUp());
        }
    }
}
