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
    public class AllProductsViewModel : BaseViewModel
    {
        private List<Product> products;

        public ObservableCollection<Product> ProductCollection { get; set; }

        private Product selectedProduct;

        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set { SetProperty(ref selectedProduct, value); }
        }

        public ICommand LoadDataCommand { get; private set; }
        public ICommand GoToProductDetailCommand { get; private set; }
        public ICommand LoadMoreCommand { get; private set; }

        private int productsPerPage = 10;
        private int page = 0;

        private async Task LoadData()
        {
            if (ProductCollection.Count == 0)
            {
                IsBusy = true;

                await Task.Delay(4000);
                products = HardCodeService.GetProductsPerPage(page, productsPerPage);
                SetProductCollection(products);

                IsBusy = false;
            }
        }

        private async Task LoadMore()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            await Task.Delay(2000);
            page++;
            var moreProducts = HardCodeService.GetProductsPerPage(page, productsPerPage);

            if (moreProducts?.Count > 0)
            {
                products.AddRange(moreProducts);

                foreach (var item in moreProducts)
                {
                    ProductCollection.Add(item);
                }
            }
            else
            {
                page--;
            }

            IsBusy = false;
        }

        private async Task GoToDetail()
        {
            if (selectedProduct != null)
            {
                ProductDetailViewModel vm = new ProductDetailViewModel(selectedProduct);

                ProductDetailView page = new ProductDetailView();
                page.BindingContext = vm;

                await App.Current.MainPage.Navigation.PushAsync(page); 
            }
        }

        private void SetProductCollection(List<Product> products)
        {
            while (ProductCollection.Count > 0)
                ProductCollection.RemoveAt(0);

            foreach (var item in products)
            {
                ProductCollection.Add(item);
            }
        }

        public AllProductsViewModel()
        {
            SelectedProduct = null;
            ProductCollection = new ObservableCollection<Product>();
            LoadDataCommand = new Command(async () => await LoadData());
            LoadMoreCommand = new Command(async () => await LoadMore());
            GoToProductDetailCommand = new Command(async () => await GoToDetail());
        }
    }
}
