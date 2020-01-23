using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MyFinances.Helpers
{
    public class EnterPasswordDialogHelper : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values?.Length >= 2 &&
                values[0] is double dialogHostHeight &&
                values[1] is double dialogHeight &&
                IsValid(dialogHostHeight) &&
                IsValid(dialogHeight))
            {
                //Dialog will be centered
                return (dialogHostHeight - dialogHeight) / 10;
            }
            return Binding.DoNothing;

            bool IsValid(double value) => !double.IsInfinity(value) && !double.IsNaN(value);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
