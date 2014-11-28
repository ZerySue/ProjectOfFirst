using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace singleApplicationTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.Loaded += MainWindow_Loaded;
            InitializeComponent();
        }
      private  void MainWindow_Loaded(object sender, RoutedEventArgs e)
      {

          this.Title = "MainWindow00";


      }
        private void ButtonClick(object sender,EventArgs e)
        {
            
                //缩小到系统托盘
               // this.Hide();

            
        }
    }
}
