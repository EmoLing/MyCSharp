   M S B A M L   `   `   `  ����E  ABankSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Bank_SystemBank_System  5   	   %    Bank_System.WindownContribution   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Bank_System     5   	   -   5          � Title$  WindownContribution��5   	   $	��250��6%   $	��350��62    � 
ResizeMode$ NoResize=�6>   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��101* �6   �� 5      $	��74* �6    � RowDefinitions 5   
   �� 5      �� 5      $��7* �6   .+�5   
   �� $��Сумма вклада��6   $
��Left=�6'   $	��Top=�6B   $��28��6Z   $��96��6f   $��	10,29,0,0q�6q   $��2��6�   �� 5   
   -   5         ��Name$ BoxSum��5      $��1��6"   $��Center=�62    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��128��6|   $��28��6�   $��0,29,0,0q�6�   $��2��6�   6�   �� 5   
   -   5         ��Name$ LabelSum��5      $��0��6"   $
��Left=�6.   $��	10,95,0,0q�6I   $��1��6\   $	��Top=�6i   $��96��6�   $��26��6�   �� 5   
   -   5         ��Name$ 	ButSeeSum��5      $��Показать��6%   $
��Left=�68   $��	10,70,0,0q�6S   $��1��6f   $	��Top=�6s   $��57��6�   $��20��6�   6�   �� 5   
   -   5        $ ButAddCapit��5      $!��Оформить вклад��6'   $
��Left=�6@   $��
10,126,0,0q�6[   $��1��6o   $	��Top=�6|   $��22��6�   $��96��6�   6�   �� 5   
   -   5        $ 	ButCancel��5      $��Отмена��6$   $
��Left=�65   $��117,126,0,0q�6P   $��1��6e   $	��Top=�6r   $��22��6�   $��75��6�    �� IsCancel$
 True��6�   �� 5   
   $8��2Количество месяцев (пример)��6   $��Center=�66   $��0,37,0,0q�6S   $��1��6e   $	��Top=�6r   $	��182��6�   $��28��6�   �� 5   
   -   5        $ BoxCountMonth��5      $��1��6)   $��Center=�69   $��0,37,0,0q�6V   $��1��6h   $
 Wrap=�6u   $	��Top=�6�   $	��128��6�   $��28��6�   6�   	� 5   
   -   5        	 	�Name$	 	RadioWith��5   ,   
 	� 	GroupName$
 	Capitaliz��6   $%��С капитализацией��6?   $��1��6Z   $
��Left=�6j   $��	10,76,0,0q�6�   $��1��6�   $	��Top=�6�    d� 	IsChecked$
 TrueY�6�   6�   	� 5   
   -	   5        $	 RadioWithout��5   ,   $
 	Capitaliz��6   $'��!без капитализации��6B   $��1��6^   $
��Left=�6n   $��
10,101,0,0q�6�   $��1��6�   $	��Top=�6�   6�   5      5      