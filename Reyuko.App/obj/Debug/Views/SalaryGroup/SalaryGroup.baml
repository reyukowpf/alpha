   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5       
Reyuko.App.   (Reyuko.App.Views.SalaryGroup.SalaryGroup   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V	 RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 5      $��14(�5      
�������$
��Left=�5      $	��Top=�61   $
��1040��6I   $	��668��6V     � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5       5!      .��5$      � $��	0,0,10,10q�6   .+�5%   
   �� -   5         ��Name$ LISalaryGroup��5&      $	��280��5'      $��	10,97,0,0q�5(      $
��Left=�5)      ��5,      �� 5-      .R�5.      � .+�5/      �� $��46��50      $��0,0,0,0q�51      	 �� Orientation$	 
Horizontal=�52      .+�53      �� .+�54   "   �� $.��(/Reyuko.App;component/Icons/Blueball.png��6(   $��44��6Z   6h   �� 56   "   
 ��Name$
 ticon��6,   
������ $��18(�6T   $
��Bold"�6b   
�������$��CharacterEllipsis=�6�   $��	13,10,0,0q�6�   $��17��6�   ��6�   �� *NamaGolongan+6�   57      5<      �� 5=      $	��165��5>      $��26��5?      $��	50,10,1,8q�5@      $��Center=�5A      $��Center=�5B      ��5C      �� *NamaGolongan+5D      5H      5K      �� 5L   
   -   5        $
 tSalary��5L      $	��231��5M      $��49��5N      $��	10,10,0,0q�5O      $
��Left=�5P      $	��Top=�5Q      $��Segoe)�5R      $��36(�5S      $��Normal$�5T      $��Salary Group��5U      $
��Wrap=�5V      ' 	 !MaterialDesignThemes.Wpf.PopupBox  5X   
      ToggleContent$	 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,3,8,0q�6l   $	��Top=�6~   $��40��6�      PopupContent. 5Y      �� .+�5Z      �� -   5        $
��Left=�5Z      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5[      $	��Top=�6P   $��90��6h   .��5\      �� $	 
Horizontal=�6!   .+�5]      �� $,��&/Reyuko.App;component/Icons/delete.png��6    $��23��6P   $��23��6\   �� 5^      $��Delete��6$   $
��12.5(�62   $
��Left=�6B   $��10,0,0,0q�6]   $��Center=�6o   5_      5`      �� 5a      -   5        $
��Left=�5a      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5b      $	��Top=�6P   $	��120��6h   .��5c      �� $	 
Horizontal=�6!   .+�5d      �� $.��(/Reyuko.App;component/Icons/tutorial.png��6    $��23��6R   $��23��6^   �� 5e      $��Play Tutorial��6$   $
��12.5(�69   $
��Left=�6I   $��10,0,0,0q�6d   $��Center=�6v   5f      5g      5h      5i      �� 5j   
   -   5        $��Right=�5j      $��
0,12,120,0q�6-   
������ $��0q�6Z   #��[  5k      $	��Top=�60   $��60��6H   .��5l      �� $	 
Horizontal=�6   .+�5m      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5n      $
�� New��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5o      5p      �� 5q   
   -   5        $��Right=�5q      $��	0,12,55,0q�6-   
������ $��0q�6Y   #��[  5r      $	��Top=�60   $��60��6H   .��5s      �� $	 
Horizontal=�6   .+�5t      �� $*��$/Reyuko.App;component/Icons/edit.png��6   $��20��6F   �� 5u      $�� Edit��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5v      5w      �� 5x   
   $��Position Group Name��6   $
��12.5(�6.   $
��Left=�6>   $��
333,97,0,0q�6Y   $	��Top=�6m   �� 5y   
   $��Basic Salary��6   $
��Left=�6'   $
��12.5(�6B   $��333,137,0,0q�6R   $	��Top=�6g   �� 5z   
   $��	Allowance��6   $
��Left=�6$   $
��12.5(�6?   $��333,177,0,0q�6O   $	��Top=�6d   �� 5{   
   $��Overtime / Hour��6   $
��Left=�6*   $
��12.5(�6E   $��333,217,0,0q�6U   $	��Top=�6j   �� 5|   
   $	��Tax��6   $
��Left=�6   $
��12.5(�69   $��333,257,0,0q�6I   $	��Top=�6^   �� 5}   
   $��:��6   $
��Left=�6   $��
480,97,0,0q�67   $	��Top=�6K   �� 5~   
   $��:��6   $
��Left=�6   $��480,137,0,0q�67   $	��Top=�6L   �� 5   
   $��:��6   $
��Left=�6   $��480,177,0,0q�67   $	��Top=�6L   �� 5�   
   $��:��6   $
��Left=�6   $��480,217,0,0q�67   $	��Top=�6L   �� 5�   
   $��:��6   $
��Left=�6   $��480,257,0,0q�67   $	��Top=�6L   �� 5�   
   -   5        $
 txtPositionGroupName��5�      $
��12.5(�62   $
��Left=�6B   $��28��6]   $��490,100,0,0q�6i   $
��Wrap=�6~   $	��Top=�6�   $	��150��6�   �� 5�   
   -   5        $
 txtBasicSalary��5�      $
��12.5(�6,   $
��Left=�6<   $��28��6W   $��490,140,0,0q�6c   $
��Wrap=�6x   $	��Top=�6�   $	��150��6�   �� 5�   
   -	   5        $
 txtAllowance��5�      $
��12.5(�6*   $
��Left=�6:   $��28��6U   $��490,180,0,0q�6a   $
��Wrap=�6v   $	��Top=�6�   $	��150��6�   �� 5�   
   -
   5        $
 txtOvertime��5�      $
��Left=�6)   $
��12.5(�6D   $��28��6T   $��490,220,0,0q�6`   $
��Wrap=�6u   $	��Top=�6�   $	��150��6�   �� 5�   
   -   5        $
 txtTax��5�      $
��Left=�6$   $��28��6?   $
��12.5(�6K   $��490,260,0,0q�6[   $
��Wrap=�6p   $	��Top=�6�   $	��150��6�   �� 5�   
   
���   �$��1q�5�      $
��Left=�5�      $	��Top=�5�       �� CornerRadius$ 0��5�      $��	10,64,0,0q�6*   ._�5�      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��279��6h   .+�5�      -   'System.Windows.Controls.AutoCompleteBox  -   5          Name$ 
srcustomer��5�   +   $
��12.5(�6?   $��Segoe)�6O   
������ $��Center=�6|   $��28��6�   $	��250��6�   $��
-1,-1,0,-1q�6�   $��Center=�6�      ValueMemberPath$ 
NamaProduk��6�      ItemTemplate 5�      �� 5�      .R�5�      �� $	 
Horizontal=�6)   .+�5�   "   �� ��6,   �� *NamaPelanggan+5�      5�      5�      �� 5�      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $
��Left=�6j   $��Center=�6�   $��5,0,0,0q�6�   5�      5�      5�      5�      