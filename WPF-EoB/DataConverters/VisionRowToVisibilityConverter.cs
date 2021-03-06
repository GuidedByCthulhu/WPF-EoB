﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace WPF_EoB.DataConverters
{
    class VisionRowToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is byte))
                throw new ArgumentException("VisionRowToVisibilityConverter attempted to convert a value which was not a byte.");

            Visibility returnValue = Visibility.Hidden;

            if ((byte)value > 0)
                returnValue = Visibility.Visible;            

            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
