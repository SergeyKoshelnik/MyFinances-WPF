   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	    
MyFinances   MyFinances.View.Analytics   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FMahApps.Metro, Version=1.6.0.362, Culture=neutral, PublicKeyToken=null>mahControls,http://metro.mahapps.com/winfx/xaml/controls  5   	   >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5   	     � Title$  My Finances��5	   	   $	��450��6   $	��800��6*   (  "MahApps.Metro.Controls.MetroWindow   TitleCharacterCasing$ Normal=�66    � WindowStartupLocation$ CenterScreen=�6T    � Icon$5 //MaterialDegignTEST;component/icons/winicon.jpg��6y   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��От:��6   $��0��6   $��0��6,   $
��Left=�6<   $	��Top=�6W   $��10,0,0,0q�6o   $
��Bold"�6�   �� 5   
   $��До:��6   $��0��6   $��1��6,   $
��Left=�6<   $	��Top=�6W   $��10,0,0,0q�6o   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	dtPicker1��5      $��1��6(   $��0��65   $	��Top=�6y   $
��10,0q�6�   $
��Bold"�6�   $��Italic$�6�     5   
   -   5        $ 	dtPicker2��5      $��1��6(   $��1��65   $	��Top=�6y   $
��10,0q�6�   $
��Bold"�6�   $��Italic$�6�   6�   #   LiveCharts.Wpf.CartesianChart  5   
   -   5          Name$ 	liveChart��5      $��2��60   $��2��6=   &    LiveCharts.Wpf.Charts.Base.Chart   Series 6Q   �� *MySeriesCollection+	   AxisY	 5          LiveCharts.Wpf.Axis  
   Title$
 Sales��6   6+      AxisX 5$        $
 Month��6      LabelFormatter 6)   �� *	Formatter+6P   5&      5'      5(      