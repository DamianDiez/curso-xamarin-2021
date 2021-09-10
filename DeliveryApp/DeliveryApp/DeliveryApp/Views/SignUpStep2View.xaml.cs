using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DeliveryApp.ViewModels;

namespace DeliveryApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpStep2View : ContentPage
    {
        SignUpStep2ViewModel vm;

        public SignUpStep2View(string phoneNumber)
        {
            InitializeComponent();

            vm = new SignUpStep2ViewModel(phoneNumber);
            BindingContext = vm;
        }
    }
}