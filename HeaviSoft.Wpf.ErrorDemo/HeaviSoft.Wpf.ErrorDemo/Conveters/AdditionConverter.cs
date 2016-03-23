using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HeaviSoft.Wpf.ErrorDemo.Conveters
{
    public class AdditionConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if(values == null || values.Length != 2)
            {
                return 0;
            }
            int alarmCount = 0;
            if(values[0] != null)
            {
                int.TryParse(values[0].ToString(), out alarmCount);
            }
            int infoCount = 0;
            if(values[1] != null)
            {
                int.TryParse(values[1].ToString(), out infoCount);
            }

            return (alarmCount + infoCount).ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
