   M S B A M L   `   `   `  ����E  AMyFinances, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MyFinances
MyFinances  5   	   7 clr-namespace:MyFinances.HelpersMyFinances.Helpers  5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullI:clr-namespace:ControlzEx;assembly=MaterialDesignThemes.Wpf
ControlzEx 5
   	       MyFinances.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MyFinances     5   	   9localhelpers clr-namespace:MyFinances.Helpers     5   	   J FMahApps.Metro, Version=1.6.0.362, Culture=neutral, PublicKeyToken=null>mahControls,http://metro.mahapps.com/winfx/xaml/controls  5   	   Y UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5	   	   M
controlzEx:clr-namespace:ControlzEx;assembly=MaterialDesignThemes.Wpf   5
   	   -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$  MetroWindow��5         MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	     AccentColorBrush   	GlowBrush# �  5   	    � Title$ My Finances��5   	   $	��285��6   $	��320��6*      TitleCharacterCasing$ Normal=�66    � WindowStartupLocation$ CenterScreen=�6U    � Icon$ icons/winicon.jpg��6�    � 
ResizeMode$ CanMinimize=�6�    � 	Resources 5       �� MergedDictionaries	 �� Source$   MyFinances.SolidBrushConverter  SolidBrushConverter2   ,MyFinances.Helpers.EnterPasswordDialogHelper  EnterPasswordDialogHelper�� 5   
    5      �� 5      $f	 `pack://application:,,,/MaterialDesignThemes.Wpf;component/themes/materialdesigntheme.button.xaml?�6%   �� 5      $l	 fpack://application:,,,/MaterialDesignThemes.Wpf;component/themes/materialdesigntheme.togglebutton.xaml?�6%   �� 5      $V	 Ppack://application:,,,/MahApps.Metro;component/styles/controls.toggleswitch.xaml?�6%   %:   &	       &	        5      6(     5      65   5      .��5       � 
 � RowDefinitions
 5!   
   �� 5"      $	��91* �6   �� 5#      $	��63* �6   �� 5$      $	��41* �6   �� 5%      $	��62* �6    � ColumnDefinitions 5(   
   �� 5)      �� 5*      $
��0.7* �6   .+�5-   
   �� .+�5.      �� -   5         ��Name$ lblUsers��5.      $/��)Выберите пользователя��6&   $��
10,20,0,10q�6F   $
��Left=�6Z   $��14(�6u   $
��Bold"�6�   �� 5/      -   5         ��Name$ comboBoxUsers��5/      $��0��6.   $��15,0,0,0q�6>   $	��Top=�6P   $
��Left=�6h   $	��165��6�   $
��Bold"�6�   $��Italic$�6�   50      �� 52   
   -   5         ��Name$ btnManagerUsers��52      $��1��6*   $��5,45,0,0q�6:   $��50��6L   $	��Top=�6W   $
��Left=�6o   $��35��6�   .��53      �� $��icons/users.png��6   $��Center=�6-   $��Center=�6J   54      )  #MaterialDesignThemes.Wpf.DialogHost  58   
   -   5          Name$ 
DialogHost��58   $      DialogMargin$ 0,20,0,0q�68   $��2��6P   $��1��6d      
PopupStyle 59      �� 5:       �� 
TargetType  ControlzEx.PopupEx"  6    ! MaterialDesignDialogHostPopup �� BasedOn# [ 69   .�5;      ��  �� Property �@�VerticalOffset �� Value 5<      `� 5=       `� 	Converter# [ 6+   .1�5>   "   ��  �� Path$ ActualHeight�6*    �� ElementName$ 
DialogHost��6>   �� 5?   "   $ Child.ActualHeight�6*    �� RelativeSource 6D   �� *Self+5@      5B      5C         DialogContent 5E      �� 5F      $��20q�6   $	��250��6)   .+�5G      �� $��Пользователь:��6    $
��Bold"�65   �� 5H      $
��Bold"�6�   $��Italic$�6�   ��6   �� $ comboBoxUsers��$ SelectedItem� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5I      $��Пароль: ��6    $
��Bold"�60   $��0,10,0,0q�6B   G� 5J      -   5        $��passwordBoxApplyPassword��5J   "   � 5L      $��
0,10,0,-10q�6    5M      �� 5N      �� 5O      .+�5R      �� -   5        $��btnApplyUser��5R   !   $��Подтвердить��65     MaterialDesignFlatButton#��[ 6K    �� 	IsDefault . 5S      �� 5T      $��Закрыть��6!   $��1��63    " MaterialDesignFlatAccentButton#��[ 6C    �� IsCancel .    CloseDialogCommand#��Z 6�   5V      5W      .��5\      �� -   5        $ btnEnterUser��5\      $��Center=�5]      $��0,30,0,0q�66   $	��Top=�6I   $	��160��5^      $��30��6%   $��16(�61       OpenDialogCommand#��Z  5_      .��5`      �� ! �� Orientation$! 
Horizontal=�6   .+�5a      �� $��/icons/log-in.png��6   �� 5b      $��
Войти��6    $��10,0,0,0q�6-   5c      5e      5g      �� 5j   
   -	   5        $ btnExitMainWindow��5j      $��Center=�6,   $��
77,10,77,0q�6I   $��2��6]   $��2��6j   $	��Top=�6~   $	��160��6�   $��30��6�   $��16(�6�   .��5k      �� $! 
Horizontal=�6   .+�5l      �� $��/icons/exit-window.png��6   $��10,0,0,0q�68   �� 5m      $��
Выйти��6   $��5,0,0,0q�6)   5n      5p      )  #MaterialDesignThemes.Wpf.DrawerHost  5u   
   $��0��6L   $��2��6Y   $��4��6m   "   IsLeftDrawerOpen" 6$   �� *
DrawerOpen+#   LeftDrawerContent# 5v      �� 5x      $	��145��6   $��20q�6)   .+�5z      �� $! 
Horizontal=�6!   $��0,0,0,5q�6:   $	��145��6K   $
��Left=�6W   .+�5{      )  #MahApps.Metro.Controls.ToggleSwitch  $   OffLabel$$ Темная тема��6V   %   OnLabel$% Светлая тема��6m    + 'MahApps.Metro.Styles.ToggleSwitch.Win10#��[ 5|      &   	IsChecked& 5{   3   �� *IsLightTheme+5|      5}      �� 5      ��6#   �� *ThemeColors+��5�      �� 5�      .R�5�   "   � 5�      ��5�      �� 5�      ' �� DataType$   MyFinances.ThemeColorViewModel"'  6+   .R�5�   "   � $	��175��6'    5�   &   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   .+�5�   &   �� #��[ 5�   .   $	��175��6`   ��5�   .   �� *DataContext.SetThemeCommand+$ MetroWindow����6w   �� ��5�   .   �� *SampleColor+( �� 	Converter#( [ 5�   '   5�   #   5�      5�      5�      .��5�      ]� ) J� RenderTransformOrigin$) 0.528,1.966&�6   .+�5�      �� 
������ $	��Top=�65   $��
240,37,0,0q�6M   $��50��6b   $��Center=�6n   .@�5�      �� $��50��6   $��35��6(   $��0��64   $��1��6A   *   OpenDrawerCommand#��Z* 6Q   .��5�      �� .+�5�      �� $��icons/palitra.png��6$   $��30��6?   $��18��6K   �� 5�      + �� RadiusY$	+ 100��6)   , �� RadiusX$	, 100��67   5�      5�      5�      5�      5�      5�      5�      