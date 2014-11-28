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

namespace BackDrap
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            EasingFunctionBase easing = new ElasticEase()
            {
                EasingMode = EasingMode.EaseOut,
                Oscillations = 5,
                Springiness = 10
            };

            DoubleAnimation inAnimation = new DoubleAnimation()
            {
                From = 0.1,
                To = 1,
                EasingFunction = easing,
                Duration = new Duration(TimeSpan.FromSeconds(5))
            };

            AnimationClock clock = inAnimation.CreateClock();
            this.m_Scale.ApplyAnimationClock(ScaleTransform.ScaleXProperty, clock);
            this.m_Scale.ApplyAnimationClock(ScaleTransform.ScaleYProperty, clock);
        }
    }
}
