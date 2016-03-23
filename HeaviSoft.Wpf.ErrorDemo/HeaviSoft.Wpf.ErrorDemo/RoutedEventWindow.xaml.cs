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
using System.Windows.Shapes;

namespace HeaviSoft.Wpf.ErrorDemo
{
    /// <summary>
    /// Interaction logic for RoutedEventWindow.xaml
    /// </summary>
    public partial class RoutedEventWindow : Window
    {
        public RoutedEventWindow()
        {
            InitializeComponent();
        }
        #region 隧道策略
        private void Grid1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PrintEventLog(sender, e, "隧道");
        }

        private void Grid1_1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PrintEventLog(sender, e, "隧道");
        }

        private void Grid1_1_1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PrintEventLog(sender, e, "隧道");
            e.Handled = true;
        }

        #endregion

        private void PrintEventLog(object sender, RoutedEventArgs e, string action)
        {
            var host = sender as FrameworkElement;
            var source = e.Source as FrameworkElement;
            var orignalSource = e.OriginalSource as FrameworkElement;
            Console.WriteLine("策略:{3}, sender: {2}, Source: {0}, OriginalSource: {1}", source.Name, orignalSource.Name, host.Name, action);
        }

        #region 冒泡策略

        private void Grid1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PrintEventLog(sender, e, "冒泡策略");
        }

        private void Grid1_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PrintEventLog(sender, e, "冒泡策略");
        }

        private void Grid1_1_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PrintEventLog(sender, e, "冒泡策略");
        }

        #endregion
    }
}
