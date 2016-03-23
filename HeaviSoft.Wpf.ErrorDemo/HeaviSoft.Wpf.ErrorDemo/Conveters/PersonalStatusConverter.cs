using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HeaviSoft.Wpf.ErrorDemo.Conveters
{
    public class PersonalStatusConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            //values:身高、颜值、存款
            int height; //身高
            int faceScore; //颜值
            decimal savings; //存款

            try
            {
                if(int.TryParse(values[0].ToString(), out height) && 
                   int.TryParse(values[1].ToString(), out faceScore) &&
                   decimal.TryParse(values[2].ToString(), out savings))
                {
                    //高富帅条件:身高180 CM以上、颜值9分以上、存款1000万以上
                    if(height >=180 && faceScore >=9 && savings >= 10000 * 1000)
                    {
                        return "高富帅";
                    }
                    //矮穷矬条件：身高不高于10CM，颜值小于1，存款不多于1元
                    if(height <= 10 && faceScore <= 1 && savings <= 1)
                    {
                        return "矮穷矬";
                    }
                }
            }
            catch (Exception ex){}

            return "身份未知";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
            
        }
    }
}
