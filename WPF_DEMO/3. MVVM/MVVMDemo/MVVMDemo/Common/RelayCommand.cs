using System;
using System.Windows.Input;

namespace MVVMDemo.Common
{
    public class RelayCommand : ICommand
    {
        Action<object> _execteMethod;
        Func<bool, object> _canexecuteMethod;
        public RelayCommand(Action<object> execteMethod, Func<bool, object> canexecuteMethod)
        {
            _execteMethod = execteMethod;
            _canexecuteMethod = canexecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            if (_canexecuteMethod != null)  {
                return  (bool)_canexecuteMethod(Convert.ToBoolean(parameter));     
            }
            else
                return false;
        }

        public event EventHandler CanExecuteChanged
        {
            add  {  CommandManager.RequerySuggested += value;  }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            _execteMethod(parameter);
        }
    }
}
