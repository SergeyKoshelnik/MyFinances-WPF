   M S B A M L   `   `   `  ����  
MyFinances#    MyFinances.View.EnterQuestion   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FMahApps.Metro, Version=1.6.0.362, Culture=neutral, PublicKeyToken=null>mahControls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  My Finances��5   	   $	��190��6   $	��320��6*   (  "MahApps.Metro.Controls.MetroWindow   TitleCharacterCasing$ Normal=�66    � 
ResizeMode$ NoResize=�6T    � WindowStartupLocation$ CenterScreen=�6j    � Icon$5 //MaterialDegignTEST;component/icons/winicon.jpg��6�   .��5	      �  � RowDefinitions 5   
   �� 5      $	��26* �6   �� 5      $	��39* �6   �� 5      $	��44* �6   �� 5      $	��53* �6   .+�5   
   �� -   5         ��Name$ lblEnterQuestion��5      $D��>Дайте ответ на контрольный вопрос��6.   $��0��6W   $
��Left=�6d   $��10,5,0,0q�6   $	��Top=�6�   $��22��6�   $	��272��6�   $
��Bold"�6�   $��14(�6�   $��2��6�   �� 5   
   -   5        $ lblQuestion��5      $��1��6)   $
��Left=�66   $��10,5,0,0q�6Q   $	��Top=�6c   $��14(�6{   $��30��6�   $	��246��6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ textBoxEnterQuestion��5      $
��Left=�60   $��30��6K   $��10,5,0,0q�6W   $��2��6i    �� TextWrapping$
 Wrap=�6v   $	��Top=�6�   $	��241��6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   $��3��6   	 �� Orientation$	 
Horizontal=�6"   $
��Left=�6;   $��Center=�6V   $	��220��6q   $��
30,11,0,12q�6}   $��30��6�   .+�5      �� -   5        
 ��Name$
 btnEnterQuestionOK��5      $��80��61   $��30��6<   $��Center=�6H   $	��Top=�6e   $��14(�6}   .��5      �� $��/icons/check.png��6   5      �� 5      -   5        $
 btnEnterQuestionExit��5      $��Center=�63   $	��Top=�6P   $��80��6h   $��30��6s   $��14(�6   $��40,0,0,0q�6�   .��5      �� $��/icons/exit-window.png��6   5      5      5!      5"      