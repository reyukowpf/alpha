   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5       
Reyuko.App.   (Reyuko.App.Views.SalaryPayment.Employees   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5        $	��668��5      $	��300��5	        � WindowStyle$
  None=�5
      $��14(�5       � Icon$. (/Reyuko.App;component/Icons/currency.png��5       � 
ResizeMode$ NoResize=�5      $��1q�5       � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�5      $��Center=�5      $��Center=�63    � 	Resources 5         MyButton �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5      
 5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5       5"      5$      5%      5&      .��5)      � $��0,0,8,8q�6   .+�5*   
   �� $	��178��5+      $��42��5,      $��	10,10,0,0q�5-      $
��Left=�5.      $	��Top=�5/      $��Segoe)�50      $��36(�51      $��Normal$�52      $��Employee��53      $
��Wrap=�54      �� 55   
   $��Salary Payment No.��6   $
��Left=�6-   $��	10,60,0,0q�6H   $	��Top=�6[   �� 56   
   $��Employee / ID��6   $
��Left=�6(   $��
170,60,0,0q�6C   $	��Top=�6W   �� 57   
   $��Email��6   $
��Left=�6    $��
330,60,0,0q�6;   $	��Top=�6O   �� 58   
   $��phone Number��6   $
��Left=�6'   $��
495,60,0,0q�6B   $	��Top=�6V   �� 59   
   $��Overtime Hour��6   $
��Left=�6(   $��
10,127,0,0q�6C   $	��Top=�6W   �� 5:   
   $��Overtime��6   $
��Left=�6#   $��170,127,0,0q�6>   $	��Top=�6S   �� 5;   
   $��Total Overtime��6   $
��Left=�6)   $��495,127,0,0q�6D   $	��Top=�6Y   �� 5<   
   $��Others��6   $
��Left=�6!   $��330,127,0,0q�6<   $	��Top=�6Q   �� 5=   
   $
��Note��6   $
��Left=�6   $��
10,190,0,0q�6:   $	��Top=�6N   �� 5>   
   $��Total��6   $
��Left=�6    $��330,190,0,0q�6;   $	��Top=�6P   �� 5?   
   -   5         ��Name$ txtnosalary��5?      $
��Left=�6'   $��28��6B   $��	10,90,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��150��6�   �� 5@   
   -   5        $ txtovertimehour��5@      $
��Left=�6+   $��28��6F   $��
10,152,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��150��6�   �� 5A   
   -   5        $ 	txtsalary��5A      $y�Hidden=�6%   $
��Left=�69   $��28��6T   $��
10,165,0,0q�6`   $
 Wrap=�6t   $	��Top=�6�   $	��150��6�   �� 5B   
   -   5        $ txttunjangan��5B      $y�Hidden=�6(   $
��Left=�6<   $��28��6W   $��
10,165,0,0q�6c   $
 Wrap=�6w   $	��Top=�6�   $	��150��6�   �� 5C   
   -   5        $ 	txttotal1��5C      $
��Left=�6%   $��28��6@   $��330,215,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��150��6�   �� 5D   
   -   5        $ txtovertime��5D      $
��Left=�6'   $��28��6B   $��170,152,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��150��6�   6�   �� 5E   
   -   5        $ txtother��5E      $
��Left=�6$   $��28��6?   $��330,152,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��150��6�   6�   �� 5F   
   -	   5        $ txttotalovertime��5F      $
��Left=�6,   $��28��6G   $��495,152,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��150��6�   �� 5G   
   -
   5        $ txtnote��5G      $
��Left=�6#   $��28��6>   $��
10,215,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��310��6�   �� 5H   
   -   5        $ txttotal��5H      $
��Left=�6$   $��28��6?   $��330,215,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��150��6�   �� 5I   
   
���   �$��1q�5J      $
��Left=�5K      $	��Top=�5L       �� CornerRadius$ 0��5M      $��
170,90,0,0q�6*   ._�5N      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��145��6h   .+�5O      -   'System.Windows.Controls.AutoCompleteBox  -   5          Name$ 
sremployee��5O   +   
������ $��Center=�6}   $��28��6�   $	��110��6�   $��-1,0,0,0q�6�   $��Center=�6�      ValueMemberPath$ NamaA��6�      Text 6?   �� *NamaA+ �� Mode$ TwoWay=�   ItemTemplate 5P      �� 5Q      .R�5R      ��  �� Orientation$ 
Horizontal=�6)   .+�5S   "   �� ��6,   �� *NamaA+5T      5U      5W      �� 5X      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��0,0,0,0q�6�   5Y      5Z      �� 5[   
   
���   �$��1q�5\      $	��152��5]      $��28��5^      $
��Left=�5_      $	��Top=�5`      $ 0��5a      $��
330,90,0,0q�6*   ._�5b      �� -   5         ��Name$ txtemail��5b      $
��12.5(�6*   $
��Left=�6:   $��22��6U   $��0,4,0,0q�6a   $
��Wrap=�6r   $	��Top=�6�   $	��152��6�   5c      �� 5d   
   
���   �$��1q�5e      $
��Left=�5f      $	��Top=�5g      $ 0��5h      $��
495,90,0,0q�6*   ._�5i      �� -   5        $ txthp��5i      $
��12.5(�6'   $	��Top=�67   $
��Left=�6O   $��22��6j   $��0,4,0,0q�6v   $
��Wrap=�6�   $	��152��6�   5j      �� 5k   
   -   5        $��Right=�5k      $��
0,18,129,0q�6-   
������ $��0q�6Z   #��[  5l      $	��Top=�6/   $��60��6G   .��5m      �� $ 
Horizontal=�6   .+�5n      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5o      $
�� Add��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5p      5q      �� 5r   
   -   5        $��Right=�5r      $��	0,18,49,0q�6-   
������ $��0q�6Y   #��[  5s      $	��Top=�6/   $��70��6G   .��5t      �� $ 
Horizontal=�6   .+�5u      �� $,��&/Reyuko.App;component/Icons/close2.png��6   $��20��6H   �� 5v      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5w      5x      5y      5z      