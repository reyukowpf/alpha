   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5       
Reyuko.App/   )Reyuko.App.Views.ReceivedGood.Skureceived   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5        $	��700��5      $	��240��5	      
�������$��14(�5      $��1q�5      $��Center=�5      $��Center=�63     � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5       5!      5"      .��5%      � .+�5&   
   �� $��Discount��6   $y�Hidden=�6#   $
��Left=�67   $��
10,140,0,0q�6R   $	��Top=�6f   �� 5'   
   $��
SKU / Name��6   $
��Left=�6%   $��	10,60,0,0q�6@   $	��Top=�6S   �� 5(   
   $
��Unit��6   $y�Hidden=�6   $
��Left=�63   $��
330,60,0,0q�6N   $	��Top=�6b   �� 5)   
   $��Price��6   $y�Hidden=�6    $
��Left=�64   $��
495,60,0,0q�6O   $	��Top=�6c   �� 5*   
   $	��Tax��6   $y�Hidden=�6   $
��Left=�62   $��330,140,0,0q�6M   $	��Top=�6b   �� 5+   
   $��Total��6   $
��Left=�6    $��
170,60,0,0q�6;   $	��Top=�6O   �� 5,   
   -   5         ��Name$
 info��5,      $
��Left=�6   $��170,110,0,0q�69   $	��Top=�6N   �� 5-   
   $��Total��6   $y�Hidden=�6    $
��Left=�64   $��170,140,0,0q�6O   $	��Top=�6d   �� 5.   
   -   5        	 ��Name$	 txttotal��5.      $
��Left=�6$   $��28��6?   $��
170,90,0,0q�6K   
 �� TextWrapping$

 Wrap=�6_   $	��Top=�6s   $	��150��6�   6�   �� 5/   
   
���   �$��1q�50      $
��Left=�51      $	��Top=�52       �� CornerRadius$ 0��53      $��	10,90,0,0q�6*   ._�54      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��145��6h   .+�55      -   'System.Windows.Controls.AutoCompleteBox  -   5          Name$ srsku��55   +   
������ $��Center=�6v   $��28��6�   $	��110��6�   $��-1,0,0,0q�6�   $��Center=�6�      ValueMemberPath$	 SKU��6�      Text 6:   �� *SKU+ �� Mode$ TwoWay=�   ItemTemplate 56      �� 57      .R�58      ��  �� Orientation$ 
Horizontal=�6)   .+�59   "   �� ��6,   �� *SKU+5:      5;      5=      �� 5>      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��0,0,0,0q�6�   5?      5@      �� 5A   
   
���   �$��1q�5B      $	��152��5C      $��28��5D      $
��Left=�5E      $	��Top=�5F      $ 0��5G      $y�Visible=�6*   $��
330,90,0,0q�6?   ._�5H      �� -   5         ��Name$ txtunit��5H      $
��12.5(�6)   $
��Left=�69   $��22��6T   $��0,4,0,0q�6`   $
��Wrap=�6q   $	��Top=�6�   $	��152��6�   5I      �� 5J   
   
���   �$��1q�5K      $
��Left=�5L      $	��Top=�5M      $ 0��5N      $y�Visible=�6*   $��
495,90,0,0q�6?   ._�5O      �� -   5        $ txtprice��5O      $
��12.5(�6*   $	��Top=�6:   $
��Left=�6R   $��22��6m   $��0,4,0,0q�6y   $
��Wrap=�6�   $	��152��6�   5P      �� 5Q      -   5        $ 	txtdiskon��5Q      $y�Visible=�6+   $
��12.5(�6@   $
��Left=�6P   $��22��6k   $��0,4,0,0q�6w   $
��Wrap=�6�   $	��Top=�6�   $	��152��6�   �� 5R      -   5        $ txttax��5R      $y�Visible=�6(   $
��12.5(�6=   $
��Left=�6M   $��22��6h   $��0,4,0,0q�6t   $
��Wrap=�6�   $	��Top=�6�   $	��152��6�   �� 5S   
   -	   5        $ txttotaltax��5S      $
��12.5(�6)   $y�Hidden=�69   $
��Left=�6M   $��28��6h   $��330,165,0,0q�6t   $
��Wrap=�6�   $	��Top=�6�   $	��152��6�   �� 5T   
   -
   5        $ 	txttotal1��5T      $y�Visible=�6'   $
��Left=�6<   $��28��6W   $��170,165,0,0q�6c   $
��Wrap=�6x   $	��Top=�6�   $	��150��6�   �� 5U   
   -   5        $ 
txtdiskon1��5U      $y�Visible=�6(   $
��Left=�6=   $��28��6X   $��
10,165,0,0q�6d   $
��Wrap=�6x   $	��Top=�6�   $	��150��6�   �� 5V   
   -   5        $��Right=�5V      $��
0,18,100,0q�6-   
������ $��0q�6Z   #��[  5W      $	��Top=�6/   $��60��6G   .��5X      �� $ 
Horizontal=�6   .+�5Y      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5Z      $
�� Add��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5[      5\      �� 5]   
   -   5        $��Right=�5]      $��	0,18,20,0q�6-   
������ $��0q�6Y   #��[  5^      $	��Top=�6/   $��70��6G   .��5_      �� $ 
Horizontal=�6   .+�5`      �� $,��&/Reyuko.App;component/Icons/close2.png��6   $��20��6H   �� 5a      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5b      5c      5d      5e      