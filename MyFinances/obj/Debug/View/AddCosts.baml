   M S B A M L   `   `   `  ����  
MyFinances    MyFinances.View.AddCosts   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FMahApps.Metro, Version=1.6.0.362, Culture=neutral, PublicKeyToken=null>mahControls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  My Finances��5   	   $	��320��6   $	��260��6*   (  "MahApps.Metro.Controls.MetroWindow   TitleCharacterCasing$ Normal=�66    � 
ResizeMode$ NoResize=�6T    � WindowStartupLocation$ CenterScreen=�6j    � Icon$5 //MaterialDegignTEST;component/icons/winicon.jpg��6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��33* �6   �� 5      $	��28* �6   �� 5      $	��27* �6   �� 5      $	��34* �6   �� 5      $	��32* �6   �� 5      $	��34* �6   �� 5      $	��31* �6   �� 5      $	��35* �6   �� 5      $	��38* �6   .+�5   
   �� -   5        $��lblEnterCategory��5      $��0��6(   $)��#Выберите категорию��65   $	��Top=�6R   $��10,0,0,0q�6j   $��14(�6|   $
��Left=�6�   $
��Bold"�6�   $��29��6�   $	��155��6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� -   5        $��comboBoxSelectCategory��5      $��1��65   $	��180��6B   $
��Left=�6N   $	��Top=�6i   $��10,0,0,0q�6�   $
��Bold"�6�   $��Italic$�6�   �� 5      -   5        $��btnEnterCategory��5      $	��Top=�6-   $��15,0,0,0q�6E   $
��Left=�5      $��30��60   $
��Bold"�6;   $��25��6M   
������ ��5      �� 5       �� ImageSource$ /icons/add-operation.png��6!    � ToolTip 5!      _� 5"      .��5#      �� $)��#Добавить категорию��6$   5$      5'      5(      �� 5*   
   -   5        $��lblEnterComment��5*      $��2��6'   $-��'Добавить комментарий��64   $
��Left=�6S   $	��Top=�6n   $��14(�6�   $��10,0,0,0q�6�   $
��Bold"�6�   $��29��6�   $	��175��6�   $��2��6�   �� 5+   
   -   5        $��textBoxEnterComment��5+      $��3��6-   $
��Left=�6:   $	��180��6U   $	��Top=�6a   $��10,0,0,0q�6y   $��30��6�   $
��Bold"�6�   $��Italic$�6�   �� 5,   
   -   5        $��lblEnterDate��5,      $��4��6$   $.��(Укажите дату операции��61   $
��Left=�6Q   $	��Top=�6l   $��14(�6�   $��10,0,0,0q�6�   $
��Bold"�6�   $��29��6�   $	��174��6�   (  "System.Windows.Controls.DatePicker  5-   
   -   5        $��datePickerCosts��5-      $��5��6,   $
��Left=�69   $	��Top=�6T   $��10,0,0,0q�6l   $	��200��6~   $
��Bold"�6�   $��Italic$�6�   $��27��6�   �� 5.   
   -   5        $��lblEnterSumm��5.      $��6��6$   $��Введите сумму��61   $
��Left=�6I   $	��Top=�6d   $��14(�6|   $��10,0,0,0q�6�   $
��Bold"�6�   $��29��6�   $	��113��6�   �� 5/   
   -	   5        $��textBoxEnterSumm��5/      $��7��6*   $	��180��67   $
��Left=�6C   $	��Top=�6^   $��10,0,0,0q�6v   $��30��6�   $
��Bold"�6�   $��Italic$�6�   �� 51   
   $��8��6   $ 
Horizontal=�6"   .+�53      �� -
   5        $��btnAddCosts��53      $��80��6(   $��30��63   $
��Left=�6?   $	��Top=�6Z   $��20,0,0,0q�6r   .��54      �� $��/icons/check.png��6   55      �� 57      -   5        $��btnCancelAddCosts��57      $��80��6.   $��30��69   $
��Left=�6E   $	��Top=�6`   $��20,0,0,0q�6x   .��58      �� $��/icons/exit-window.png��6   59      5;      5=      5>      