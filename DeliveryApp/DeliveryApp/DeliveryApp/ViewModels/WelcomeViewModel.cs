using DeliveryApp.Models;
using DeliveryApp.Services;
using DeliveryApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DeliveryApp.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        public ObservableCollection<Product> HotDealsCollection { get; set; }
        public ObservableCollection<Product> PopularProductsCollection { get; set; }

        private Product selectedHotDeal;

        public Product SelectedHotDeal
        {
            get { return selectedHotDeal; }
            set { SetProperty(ref selectedHotDeal, value); }
        }

        private Product selectedPopular;

        public Product SelectedPopular
        {
            get { return selectedPopular; }
            set { SetProperty(ref selectedPopular, value); }
        }

        public ICommand LoadHotDealsCommand { get; private set; }
        public ICommand LoadPopularsCommand { get; private set; }
        public ICommand GoToProductDetailCommand { get; private set; }

        private int productsPerPage = 10;
        private int page = 0;

        private async Task LoadHotDeals()
        {
            if (HotDealsCollection.Count == 0)
            {
                IsBusy = true;

                await Task.Delay(4000);
                var products = HardCodeService.GetHotSalesPerPage(page, productsPerPage);
                SetProductCollection(HotDealsCollection, products);

                IsBusy = false;
            }
        }

        private async Task LoadPopulars()
        {
            if (PopularProductsCollection.Count == 0)
            {
                IsBusy = true;

                await Task.Delay(4000);
                var products = HardCodeService.GetProductsPerPage(page, productsPerPage);
                SetProductCollection(PopularProductsCollection, products);

                IsBusy = false;
            }
        }

        private async Task GoToDetail()
        {
            if (selectedHotDeal != null)
            {
                ProductDetailViewModel vm = new ProductDetailViewModel(selectedHotDeal);

                ProductDetailView page = new ProductDetailView();
                page.BindingContext = vm;

                await App.Current.MainPage.Navigation.PushAsync(page);
            }
        }

        private void SetProductCollection(ObservableCollection<Product> productCollection,
            List<Product> products)
        {
            while (productCollection.Count > 0)
                productCollection.RemoveAt(0);

            foreach (var item in products)
            {
                productCollection.Add(item);
            }
        }

        public WelcomeViewModel()
        {
            SelectedHotDeal = null;
            selectedPopular = null;
            HotDealsCollection = new ObservableCollection<Product>();
            PopularProductsCollection = new ObservableCollection<Product>();
            LoadHotDealsCommand = new Command(async () => await LoadHotDeals());
            LoadPopularsCommand = new Command(async () => await LoadPopulars());
            GoToProductDetailCommand = new Command(async () => await GoToDetail());
        }

    }
}
