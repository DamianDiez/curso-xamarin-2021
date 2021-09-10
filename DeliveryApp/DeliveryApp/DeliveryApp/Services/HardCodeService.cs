using System;
using System.Collections.Generic;
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
    }
}
