using HeaviSoft.Wpf.ErrorDemo.Base;
using HeaviSoft.Wpf.ErrorDemo.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HeaviSoft.Wpf.ErrorDemo.ViewModel
{
    public class PortaitViewModel : ModelBase
    {
        public PortaitViewModel(IEnumerable<Portait> portaits)
        {
            PortaitList = new ObservableCollection<Portait>(portaits);
        }

        public ObservableCollection<Portait> PortaitList { get; set; }

        private ICommand _deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                return _deleteCommand ?? new UICommand()
                {
                    Executing = (parameter) =>
                    {
                        PortaitList.Remove(parameter as Portait);
                    }
                };
            }
        }
    }
}
