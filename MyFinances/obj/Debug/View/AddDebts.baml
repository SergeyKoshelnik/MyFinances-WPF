   M S B A M L   `   `   `  ����  
MyFinances    MyFinances.View.AddDebts   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FMahApps.Metro, Version=1.6.0.362, Culture=neutral, PublicKeyToken=null>mahControls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  My Finances��5   	   $	��280��6   $	��260��6*   (  "MahApps.Metro.Controls.MetroWindow   TitleCharacterCasing$ Normal=�66    � 
ResizeMode$ NoResize=�6T    � WindowStartupLocation$ CenterScreen=�6j    � Icon$5 //MaterialDegignTEST;component/icons/winicon.jpg��6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��29* �6   �� 5      $	��36* �6   �� 5      $	��29* �6   �� 5      $	��38* �6   �� 5      $	��34* �6   �� 5      $	��40* �6   �� 5      $	��46* �6   .+�5   
   �� -   5        $��lblEnterNameDebt��5      $��2��6(   $��Имя должника��65   $
��Left=�6L   $	��Top=�6g   $��14(�6   $��10,2,0,0q�6�   $
��Bold"�6�   $��29��6�   $	��114��6�   $��2��6�   �� 5   
   -   5        $��textBoxEnterNameDebt��5      $��3��6.   $
��Left=�6;   $	��200��6V   $	��Top=�6b   $��10,2,0,0q�6z   $��30��6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   -   5        $��lblEnterSummDebt��5      $��0��6(   $��Введите сумму��65   $
��Left=�6M   $	��Top=�6h   $��14(�6�   $��10,0,0,0q�6�   $
��Bold"�6�   $��29��6�   $	��113��6�   �� 5   
   -   5        $��textBoxEnterSummDebt��5      $��1��6.   $	��200��6;   $
��Left=�6G   $	��Top=�6b   $��10,2,0,0q�6z   $��30��6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   -   5        $��lblEnterDateEndDebt��5      $��4��6+   $��Вернуть до...��68   $
��Left=�6P   $	��Top=�6k   $��14(�6�   $��10,2,0,0q�6�   $
��Bold"�6�   $��29��6�   $��98��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��datePickerDebts��5      $��5��6,   $
��Left=�69   $	��Top=�6T   $��10,0,0,0q�6l   $	��200��6~   $��14(�6�   $��30��6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   $��6��6    �� Orientation$ 
Horizontal=�6"   $��30��6;   $
��27,0q�6G   $	��200��6U   $	��Top=�6a   $��Center=�6y   .+�5      �� -   5        $��btnAddDebts��5      $��80��6(   $��30��63   $
��Left=�6?   $	��Top=�6Z   $��0q�6r   .��5      �� $��/icons/check.png��6   5      �� 5      -   5        $��btnCancelAddDebts��5      $��80��6.   $��30��69   $
��Left=�6E   $	��Top=�6`   $��30,0,0,0q�6x   .��5       �� $��/icons/exit-window.png��6   5!      5#      5$      5%      