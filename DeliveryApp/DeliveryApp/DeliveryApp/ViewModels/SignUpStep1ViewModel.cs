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
    public class SignUpStep1ViewModel : BaseViewModel
    {
        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { SetProperty(ref phoneNumber, value); }
        }

        private string pinCode;

        public string PinCode
        {
            get { return pinCode; }
            set { SetProperty(ref pinCode, value); }
        }

        private string pinCodeGenerated;

        public ICommand SendCommand { get; private set; }
        public ICommand ValidateCommand { get; private set; }

        private INavigation Navigation;

        private async Task Send()
        {
            pinCodeGenerated = HardCodeService.GetPinCode(PhoneNumber);
            await App.Current.MainPage.DisplayAlert("Info", "The code has been sent to your phone number", "OK");
        }

        private async Task Validate()
        {
            if (PinCode == pinCodeGenerated)
            {
                await App.Current.MainPage.DisplayAlert("Success!", "Please complete the form with the required data", "OK");
                await Navigation.PushAsync(new Views.SignUpStep2View(PhoneNumber));
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error!", "The pin is incorrect", "OK");
            }

        }

        public SignUpStep1ViewModel(INavigation navigation)
        {
            Navigation = navigation;

            SendCommand = new Command(async () => await Send());
            ValidateCommand = new Command(async () => await Validate());
        }
    }
}
