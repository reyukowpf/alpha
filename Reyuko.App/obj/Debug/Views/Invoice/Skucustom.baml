   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5       
Reyuko.App(   "Reyuko.App.Views.Invoice.Skucustom   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5        $	��600��5      $	��300��5	        � WindowStyle$
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
��Left=�5.      $	��Top=�5/      $��Segoe)�50      $��36(�51      $��Normal$�52      $��Custom��53      $
��Wrap=�54      �� 55   
   $��Discount��6   $
��Left=�6#   $��
10,140,0,0q�6>   $	��Top=�6R   �� 56   
   $��Name Custom��6   $
��Left=�6&   $��	10,60,0,0q�6A   $	��Top=�6T   �� 57   
   $��Price��6   $
��Left=�6    $��
330,60,0,0q�6;   $	��Top=�6O   �� 58   
   $��Total��6   $
��Left=�6    $��
170,60,0,0q�6;   $	��Top=�6O   �� 59   
   $��Total��6   $
��Left=�6    $��170,140,0,0q�6;   $	��Top=�6P   �� 5:   
   -   5         ��Name$ txttotal��5:      $
��Left=�6$   $��28��6?   $��
170,90,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��150��6�   6�   �� 5;   
   -   5        $ txtnama��5;      $
��Left=�6#   $��28��6>   $��	10,90,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $	��150��6�   �� 5<   
   -   5        $ txtharga��5<      $
��Left=�6$   $��28��6?   $��
330,90,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��150��6�   �� 5=      -   5         ��Name$ 	txtdiskon��5=      $y�Hidden=�6+   $
��12.5(�6?   $
��Left=�6O   $��22��6j   $��0,4,0,0q�6v   $
��Wrap=�6�   $	��Top=�6�   $	��152��6�   �� 5>      -   5        $ txttax��5>      $y�Hidden=�6(   $
��12.5(�6<   $
��Left=�6L   $��22��6g   $��0,4,0,0q�6s   $
��Wrap=�6�   $	��Top=�6�   $	��152��6�   �� 5?   
   -   5        $ 	txttotal1��5?      $
��Left=�6'   $��28��6B   $��170,165,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   $	��150��6�   �� 5@   
   -   5        $ 
txtdiskon1��5@      $
��Left=�6(   $��28��6C   $��
10,165,0,0q�6O   $
��Wrap=�6c   $	��Top=�6w   $	��150��6�   �� 5A   
   -	   5        $��Right=�5A      $��
0,18,100,0q�6-   
������ $��0q�6Z   #��[  5B      $	��Top=�6/   $��60��6G   .��5C      ��  �� Orientation$ 
Horizontal=�6   .+�5D      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5E      $
�� Add��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5F      5G      �� 5H   
   -
   5        $��Right=�5H      $��	0,18,20,0q�6-   
������ $��0q�6Y   #��[  5I      $	��Top=�6/   $��70��6G   .��5J      �� $ 
Horizontal=�6   .+�5K      �� $,��&/Reyuko.App;component/Icons/close2.png��6   $��20��6H   �� 5L      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5M      5N      5O      5P      