   M S B A M L   `   `   `  ����  
MyFinances    MyFinances.View.EditUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FMahApps.Metro, Version=1.6.0.362, Culture=neutral, PublicKeyToken=null>mahControls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  My Finances��5   
   $	��500��6   $	��250��6+   (  "MahApps.Metro.Controls.MetroWindow   TitleCharacterCasing$ Normal=�67    � 
ResizeMode$ NoResize=�6U    � WindowStartupLocation$ CenterScreen=�6l    � Icon$5 //MaterialDegignTEST;component/icons/winicon.jpg��6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��40* �6   �� 5      $	��39* �6   �� 5      $
��143* �6   �� 5      $
��142* �6   �� 5      $
��108* �6   .+�5   
   �� -   5         ��Name$ lblEditNameUser��5      $4��.Введите имя пользователя��6)   $
��Left=�6L   $��	10,10,0,0q�6g   $	��Top=�6z   $��14(�6�   $��29��6�   $	��220��6�   $
��Bold"�6�   �� 5   
   -   5        $��textBoxEditNameUser��5      $��30��6-   $��10,5,0,0q�69   $��1��6K    �� TextWrapping$
 Wrap=�6X   $	��220��6l   $	��Top=�6x   $
��Left=�6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   $��2��6   $��0,1,0,0q�6"   .+�5      �� -   5        $ lblEditPassword��5      $!��Введите пароль��6-   $��10,5,0,0q�6F   $��14(�6X   $
��Left=�6f   $	��Top=�6�   $
��Bold"�6�   G� 5      -   5        $��passwordBoxEditPassword��5      $��10,5,0,0q�69   $	��220��6K   $��30��6W   $
��Left=�6c   $	��Top=�6~   $
��Bold"�6�   $��Italic$�6�   �� 5      -   5        $ lblEditPasswordAgain��5      $%��Повторите пароль��62   $��10,5,0,0q�6M   $��14(�6_   $
��Left=�6m   $	��Top=�6�   $
��Bold"�6�   G� 5      -   5        $"��passwordBoxEditPasswordAgain��5      $��10,5,0,0q�6>   $	��220��6P   $��30��6\   $
��Left=�6h   $	��Top=�6�   5      �� 5   
   $��Center=�6   $��2��60   $	��140��6=   $��	0,141,0,4q�6J   $��2��6]   .+�5       �� -   5        $ lblEditQuestion��5       $8��2Введите контрольный вопрос��6-   $��10,5,0,0q�6R   $��14(�6d   $
��Left=�6r   $	��Top=�6�   $
��Bold"�6�   �� 5!      -   5        $��textBoxEditQuestion��5!      $��10,5,0,0q�61   $	��220��6C   $��30��6O   $
��Left=�6[   $	��Top=�6v   $
��Bold"�6�   $��Italic$�6�   �� 5"      -	   5        $ lblEditResponse��5"      $1��+Введите ответ на вопрос��6-   $��10,5,0,0q�6O   $��14(�6a   $
��Bold"�6o   �� 5#      -
   5        $��textBoxEditResponse��5#      $��10,5,0,0q�61   $	��220��6C   $��30��6O   $
��Left=�6[   $	��Top=�6v   $
��Bold"�6�   $��Italic$�6�   5$      �� 5'   
   $��4��6    �� Orientation$ 
Horizontal=�6"   .+�5(      �� -   5        	 ��Name$	 btnEditUser��5(      $
��Left=�6*   $	��Top=�6E   $��80��6]   $��40��6h   $��24(�6t   $��
15,15,0,23q�6�   .��5)      �� $��/icons/check.png��6   5*      �� 5+      -   5        $	 btnExitEditUser��5+      $��80��6.   $��40��69   $��24(�6E   $��	50,15,0,0q�6S   $
��Left=�6f   $	��Top=�6�   .��5,      �� $��/icons/exit-window.png��6   5-      5.      50      51      