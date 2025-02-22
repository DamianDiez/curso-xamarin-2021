﻿using System;
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
    public partial class SignUpStep1View : ContentPage
    {
        SignUpStep1ViewModel vm;

        public SignUpStep1View()
        {
            InitializeComponent();

            vm = new SignUpStep1ViewModel(this.Navigation);
            BindingContext = vm;
        }
    }
}