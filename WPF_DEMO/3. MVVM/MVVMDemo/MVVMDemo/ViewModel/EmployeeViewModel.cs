using MVVMDemo.Common;
using MVVMDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.ViewModel
{
    class EmployeeViewModel : CommonBase
    {
      
        private Employee _Emp;

        public Employee Emp
        {
            get { return _Emp; }
            set { _Emp = value;
                OnPropertyChanged();
            }
        }
        public ICommand ChangeNameCommand { get; set; }
        public EmployeeViewModel()
        {      
            Emp = new Employee { Id= 1, Name = "Ravi" };
            ChangeNameCommand = new RelayCommand(ExecuteMethod,CanExecuteMethod);
        }

        private object CanExecuteMethod(bool arg)
        {
            if (Emp == null || Emp.Name == "Vikash")
                return false;
            else
                return true;
        }

        private void ExecuteMethod(object obj)
        {
            Emp = new Employee { Id = 2, Name = "Vikash" };
        }
    }
}
