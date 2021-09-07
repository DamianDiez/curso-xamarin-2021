using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.ComponentModel;

namespace BanderasApp.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TarjetaView : ContentView
    {
        public static readonly BindableProperty ColorBordeProperty = 
            BindableProperty.Create(nameof(ColorBorde), 
                typeof(Color), 
                typeof(TarjetaView), 
                Color.DarkGray);

        public static readonly BindableProperty ColorFondoProperty = 
            BindableProperty.Create(nameof(ColorFondo), 
                typeof(Color), 
                typeof(TarjetaView), 
                Color.White);

        public static readonly BindableProperty ImagenBanderaProperty =
            BindableProperty.Create(nameof(ImagenBandera),
                typeof(ImageSource),
                typeof(TarjetaView),
                default(ImageSource));

        public static readonly BindableProperty NombrePaisProperty =
            BindableProperty.Create(nameof(NombrePais),
                typeof(string),
                typeof(TarjetaView),
                string.Empty);

        public static readonly BindableProperty CapitalProperty =
            BindableProperty.Create(nameof(Capital),
                typeof(string),
                typeof(TarjetaView),
                string.Empty);

        public static readonly BindableProperty ContinenteProperty =
            BindableProperty.Create(nameof(Continente),
                typeof(string),
                typeof(TarjetaView),
                string.Empty);

        public static readonly BindableProperty MonedaProperty =
            BindableProperty.Create(nameof(Moneda),
                typeof(string),
                typeof(TarjetaView),
                string.Empty);

        public static readonly BindableProperty PoblacionProperty =
            BindableProperty.Create(nameof(Poblacion),
                typeof(int),
                typeof(TarjetaView),
                0);

        public Color ColorBorde
        {
            get => (Color)GetValue(ColorBordeProperty);
            set => SetValue(ColorBordeProperty, value);
        }

        public Color ColorFondo
        {
            get => (Color)GetValue(ColorFondoProperty);
            set => SetValue(ColorFondoProperty, value);
        }

        public ImageSource ImagenBandera
        {
            get => (ImageSource)GetValue(ImagenBanderaProperty);
            set => SetValue(ImagenBanderaProperty, value);
        }

        public string NombrePais
        {
            get => (string)GetValue(NombrePaisProperty);
            set => SetValue(NombrePaisProperty, value);
        }

        public string Capital
        {
            get => (string)GetValue(CapitalProperty);
            set => SetValue(CapitalProperty, value);
        }

        public string Continente
        {
            get => (string)GetValue(ContinenteProperty);
            set => SetValue(ContinenteProperty, value);
        }

        public string Moneda
        {
            get => (string)GetValue(MonedaProperty);
            set => SetValue(MonedaProperty, value);
        }

        public int Poblacion
        {
            get => (int)GetValue(PoblacionProperty);
            set => SetValue(PoblacionProperty, value);
        }

        public TarjetaView()
        {
            InitializeComponent();
        }
    }
}