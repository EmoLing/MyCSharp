   M S B A M L   `   `   `  ����E  ABankSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Bank_SystemBank_System  5   	   (    "Bank_System.AddWindowNaturalClient   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Bank_System     5   	     � Title$4  .Добавить физическое лицо��5   	   $	��350��6*   $	��400��67    � 
ResizeMode$ NoResize=�6C   .��5	      �  � RowDefinitions 5
   
   �� 5      $��7 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��120* �6   �� 5      $
��267* �6   .+�5   
   �� $��Имя��6   $��1��6   $��Center=�6.   $��1��6K   $��Center=�6X    J� RenderTransformOrigin$ 0.351,0.476&�6s   $	��102��6�   $��30��6�   �� 5   
   $��Фамилия��6   $��1��6"   $��Center=�62   $��2��6O   $��Center=�6\   $ 0.351,0.476&�6w   $	��102��6�   $��30��6�   �� 5   
   $��Дата рождения��6   $��1��6(   $��Center=�68   $��3��6U   $��Center=�6b   $ 0.351,0.476&�6}   $	��102��6�   $��30��6�   �� 5   
   $��Сумма на счет��6   $��1��6(   $��Center=�68   $��4��6U   $��Center=�6b   $ 0.351,0.476&�6}   $	��100��6�   $��30��6�   �� 5   
   -   5         ��Name$ BoxFirstName��5      $��2��6(   $
��Left=�68   $��6,0,0,0q�6S   $��1��6d    �� TextWrapping$
 Wrap=�6r   $��Center=�6�   $	��134��6�   $��30��6�   �� 5    
   -   5        $ BoxLastName��5       $��2��6'   $
��Left=�67   $��6,0,0,0q�6R   $��2��6c   $
 Wrap=�6q   $��Center=�6�   $	��134��6�   $��30��6�   �� 5!   
   -   5        $ BoxBirthday��5!      $��2��6'   $
��Left=�67   $��6,0,0,0q�6R   $��3��6c   $
 Wrap=�6q   $��Center=�6�   $	��134��6�   $��30��6�   �� 5"   
   -   5        $ BoxSum��5"      $
��1000��6"   $��2��6.   $
��Left=�6>   $��6,0,0,0q�6Y   $��4��6j   $
 Wrap=�6x   $��Center=�6�   $	��134��6�   $��30��6�   6�   �� 5$   
   -   5         ��Name$ ButAdd��5$      $��Добавить��6!   $��1��64   $��Center=�6D   $��6��6a   $��Center=�6n   $��80��6�   $��26��6�   6�   �� 5%   
   -   5        $ 	ButCancel��5%      $��Отмена��6$   $��2��65   $
��Left=�6E   $��6,0,0,0q�6`   $��6��6q   $��Center=�6~   $��81��6�   $��26��6�   6�   �� 5'   	   -   5        $ ButOpenCalen��5'      $��2��6&   $
��Left=�66   $��	155,0,0,0q�6Q   $��3��6d   $��Center=�6q   $��33��6�   $��30��6�   ���	#FFDDDDDD.��5(      ��  �� Orientation$ 
Horizontal=�6   .+�5)      �� $��/pic/calendar.png��6   $��0,0,5,0q�63   $��29��6D   $��29��6O   5*      5+      5,      5-      