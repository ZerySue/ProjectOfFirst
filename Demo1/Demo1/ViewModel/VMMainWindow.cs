using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.ViewModel
{
    public class VMMainWindow : ViewModelBase
    {
        private string _input;
        public string Input
        {
            get { return _input; }
            set { _input = value; RaisePropertyChangde("Input"); }
        }

        private string _display;
        public string Display 
        {
            get { return _display; }
            set { _display = value; RaisePropertyChangde("Display"); }
        }

        public DelegateCommand SetTextCommand 
        {
            get; 
            set;
        }

        private void SetText(object obj)
        { 
            Display = Input;
        }
        public VMMainWindow()
        {
            SetTextCommand = new DelegateCommand(new Action<object>(SetText));
        }
    }
    
   
}
