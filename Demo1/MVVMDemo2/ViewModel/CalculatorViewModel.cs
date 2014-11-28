using MVVMDemo2.Command;
using MVVMDemo2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo2.ViewModel
{
    class CalculatorViewModel
    {
        public DelegateCommand CopyCmd { get; set; }        
        public CauculatorModel model { get; set; }

        public CalculatorViewModel()
        {
            this.model = new CauculatorModel();
            this.CopyCmd = new DelegateCommand();
            this.CopyCmd.ExecuteCommand = new Action<object>(this.model.Copy);
        }
    }
   
}
