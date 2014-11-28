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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfDongHua
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Rectangle rect; //创建一个方块作为演示对象   
        double speed = 5; //设置移动速度    
        Point moveTo; //设置移动目标
        public MainWindow()
        {
            InitializeComponent();
            rect = new Rectangle();
            rect.Fill = new SolidColorBrush(Colors.Red);
            rect.Width = 50;
            rect.Height = 50; 
            rect.RadiusX = 5; 
            rect.RadiusY = 5;
            Carrier.Children.Add(rect);
            Canvas.SetLeft(rect, 0);
            Canvas.SetTop(rect, 0);
            //定义线程       
            DispatcherTimer dispatcherTimer = new DispatcherTimer(DispatcherPriority.Normal);    
            dispatcherTimer.Tick += new EventHandler(Timer_Tick);
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(50); //重复间隔   
            dispatcherTimer.Start();
            // FunActionLine();
           // KeyFrames();
            //((Storyboard)this.Resources["storyboard"]).Begin();
        }

        private void Carrier_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {   //创建移动动画  
            moveTo = e.GetPosition(Carrier); 
        //    Point p = e.GetPosition(Carrier);
        //    Storyboard storyboard = new Storyboard();             //创建X轴方向动画    
        //    DoubleAnimation doubleAnimation = new DoubleAnimation(Canvas.GetLeft(rect), p.X, new Duration(TimeSpan.FromMilliseconds(500)));
        //    Storyboard.SetTarget(doubleAnimation, rect);
        //    Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("(Canvas.Left)"));
        //    storyboard.Children.Add(doubleAnimation);
        //    //创建Y轴方向动画   
        //    doubleAnimation = new DoubleAnimation(Canvas.GetTop(rect), p.Y, new Duration(TimeSpan.FromMilliseconds(500)));
        //    Storyboard.SetTarget(doubleAnimation, rect);

        //    Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("(Canvas.Top)"));
        //    storyboard.Children.Add(doubleAnimation);
        //    //将动画动态加载进资源内           
        //    if (!Resources.Contains("rectAnimation"))
        //    {
        //        Resources.Add("rectAnimation", storyboard);
        //    }
        //    //动画播放    
        //    storyboard.Begin();
        }

        private void Timer_Tick(object sender, EventArgs e)
        { 
            double rect_X = Canvas.GetLeft(rect);
            double rect_Y = Canvas.GetTop(rect);
            Canvas.SetLeft(rect, rect_X + (rect_X < moveTo.X ? speed : -speed));
            Canvas.SetTop(rect, rect_Y + (rect_Y < moveTo.Y ? speed : -speed));
        } 


        //public void FunAction()
        //{
        //    DoubleAnimation da = new DoubleAnimation();

        //    da.From = 0;//起始值
        //    da.To = 1;
        //    da.Duration = TimeSpan.FromSeconds(3);
        //    this.textBlock1.BeginAnimation(TextBlock.OpacityProperty, da);
        //}
        //public void FunActionLine()
        //{
        //    ThicknessAnimation ta = new ThicknessAnimation();
        //    ta.From = new Thickness(0, 100, 0, 0);
        //    ta.To = new Thickness(240,100,0,0);
        //    ta.Duration = TimeSpan.FromSeconds(3);
        //    this.textBlock1.BeginAnimation(TextBlock.MarginProperty, ta);
        //}
        //public void KeyFrames()
        //{
        //    //Border长度关键帧动画
        //    DoubleAnimationUsingKeyFrames dak = new DoubleAnimationUsingKeyFrames();
        //    //关键帧定义
        //    dak.KeyFrames.Add(new LinearDoubleKeyFrame(0, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))));
        //    dak.KeyFrames.Add(new LinearDoubleKeyFrame(240, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(3))));
        //    dak.KeyFrames.Add(new LinearDoubleKeyFrame(240, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(6))));
        //    dak.KeyFrames.Add(new LinearDoubleKeyFrame(0, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(9))));

        //    dak.BeginTime = TimeSpan.FromSeconds(2);//从第2秒开始动画
        //    dak.RepeatBehavior = new RepeatBehavior(3);//动画重复3次
        //    //开始动画
        //    this.border1.BeginAnimation(Border.WidthProperty, dak);
        //}
    }
}
