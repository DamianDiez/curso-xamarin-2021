using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.ComponentModel;

namespace DeliveryApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomHeader : ContentView
    {
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title),
                typeof(string),
                typeof(CustomHeader),
                string.Empty);

        public string Title 
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value); 
        }

        public CustomHeader()
        {
            InitializeComponent();
        }
    }
}