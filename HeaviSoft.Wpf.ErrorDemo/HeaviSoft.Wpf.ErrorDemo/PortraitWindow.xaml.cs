using HeaviSoft.Wpf.ErrorDemo.Model;
using HeaviSoft.Wpf.ErrorDemo.ViewModel;
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
    /// Interaction logic for PortraitWindow.xaml
    /// </summary>
    public partial class PortraitWindow : Window
    {
        public PortraitWindow()
        {
            InitializeComponent();
            InitializeDataSource();
        }

        private void InitializeDataSource()
        {
            List<Portait> list = new List<Portait>()
            {
                new Portait { Photo = "/images/portraits/高圆圆.jpg", Name = "高圆圆", Birthday = "1979年10月5日", Vocation = "演员" },
                new Portait { Photo = "/images/portraits/杨颖.jpg", Name = "杨颖", Birthday = "1989年2月28日", Vocation = "演员" },
                new Portait { Photo = "/images/portraits/赵薇.jpg", Name = "赵薇", Birthday = "1976年3月12日", Vocation = "演员|导演" },
                new Portait { Photo = "/images/portraits/熊黛林.jpg", Name = "熊黛林", Birthday = "1980年10月10日", Vocation = "演员|模特" }
            };

            var viewModel = new PortaitViewModel(list);
            this.DataContext = viewModel;
        }
    }
}
