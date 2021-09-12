using DeliveryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DeliveryApp.ViewModels
{
    public class ProductDetailViewModel : BaseViewModel
    {
        private Product currentProduct;

        public Product CurrentProduct
        {
            get { return currentProduct; }
            set { SetProperty(ref currentProduct, value); }
        }

        public ProductDetailViewModel(Product product)
        {
            CurrentProduct = product;
        }
    }
}