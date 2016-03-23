using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HeaviSoft.Wpf.ErrorDemo.Base
{
    public class UICommand : ICommand
    {
        public Func<object, bool> CanExecuting;
        public Action<object> Executing;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if(CanExecuting == null)
            {
                return true;
            }
            return CanExecuting(parameter);
        }

        public void Execute(object parameter)
        {
            if(Executing != null)
            {
                Executing(parameter);
            }
        }
    }
}
