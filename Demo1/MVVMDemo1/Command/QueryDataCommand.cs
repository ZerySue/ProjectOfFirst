using MVVMDemo1.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo1.Command
{
   class QueryDataCommand:ICommand
    {
        //private QueryDataViewModel _queryDataViewModel;
        //public QueryDataCommand(QueryDataViewModel queryDataViewModel)
        //{
        //    _queryDataViewModel = queryDataViewModel;
        //}

        //public bool CanExecute(object parameter)
        //{
        //    return true;
        //}
        //public event EventHandler CanExecuteChanged
        //{
        //    add { }
        //    remove { }
        //}

        //public void Excute(object parameter)
        //{
        //    _queryDataViewModel.QueryData();
        //}
        public Action<object> ExecuteAction { get; set; }//用于承接事件的执行

        public Func<object, bool> CanExecuteFunc { get; set; }//用于承接判断事件是否可以执行
        public bool CanExecute(object parameter)
        {
            if (CanExecuteFunc == null)
            {
                return true;
            }
            return CanExecuteFunc(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (ExecuteAction == null)
            { return; }
            ExecuteAction(parameter);
        }
    }
  class NotifycationObject : INotifyPropertyChanged
   {

       #region INotifyPropertyChanged 成¨¦员¡À



       public event PropertyChangedEventHandler PropertyChanged;

       public void RasiePropertyChanged(string propertyname)
       {

           if (this.PropertyChanged != null)
           {

               this.PropertyChanged(this, new PropertyChangedEventArgs(propertyname));

           }

       }



       #endregion

   }
}
