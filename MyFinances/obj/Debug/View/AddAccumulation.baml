   M S B A M L   `   `   `  ����  
MyFinances%    MyFinances.View.AddAccumulation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FMahApps.Metro, Version=1.6.0.362, Culture=neutral, PublicKeyToken=null>mahControls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  My Finances��5   	   $	��260��6   $	��240��6*   (  "MahApps.Metro.Controls.MetroWindow   TitleCharacterCasing$ Normal=�66    � 
ResizeMode$ CanMinimize=�6T    � WindowStartupLocation$ CenterScreen=�6m    � Icon$5 //MaterialDegignTEST;component/icons/winicon.jpg��6�   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��lblEnterNameAccumulation��5      $��0��60   $-��'Наименование покупки��6=   $
��Left=�6\   $	��Top=�6w   $��14(�6�   $��10,0,0,0q�6�   $
��Bold"�6�   �� 5   
   -   5        $"��textBoxEnterNameAccumulation��5      $��1��66   $
��Left=�6C   $	��200��6^   $	��Top=�6j   $��10,0,0,0q�6�   $��30��6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   -   5        $��lblEnterSummAccumulation��5      $��2��60   $'��!Стоимость покупки��6=   $
��Left=�6Y   $	��Top=�6t   $��14(�6�   $��10,0,0,0q�6�   $
��Bold"�6�   �� 5   
   -   5        $"��textBoxEnterSummAccumulation��5      $��3��66   $	��200��6C   $
��Left=�6O   $	��Top=�6j   $��10,0,0,0q�6�   $��30��6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   -   5        $��lblEnterDateAccumulation��5      $��4��60   $��Дата��6=   $
��Left=�6L   $	��Top=�6g   $��14(�6   $��10,0,0,0q�6�   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��datePickerAccumulation��5      $��5��63   $
��Left=�6@   $	��Top=�6[   $��10,0,0,0q�6s   $	��200��6�   $��14(�6�   $��30��6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   $��6��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $	��Top=�6X   $	��200��6p   .+�5      �� -   5        $��btnAddAccumulation��5      $��70��6/   $��25��6:   $
��Left=�6F   $	��Top=�6a   $��0q�6y   .��5      �� $��/icons/check.png��6   5      �� 5      -   5        $��btnCancelAddAccumulation��5      $��70��65   $��25��6@   $��Right=�6L   $	��Top=�6h   $��40,0,0,0q�6�   .��5      �� $��/icons/exit-window.png��6   5       5!      5"      5#      