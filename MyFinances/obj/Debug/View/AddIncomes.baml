   M S B A M L   `   `   `  ����  
MyFinances     MyFinances.View.AddIncomes   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FMahApps.Metro, Version=1.6.0.362, Culture=neutral, PublicKeyToken=null>mahControls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  My Finances��5      $	��260��6   $	��240��6)   (  "MahApps.Metro.Controls.MetroWindow   TitleCharacterCasing$ Normal=�65    � 
ResizeMode$ NoResize=�6S    � WindowStartupLocation$ CenterScreen=�6i    � Icon$5 //MaterialDegignTEST;component/icons/winicon.jpg��6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��25* �6   �� 5      $	��31* �6   �� 5      $	��28* �6   �� 5      $	��34* �6   �� 5      $	��28* �6   �� 5      $	��38* �6   �� 5      $	��48* �6   .+�5   
   �� -   5        $��lblEnterSumm��5      $��0��6$   $��Введите сумму��61   $
��Left=�6I   $	��Top=�6d   $��14(�6|   $��10,0,0,0q�6�   $
��Bold"�6�   $��29��6�   $	��113��6�   $��2��6�   �� 5   
   -   5        $��textBoxEnterSumm��5      $��1��6*   $	��200��67   $
��Left=�6C   $	��Top=�6^   $��10,0,0,0q�6v   $��30��6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   -   5        $��lblEnterComment��5      $��2��6'   $-��'Добавить комментарий��64   $
��Left=�6S   $	��Top=�6n   $��14(�6�   $��10,0,0,0q�6�   $
��Bold"�6�   $��29��6�   $	��175��6�   $��2��6�   �� 5   
   -   5        $��textBoxEnterComment��5      $��3��6-   $
��Left=�6:   $	��200��6U   $	��Top=�6a   $��10,0,0,0q�6y   $��30��6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   -   5        $��lblEnterDate��5      $��4��6$   $.��(Укажите дату операции��61   $
��Left=�6Q   $	��Top=�6l   $��14(�6�   $��10,0,0,0q�6�   $
��Bold"�6�   $��29��6�   $	��174��6�   $��2��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��datePickerIncomes��5      $��5��6.   $
��Left=�6;   $	��Top=�6V   $��10,0,0,0q�6n   $	��200��6�   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   $��30��6�   �� 5   
   $��6��6    �� Orientation$ 
Horizontal=�6"   $
��Left=�6;   $��Center=�6V   $��20,0,0,0q�6q   $��30��6�   $	��183��6�    J� RenderTransformOrigin$ 	0.5,0.828&�6�   .+�5      �� -   5        $��btnAddIncomes��5      $��80��6*   $��30��65   $
��Left=�6A   $	��Top=�6\   $��0q�6t   .��5      �� $��/icons/check.png��6   5      �� 5!      -   5        $��btnCancelAddIncomes��5!      $��80��60   $��30��6;   $
��Left=�6G   $	��Top=�6b   $��20,0,0,0q�6z   .��5"      �� $��/icons/exit-window.png��6   5#      5%      5'      5(      