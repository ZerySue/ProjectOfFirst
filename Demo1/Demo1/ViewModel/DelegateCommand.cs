using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo1.ViewModel
{
   public  class DelegateCommand :ICommand 
    {
       readonly Action<object> _excute;
       readonly Predicate<object> _canExecute;
       public DelegateCommand(Action<object> excute)
           : this(excute, null)
       {
 
       }

       public DelegateCommand(Action<object>excute,Predicate<object>canExecute)
       {
           if(excute==null)
           throw new ArgumentNullException("excute");
           _excute=excute;
           _canExecute=canExecute;
       }
       public void Execute(object parameter)
       {
           _excute(parameter);
       }
       public bool CanExecute(object parameter)
       {
           return _canExecute==null?true:_canExecute(parameter);
       }
       public event EventHandler CanExecuteChanged
       {
           add{CommandManager.RequerySuggested+=value;}
           remove{CommandManager.RequerySuggested-=value;}
       }
    }
}
