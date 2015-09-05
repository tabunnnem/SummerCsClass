using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelloWPF.Common
{
    class SimpleCommand :ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            onExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;
        private Action<object> onExecute;

        public SimpleCommand(Action<object> command )
        {
            onExecute = command;
        }
    }
}
