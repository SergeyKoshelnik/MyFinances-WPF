   M S B A M L   `   `   `  ����  
MyFinances    MyFinances.View.AddUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FMahApps.Metro, Version=1.6.0.362, Culture=neutral, PublicKeyToken=null>mahControls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  My Finances��5   	   $	��500��6   $	��250��6*   (  "MahApps.Metro.Controls.MetroWindow   TitleCharacterCasing$ Normal=�66    � 
ResizeMode$ CanMinimize=�6T    � WindowStartupLocation$ CenterScreen=�6m    � Icon$5 //MaterialDegignTEST;component/icons/winicon.jpg��6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��40* �6   �� 5      $	��42* �6   �� 5      $
��139* �6   �� 5      $
��168* �6   �� 5      $	��83* �6   .+�5   
   �� -   5         ��Name$ lblEnterNameUser��5      $4��.Введите имя пользователя��6*   $
��Left=�6M   $��	10,10,0,0q�6h   $	��Top=�6{   $��14(�6�   $��29��6�   $	��220��6�   $
��Bold"�6�   �� 5   
   -   5        $��textBoxEnterNameUser��5      $��30��6.   $��10,5,0,0q�6:   $��1��6L    �� TextWrapping$
 Wrap=�6Y   $	��220��6m   $	��Top=�6y   $
��Left=�6�   $��Italic$�6�   $
��Bold"�6�   �� 5   
   $��2��6   .+�5      �� -   5        $ lblEnterPassword��5      $!��Введите пароль��6.   $��10,2,0,0q�6G   $��14(�6Y   $
��Left=�6g   $	��Top=�6�   $
��Bold"�6�   G� 5      -   5        $��passwordBoxEnterPassword��5      $��10,5,0,0q�6:   $��30��6L   $	��Top=�6X   $	��220��6p   $
��Left=�6|   �� 5      -   5        $ lblEnterPasswordAgain��5      $%��Повторите пароль��63   $��10,5,0,0q�6N   $��14(�6`   $
��Left=�6n   $	��Top=�6�   $
��Bold"�6�   G� 5      -   5        $#��passwordBoxEnterPasswordAgain��5      $��10,5,0,0q�6?   $��30��6Q   $	��Top=�6]   $
��Left=�6u   $	��220��6�   5      �� 5   
   $��Center=�6   $��2��60   $	��152��6=   $��
0,138,0,17q�6J   $��2��6^   .+�5       �� -   5        $ lblEnterQuestion��5       $8��2Введите контрольный вопрос��6.   $��10,0,0,0q�6S   $��14(�6e   $
��Left=�6s   $	��Top=�6�   $
��Bold"�6�   �� 5!      -   5        $��textBoxEnterQuestion��5!      $��10,5,0,0q�62   $��30��6D   $	��Top=�6P   $
��Left=�6h   $	��220��6�   $��Italic$�6�   $
��Bold"�6�   �� 5"      -	   5        $ lblEnterResponse��5"      $1��+Введите ответ на вопрос��6.   $��10,5,0,0q�6P   $��14(�6b   $
��Left=�6p   $	��Top=�6�   $
��Bold"�6�   �� 5#      -
   5        $��textBoxEnterResponse��5#      $��10,5,0,0q�62   $��30��6D   $	��Top=�6P   $	��220��6h   $
��Left=�6t   $��Italic$�6�   $
��Bold"�6�   5$      �� 5'   
   $��4��6    �� Orientation$ 
Horizontal=�6"   .+�5(      �� -   5        	 ��Name$	 btnEnterAddUser��5(      $
��Left=�6.   $	��Top=�6I   $��80��6a   $��40��6l   $��24(�6x   $��	15,0,0,23q�6�   .��5)      �� $��/icons/check.png��6   5*      �� 5+      -   5        $	 btnExitAddUser��5+      $��80��6-   $��40��68   $��24(�6D   $��50,0,0,0q�6R   $
��Left=�6d   $	��Top=�6   .��5,      �� $��/icons/exit-window.png��6   5-      5.      50      51      