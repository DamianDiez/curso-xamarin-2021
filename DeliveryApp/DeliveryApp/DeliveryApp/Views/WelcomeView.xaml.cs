using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DeliveryApp.ViewModels;

namespace DeliveryApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomeView : ContentPage
    {
        WelcomeViewModel vm;

        public WelcomeView()
        {
            InitializeComponent();

            vm = new WelcomeViewModel();
            BindingContext = vm;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await Task.Run(() => vm.LoadHotDealsCommand.Execute(null));
            await Task.Run(() => vm.LoadPopularsCommand.Execute(null));

            vm.SelectedHotDeal = null;
            vm.SelectedPopular = null;
        }
    }
}