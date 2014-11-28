using SLDemo1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SLDemo1
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 造些假数据。项目中数据来自数据库
            List<InfoModel> msgList = new List<InfoModel>();
            for (int i = 0; i < 30; i++)
            {
                InfoModel msg = new InfoModel()
                {
                    Title = "Message Title " + i.ToString(),
                    OpenedBy = (i % 2 == 0) ? "Tom" : "Tim",
                    OpenTime = DateTime.Now.ToShortDateString(),
                    Content = (i % 2 == 0) ? "水之真谛" : @"http://blog.csdn.net/FantasiaX"
                };
                msgList.Add(msg);
            }
            this.listBox.ItemsSource = msgList;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            StackPanel p = VisualTreeHelper.GetParent(b) as StackPanel;
            p = VisualTreeHelper.GetParent(p) as StackPanel;
            p = p.FindName("detailPanel") as StackPanel;
            if (p.Visibility == Visibility.Collapsed)
            {
                p.Visibility = Visibility.Visible;
            }
            else
            {
                p.Visibility = Visibility.Collapsed;
            }
        }
    }
}
