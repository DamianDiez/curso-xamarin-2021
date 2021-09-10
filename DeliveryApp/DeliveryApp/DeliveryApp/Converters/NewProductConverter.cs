using System;
using System.Globalization;
using Xamarin.Forms;

namespace DeliveryApp.Converters
{
    public class NewProductConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime productDate;

            if (DateTime.TryParse(value.ToString(), out productDate))
            {
                var today = DateTime.Now;
                var days = (today - productDate).TotalDays;
                return days < 7;
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
