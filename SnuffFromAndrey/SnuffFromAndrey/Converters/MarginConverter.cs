using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Converters
{
    class MarginConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            foreach (var value in values)
            {
                if (!(value is int b))
                {
                   return null;
                }

            }
            var left = (int)values[0];
            var top = (int)values[1];
            var right = (int)values[2];
            var bottom = (int)values[3];
            return new Thickness(left, top, right, bottom);
        }


        

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
