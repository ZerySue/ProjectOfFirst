   M S B A M L   `   `   `  ����  
WpfDongHua    WpfDongHua.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��700��6   $	��850��6)    � 	Resources 5         Storyboard1 g� RepeatBehavior �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%  &	        �� 5      $ Forever��6#   .��5      U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6#   $ image��6�   .\�5        $ 0��6   $ 0Q�6'     5	      $ 0:0:1��6   $	 360Q�6+   5
      5      5       � Triggers 5      :� 5       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6   5      .��5      �� -   5        	 ��Name$	 Carrier��5      $	��800��6   $	��600��6*   
�������.+�5      �� -   5        
 ��Name$
 image��5      $	��100��6    �� Left$	 280��6)   
 �� Top$	 155��6;   $	��100��6L   $��Images/circulation.png��6X    J� RenderTransformOrigin$ 0.5,0.5&�6x   z�5      V� 5   	   .~�5   
   �� �� 5   
   �� 5   
   T� 5   
   5   
   5      5       5!      