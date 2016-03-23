using HeaviSoft.Wpf.ErrorDemo.Model;
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
    /// Interaction logic for DataBindingMode.xaml
    /// </summary>
    public partial class DataBindingModeWindow : Window
    {
        public DataBindingModeWindow()
        {
            InitializeComponent();

            var data = new DataBindingModeWindowModel() { TBoxText = "TextBox Binding", TBlockText = "TBlockText" };
            this.DataContext = data;
            this.Loaded += DataBindingModeWindow_Loaded;
        }

        private void DataBindingModeWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Binding.AddSourceUpdatedHandler(TBoxResult, new EventHandler<DataTransferEventArgs>((sender1 ,e1) => { /*更新数据源被触发*/ }));
            Binding.AddTargetUpdatedHandler(TBoxResult, new EventHandler<DataTransferEventArgs>((sender1, e1) => { /*更新控件数据被触发*/}));
        }
    }

    public class DataBindingModeWindowModel : ModelBase
    {
        private string _tboxText;
        public string TBoxText
        {
            get { return _tboxText; }
            set
            {
                _tboxText = value;
                OnPropertyChanged("TBoxText");
            }
        }

        private string _tbBlockText;
        public string TBlockText
        {
            get { return _tbBlockText; }
            set
            {
                _tbBlockText = value;
                OnPropertyChanged("TBlockText");
            }
        }
    }
}
