   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5       
Reyuko.App&    Reyuko.App.Views.SalesReturn.Sku   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5        $	��700��5      $	��300��5	        � WindowStyle$
  None=�5
      $��14(�5       � Icon$. (/Reyuko.App;component/Icons/currency.png��5       � 
ResizeMode$ NoResize=�5      $��1q�5       � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�5      $��Center=�5      $��Center=�63    � 	Resources 5         MyButton �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5      
 5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5       5"      5$      5%      5&      .��5)      � .+�5*   
   �� $	��217��5+      $��42��5,      $��	10,10,0,0q�5-      $
��Left=�5.      $	��Top=�5/      $��Segoe)�50      $��36(�51      $��Normal$�52      $��
SKU / Name��53      $
��Wrap=�54      �� 55   
   $��Discount��6   $
��Left=�6#   $��
10,140,0,0q�6>   $	��Top=�6R   �� 56   
   $��
SKU / Name��6   $
��Left=�6%   $��	10,60,0,0q�6@   $	��Top=�6S   �� 57   
   $
��Unit��6   $
��Left=�6   $��
330,60,0,0q�6:   $	��Top=�6N   �� 58   
   $��Price��6   $
��Left=�6    $��
495,60,0,0q�6;   $	��Top=�6O   �� 59   
   $	��Tax��6   $
��Left=�6   $��330,140,0,0q�69   $	��Top=�6N   �� 5:   
   $��Total��6   $
��Left=�6    $��
170,60,0,0q�6;   $	��Top=�6O   �� 5;   
   -   5         ��Name$
 info��5;      $
��Left=�6   $��170,110,0,0q�69   $	��Top=�6N   �� 5<   
   $��Total��6   $
��Left=�6    $��170,140,0,0q�6;   $	��Top=�6P   �� 5=   
   -   5         ��Name$ txttotal��5=      $
��Left=�6$   $��28��6?   $��
170,90,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��150��6�   6�   �� 5>   
   
���   �$��1q�5?      $
��Left=�5@      $	��Top=�5A       �� CornerRadius$ 0��5B      $��	10,90,0,0q�6*   ._�5C      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��145��6h   .+�5D      -   'System.Windows.Controls.AutoCompleteBox  -   5          Name$ srsku��5D   +   
������ $��Center=�6v   $��28��6�   $	��110��6�   $��-1,0,0,0q�6�   $��Center=�6�      ValueMemberPath$	 SKU��6�      Text 6:   �� *SKU+ �� Mode$ TwoWay=�   ItemTemplate 5E      �� 5F      .R�5G      ��  �� Orientation$ 
Horizontal=�6)   .+�5H   "   �� ��6,   �� *SKU+5I      5J      5L      �� 5M      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��0,0,0,0q�6�   5N      5O      �� 5P   
   
���   �$��1q�5Q      $	��152��5R      $��28��5S      $
��Left=�5T      $	��Top=�5U      $ 0��5V      $��
330,90,0,0q�6*   ._�5W      �� -   5         ��Name$ txtunit��5W      $
��12.5(�6)   $
��Left=�69   $��22��6T   $��0,4,0,0q�6`   $
��Wrap=�6q   $	��Top=�6�   $	��152��6�   5X      �� 5Y   
   
���   �$��1q�5Z      $
��Left=�5[      $	��Top=�5\      $ 0��5]      $��
495,90,0,0q�6*   ._�5^      �� -   5        $ txtprice��5^      $
��12.5(�6*   $	��Top=�6:   $
��Left=�6R   $��22��6m   $��0,4,0,0q�6y   $
��Wrap=�6�   $	��152��6�   5_      �� 5`      -   5        $ 	txtdiskon��5`      $y�Hidden=�6+   $
��12.5(�6?   $
��Left=�6O   $��22��6j   $��0,4,0,0q�6v   $
��Wrap=�6�   $	��Top=�6�   $	��152��6�   �� 5a      -   5        $ txttax��5a      $y�Hidden=�6(   $
��12.5(�6<   $
��Left=�6L   $��22��6g   $��0,4,0,0q�6s   $
��Wrap=�6�   $	��Top=�6�   $	��152��6�   �� 5b   
   -	   5        $ txttotaltax��5b      $
��12.5(�6)   $
��Left=�69   $��28��6T   $��330,165,0,0q�6`   $
��Wrap=�6u   $	��Top=�6�   $	��152��6�   �� 5c   
   -
   5        $ 	txttotal1��5c      $
��Left=�6'   $��28��6B   $��170,165,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   $	��150��6�   �� 5d   
   -   5        $ 
txtdiskon1��5d      $
��Left=�6(   $��28��6C   $��
10,165,0,0q�6O   $
��Wrap=�6c   $	��Top=�6w   $	��150��6�   �� 5e   
   -   5        $��Right=�5e      $��
0,18,100,0q�6-   
������ $��0q�6Z   #��[  5f      $	��Top=�6/   $��60��6G   .��5g      �� $ 
Horizontal=�6   .+�5h      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5i      $
�� Add��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5j      5k      �� 5l   
   -   5        $��Right=�5l      $��	0,18,20,0q�6-   
������ $��0q�6Y   #��[  5m      $	��Top=�6/   $��70��6G   .��5n      �� $ 
Horizontal=�6   .+�5o      �� $,��&/Reyuko.App;component/Icons/close2.png��6   $��20��6H   �� 5p      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5q      5r      5s      5t      