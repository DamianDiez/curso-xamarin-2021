using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DeliveryApp.Models;

namespace DeliveryApp.Services
{
    public class HardCodeService
    {
        public static User SignIn(string email, string password)
        {
            string emailCheck = "luis@luisbeltran.mx";
            string passwordCheck = "xamarin";

            if (email == emailCheck && password == passwordCheck)
            {
                return new User()
                {
                    Email = emailCheck,
                    Password = passwordCheck,
                    PhoneNumber = "+420776423625",
                    UserName = "icebeam"
                };
            }
            else
            {
                return null;
            }
        }

        public static string GetPinCode(string phoneNumber)
        {
            return "1234";
        }

        public static List<Product> GetAllProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 0,
                    Name = "Brown eggs",
                    ReleaseDate = "2021-09-01",
                    OriginalPrice = 28.1,
                    Discount = 40,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/0.jpg",
                },
                new Product()
                {
                    Id = 1,
                    Name = "Sweet fresh stawberry",
                    ReleaseDate = "2021-09-08",
                    OriginalPrice = 29.45,
                    Discount = 7.05,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/1.jpg",
                },
                new Product()
                {
                    Id = 2,
                    Name = "Asparagus",
                    ReleaseDate = "2021-09-09",
                    OriginalPrice = 18.95,
                    Discount = 2.15,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/2.jpg",
                },
                new Product()
                {
                    Id = 3,
                    Name = "Green smoothie",
                    ReleaseDate = "2021-09-01",
                    OriginalPrice = 17.68,
                    Discount = 0,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/3.jpg",
                },
                new Product()
                {
                    Id = 4,
                    Name = "Raw legums",
                    ReleaseDate = "2021-09-02",
                    OriginalPrice = 17.11,
                    Discount = 10.30,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/4.jpg",
                },
                new Product()
                {
                    Id = 5,
                    Name = "Baking cake",
                    ReleaseDate = "2021-09-05",
                    OriginalPrice = 11.14,
                    Discount = 15.00,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/5.jpg",
                },
                new Product()
                {
                    Id = 6,
                    Name = "Pesto with basil",
                    ReleaseDate = "2021-09-06",
                    OriginalPrice = 18.19,
                    Discount = 9,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/6.jpg",
                },
                new Product()
                {
                    Id = 7,
                    Name = "Hazelnut in black ceramic bowl",
                    ReleaseDate = "2021-08-01",
                    OriginalPrice = 27.35,
                    Discount = 10,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/7.jpg",
                },
                new Product()
                {
                    Id = 8,
                    Name = "Fresh stawberry",
                    ReleaseDate = "2021-08-02",
                    OriginalPrice = 28.59,
                    Discount = 0,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/8.jpg",
                },
                new Product()
                {
                    Id = 9,
                    Name = "Lemon and salt",
                    ReleaseDate = "2021-08-09",
                    OriginalPrice = 15.79,
                    Discount = 0,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/9.jpg",
                },
                new Product()
                {
                    Id = 10,
                    Name = "Homemade bread",
                    ReleaseDate = "2021-09-02",
                    OriginalPrice = 17.48,
                    Discount = 0,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/10.jpg",
                },
                new Product()
                {
                    Id = 11,
                    Name = "Legums",
                    ReleaseDate = "2021-09-09",
                    OriginalPrice = 14.77,
                    Discount = 0,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/11.jpg",
                },
                new Product()
                {
                    Id = 12,
                    Name = "Fresh tomato",
                    ReleaseDate = "2021-09-05",
                    OriginalPrice = 16.3,
                    Discount = 20,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/12.jpg",
                },
                new Product()
                {
                    Id = 13,
                    Name = "Healthy breakfast",
                    ReleaseDate = "2021-09-09",
                    OriginalPrice = 13.02,
                    Discount = 5.20,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/13.jpg",
                },
                new Product()
                {
                    Id = 14,
                    Name = "Green beans",
                    ReleaseDate = "2021-09-09",
                    OriginalPrice = 28.79,
                    Discount = 0,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/14.jpg",
                },
                new Product()
                {
                    Id = 15,
                    Name = "Baked stuffed portabello mushrooms",
                    ReleaseDate = "2021-08-02",
                    OriginalPrice = 20.31,
                    Discount = 0,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/15.jpg",
                },
                new Product()
                {
                    Id = 16,
                    Name = "Strawberry jelly",
                    ReleaseDate = "2021-08-02",
                    OriginalPrice = 14.18,
                    Discount = 7,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/16.jpg",
                },
                new Product()
                {
                    Id = 17,
                    Name = "Pears juice",
                    ReleaseDate = "2021-08-02",
                    OriginalPrice = 19.49,
                    Discount = 25,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/17.jpg",
                },
                new Product()
                {
                    Id = 18,
                    Name = "Fresh pears",
                    ReleaseDate = "2021-09-04",
                    OriginalPrice = 15.12,
                    Discount = 0,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/18.jpg",
                },
                new Product()
                {
                    Id = 19,
                    Name = "Caprese salad",
                    ReleaseDate = "2021-08-02",
                    OriginalPrice = 16.76,
                    Discount = 30,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/19.jpg",
                },
                new Product()
                {
                    Id = 20,
                    Name = "Oranges",
                    ReleaseDate = "2021-08-02",
                    OriginalPrice = 21.48,
                    Discount = 50,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/20.jpg",
                },
                new Product()
                {
                    Id = 21,
                    Name = "Vegan food",
                    ReleaseDate = "2021-09-07",
                    OriginalPrice = 29.66,
                    Discount = 40,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/21.jpg",
                },
                new Product()
                {
                    Id = 22,
                    Name = "Breakfast with muesli",
                    ReleaseDate = "2021-08-02",
                    OriginalPrice = 22.7,
                    Discount = 10,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/22.jpg",
                },
                new Product()
                {
                    Id = 23,
                    Name = "Honey",
                    ReleaseDate = "2021-09-08",
                    OriginalPrice = 17.01,
                    Discount = 8,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/23.jpg",
                },
                new Product()
                {
                    Id = 24,
                    Name = "Breakfast with cottage",
                    ReleaseDate = "2021-09-06",
                    OriginalPrice = 14.05,
                    Discount = 0,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/24.jpg",
                },
                new Product()
                {
                    Id = 25,
                    Name = "Strawberry smoothie",
                    ReleaseDate = "2021-08-02",
                    OriginalPrice = 28.86,
                    Discount = 3,
                    PictureUrl = "https://raw.githubusercontent.com/wedeploy-examples/supermarket-web-example/master/ui/assets/images/25.jpg",
                }
            };
        }

        public static List<Product> GetProductsPerPage(int page, int count)
        {
            var productList = GetAllProducts();
            return productList.Skip(count * page).Take(count).ToList();
        }

        public static List<Product> GetHotSales()
        {
            var productList = GetAllProducts();
            return productList.Where(x => x.Discount > 20).ToList();
        }

        public static List<Product> GetHotSalesPerPage(int page, int count)
        {
            var productList = GetHotSales();
            return productList.Skip(count * page).Take(count).ToList();
        }
    }
}
