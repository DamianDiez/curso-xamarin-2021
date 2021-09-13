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
    public partial class UserAccountView : ContentPage
    {
        UserAccountViewModel vm;

        public UserAccountView()
        {
            InitializeComponent();

            vm = new UserAccountViewModel();
            BindingContext = vm;
        }


    }
}