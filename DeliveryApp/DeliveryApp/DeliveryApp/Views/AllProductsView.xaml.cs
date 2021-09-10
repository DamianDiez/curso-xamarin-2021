using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DeliveryApp.ViewModels;

namespace DeliveryApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllProductsView : ContentPage
    {
        AllProductsViewModel vm;

        public AllProductsView()
        {
            InitializeComponent();

            vm = new AllProductsViewModel();
            BindingContext = vm;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await Task.Run(() => vm.LoadDataCommand.Execute(null));

        }
    }
}