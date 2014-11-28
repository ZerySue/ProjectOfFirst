using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo1.ViewModel
{
  public abstract  class ViewModelBase:INotifyPropertyChanged
    { 
      //属性改变事件
      public event PropertyChangedEventHandler PropertyChanged;
      //当属性改变时，调用该方法发起一个消息，通知View中绑定了propertyName的元素做出调整
      public void RaisePropertyChangde(string propertyName)
      {
          PropertyChangedEventHandler handler = PropertyChanged;
          if (handler != null)
          {
              handler(this, new PropertyChangedEventArgs(propertyName));
          }
      }
   
   
  
  }
  
}
