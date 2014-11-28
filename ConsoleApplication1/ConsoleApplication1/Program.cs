using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public delegate int SomeDelegate(string arg1, bool arg2);

        public static int SomeMethod(string arg1, bool arg2) { return 0; }

      //  public int SomeMethod(string a1, bool a2) { return 0; }

       // public event SomeDelegate SomeEvent;
        static void Main(string[] args)
        {
          
           SomeDelegate someDelegate = new SomeDelegate(SomeMethod);

          // SomeEvent += new SomeDelegate(SomeMethod);
        }
    }
}
