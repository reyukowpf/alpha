   M S B A M L   `   `   `  ����  
Reyuko.App1    +Reyuko.App.Views.SalaryGroup.NewSalaryGroup   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $	��266��5      $	��415��5      $��14(�5	        � 
ResizeMode$  NoResize=�5
       � WindowStyle$
 None=�5      $��1q�5       � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�5      
�������$��Center=�5      $��Center=�61    � 	Resources 5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType	 �� Triggers
 P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5      	 5      P� 5      
 �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5       5"      5#      5$      .��5&      � $��8,0,8,8q�6   .+�5'   
   �� -   5        $��Right=�5'      $��
0,12,130,0q�6-   
������ $��0q�6Z   #��[  5(      $	��Top=�60   $��60��6H   .��5)      ��  �� Orientation$ 
Horizontal=�6   .+�5*      �� $*��$/Reyuko.App;component/Icons/save.png��6   $��20��6F   �� 5+      $�� Save��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5,      5-      �� 5/   
   -   5        $��Right=�5/      $��	0,12,50,0q�6-   
������ $��0q�6Y   #��[  50      $	��Top=�60   $��70��6H   .��51      �� $ 
Horizontal=�6   .+�52      �� $+��%/Reyuko.App;component/Icons/close.png��6   $��20��6G   �� 53      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   54      55      �� 56   
   $��Posisi Group Name��6   $
��Left=�6,   $
��12.5(�6G   $��	20,50,0,0q�6W   $	��Top=�6j   �� 57   
   $��Basic Salary��6   $
��Left=�6'   $
��12.5(�6B   $��	19,90,0,0q�6R   $	��Top=�6e   �� 58   
   $��	Allowance��6   $
��Left=�6$   $
��12.5(�6?   $��
19,130,0,0q�6O   $	��Top=�6c   �� 59   
   $��Overtime / Hour��6   $
��Left=�6*   $
��12.5(�6E   $��
19,170,0,0q�6U   $	��Top=�6i   �� 5:   
   $	��Tax��6   $
��Left=�6   $
��12.5(�69   $��
19,210,0,0q�6I   $	��Top=�6]   �� 5;   
   $��:��6   $
��Left=�6   $��
150,50,0,0q�67   $	��Top=�6K   �� 5<   
   $��:��6   $
��Left=�6   $��
150,90,0,0q�67   $	��Top=�6K   �� 5=   
   $��:��6   $
��Left=�6   $��150,130,0,0q�67   $	��Top=�6L   �� 5>   
   $��:��6   $
��Left=�6   $��150,170,0,0q�67   $	��Top=�6L   �� 5?   
   $��:��6   $
��Left=�6   $��150,210,0,0q�67   $	��Top=�6L   �� 5@   
   -   5         ��Name$ txtPositionGroupName��5@      $
��Left=�60   $
��12.5(�6K   $��28��6[   $��
160,50,0,0q�6g    �� TextWrapping$
 Wrap=�6{   $	��Top=�6�   $	��207��6�   6�   �� 5A   
   -   5        $ txtBasicSalary��5A      $
��Left=�6*   $��28��6E   $
��12.5(�6Q   $��
160,90,0,0q�6a   $
 Wrap=�6u   $	��Top=�6�   $	��207��6�   6�   �� 5B   
   -   5        $ txtAllowance��5B      $
��Left=�6(   $��28��6C   $
��12.5(�6O   $��160,130,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��207��6�   6�   �� 5C   
   -   5        $ txtOvertime��5C      $
��Left=�6'   $��28��6B   $
��12.5(�6N   $��160,170,0,0q�6^   $
 Wrap=�6s   $	��Top=�6�   $	��207��6�   6�   �� 5D   
   -   5         ��Name$ chkTax��5D      $��Include / Exclude Tax��6#   $
��12.5(�6C   $
��Left=�6S   $��160,218,0,0q�6n   $	��Top=�6�   5F      5H      