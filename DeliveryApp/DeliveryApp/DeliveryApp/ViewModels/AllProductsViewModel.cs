using DeliveryApp.Models;
using DeliveryApp.Services;
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

        public ICommand LoadDataCommand { get; set; }

        private async Task LoadData()
        {
            IsBusy = true;

            await Task.Delay(4000);
            products = HardCodeService.GetAllProducts();
            SetProductCollection(products);

            IsBusy = false;
        }

        private void SetProductCollection(List<Product> products)
        {
            ProductCollection.Clear();

            foreach (var item in products)
            {
                ProductCollection.Add(item);
            }
        }

        public AllProductsViewModel()
        {
            ProductCollection = new ObservableCollection<Product>();
            LoadDataCommand = new Command(async () => await LoadData());
        }
    }
}
