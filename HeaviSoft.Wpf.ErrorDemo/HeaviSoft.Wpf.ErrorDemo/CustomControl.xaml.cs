using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HeaviSoft.Wpf.ErrorDemo
{
    /// <summary>
    /// Interaction logic for CustomControl.xaml
    /// </summary>
    public partial class CustomControl : UserControl
    {
        public CustomControl()
        {
            InitializeComponent();
        }

        #region 依赖属性
        public static readonly DependencyProperty MyWidthDependencyProperty = DependencyProperty.Register("MyWidth", typeof(int), typeof(CustomControl), new FrameworkPropertyMetadata(
         (d, e) =>
         {
             if (d is CustomControl)
             {
             }
         }));

        public int MyWidth
        {
            get { return (int)GetValue(MyWidthDependencyProperty); }
            set { SetValue(MyWidthDependencyProperty, value); }
        }

        #endregion

        #region 附加属性
        public static readonly DependencyProperty MyHeightDependencyProperty = DependencyProperty.RegisterAttached("MyHeight", typeof(int), typeof(CustomControl), new FrameworkPropertyMetadata(
         (d, e) =>
         {
             if (d is CustomControl)
             {
             }
         }));

        public static void SetMyHeight(DependencyObject obj, int value)
        {
            obj.SetValue(MyHeightDependencyProperty, value);
        }

        public static int GetMyHeight(DependencyObject obj)
        {
            return (int)obj.GetValue(MyHeightDependencyProperty);
        }
        #endregion
    }
}
