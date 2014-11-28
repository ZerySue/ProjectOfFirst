﻿using System;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Waitting
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.Storyboard1.Begin();
            
        }
        public void FunAction()
        {
            DoubleAnimation da = new DoubleAnimation();

            da.From = 0;//起始值
            da.To = 1;
            da.Duration = TimeSpan.FromSeconds(3);
            this.Downloadlb.BeginAnimation(TextBlock.OpacityProperty, da);

           
        }
    }
}
