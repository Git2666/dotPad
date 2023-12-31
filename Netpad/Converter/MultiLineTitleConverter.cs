using System;
using System.Globalization;
using System.Windows.Data;

namespace dotPad.Converter
{
    public class MultiLineTitleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var text = value as string;

            return string.IsNullOrEmpty(text) ? value : text.Replace(@"\n", Environment.NewLine);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}