using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HeaviSoft.Wpf.ErrorDemo.Conveters
{
    public class UnitConverter : IValueConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">数字</param>
        /// <param name="targetType"></param>
        /// <param name="parameter">单位</param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                return string.Empty;
            }
            if(parameter == null)
            {
                return value;
            }
            return value.ToString() + " " + parameter.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
