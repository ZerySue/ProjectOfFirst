using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Animals
{
	public partial class bird : UserControl
	{
		public bird()
		{
			// 为初始化变量所必需
			InitializeComponent();
            VisualStateManager.GoToState(this, "Hover", true);
            VisualStateManager.GoToState(this, "Wings", true);
		}
	}
}