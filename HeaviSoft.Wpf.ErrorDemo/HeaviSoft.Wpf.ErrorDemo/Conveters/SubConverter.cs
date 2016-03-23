using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HeaviSoft.Wpf.ErrorDemo.Conveters
{
    public class SubConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                throw new ArgumentNullException("value");
            }
            int listBoxWidth;
            if(!int.TryParse(value.ToString(), out listBoxWidth))
            {
                throw new Exception("invalid value!");
            }
            int subValue = 0;
            if(parameter != null)
            {
                int.TryParse(parameter.ToString(), out subValue);
            }
            return listBoxWidth - subValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
