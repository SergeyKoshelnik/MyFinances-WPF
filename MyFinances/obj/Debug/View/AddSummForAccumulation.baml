   M S B A M L   `   `   `  ����  
MyFinances,    &MyFinances.View.AddSummForAccumulation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FMahApps.Metro, Version=1.6.0.362, Culture=neutral, PublicKeyToken=null>mahControls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  My Finances��5      $	��200��6   $	��225��6)   (  "MahApps.Metro.Controls.MetroWindow   TitleCharacterCasing$ Normal=�65    � 
ResizeMode$ NoResize=�6S    � WindowStartupLocation$ CenterScreen=�6i    � Icon$5 //MaterialDegignTEST;component/icons/winicon.jpg��6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��34* �6   �� 5      $	��30* �6   �� 5      $	��32* �6   �� 5      $	��39* �6   �� 5      $	��37* �6   .+�5   
   �� -   5        $��lblEnterNameAccumulation��5      $��0��60   $%��Выберите покупку��6=   $
��Left=�6X   $	��Top=�6s   $��14(�6�   $��10,0,0,0q�6�   $
��Bold"�6�   $��29��6�   $	��138��6�   �� 5   
   -   5        $#��comboBoxEnterNameAccumulation��5      $��1��68   $	��200��6E   $
��Left=�6Q   $	��Top=�6l   $��10,0,0,0q�6�   $
��Bold"�6�   $��Italic$�6�   $��30��6�   �� 5   
   -   5        $��lblAddSummAccumulation��5      $��2��6.   $��Внести сумму��6;   $
��Left=�6R   $	��Top=�6m   $��14(�6�   $��10,0,0,0q�6�   $
��Bold"�6�   $��29��6�   $	��104��6�   �� 5   
   -   5        $ ��textBoxAddSummAccumulation��5      $��3��64   $	��200��6A   $
��Left=�6M   $	��Top=�6h   $��10,0,0,0q�6�   $��30��6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   $��4��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $	��Top=�6X   $	��200��6p   $��25��6|   $��10,0,9,0q�6�   .+�5      �� -   5        $��btnAddSummAccumulation��5      $��70��63   $��25��6>   $
��Left=�6J   $	��Top=�6e   $��5,0,0,0q�6}   .��5      �� $��/icons/check.png��6   5      �� 5      -   5        $"��btnCancelAddSummAccumulation��5      $��70��69   $��25��6D   $��Right=�6P   $	��Top=�6l   $��40,0,0,0q�6�   .��5      �� $��/icons/exit-window.png��6   5      5      5      5      