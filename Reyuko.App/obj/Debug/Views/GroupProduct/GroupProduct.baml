   M S B A M L   `   `   `  ����  
Reyuko.App0    *Reyuko.App.Views.GroupProduct.GroupProduct   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��600��5      $	��500��5	        � WindowStartupLocation$  CenterScreen=�5
       � WindowStyle$
 None=�5      $��14(�5      
������� � 	Resources 5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property	 P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver	 . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5       5!      5"      .��5$      � .+�5&   
   �� $	��267��5'      $��45��5(      $��	20,10,0,0q�5)      $
��Left=�5*      $	��Top=�5+      $��Segoe)�5,      $��36(�5-      $��Normal$�5.      $��Group Product��5/      $
��Wrap=�50      '  !MaterialDesignThemes.Wpf.PopupBox  51   
   
   ToggleContent$	
 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,8,10,0q�6l   $	��Top=�6   $��40��6�      PopupContent. 52      �� .+�53      �� $
��Left=�6   $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �54      $	��Top=�6P   $	��120��6h   .��55      ��  �� Orientation$ 
Horizontal=�6!   .+�56      �� $.��(/Reyuko.App;component/Icons/tutorial.png��6    $��20��6R   $��23��6^   �� 57      $��Play Tutorial��6$   $
��12.5(�69   $
��Left=�6I   $��10,0,0,0q�6d   $��Center=�6v   58      59      5:      5;      �� 5=   
   -   5         ��Name$ BtnSave��5=      $��Right=�6"   $
��12.5(�6>   $��
0,20,130,0q�6N   
������ $��0q�6{   #��[  5>      $	��Top=�6/   $��65��6G   .��5?      �� $ 
Horizontal=�6   .+�5@      �� $*��$/Reyuko.App;component/Icons/save.png��6   $��20��6F   �� 5A      $�� Save��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5B      5C      �� 5E   
   -   5        $ 	BtnCancel��5E      $��Right=�6$   $��	0,20,55,0q�6@   
������ $��0q�6l   #��[  5F      $	��Top=�6.   $��70��6F   .��5G      �� $ 
Horizontal=�6   .+�5H      �� $+��%/Reyuko.App;component/Icons/close.png��6   $��20��6G   �� 5I      $�� Close��6   $
��12.5(�6*   $��Center=�6:   $��Center=�6W   5J      5K      �� 5M   
   $��
Group Name��6   $
��12.5(�6%   $
��Left=�65   $��	20,70,0,0q�6P   $	��Top=�6c   �� 5N   
   $	��SKU��6   $
��Left=�6   $
��12.5(�69   $��
20,120,0,0q�6I   $	��Top=�6]   �� 5O   
   $��Category��6   $
��Left=�6#   $
��12.5(�6>   $��
20,170,0,0q�6N   $	��Top=�6b   �� 5P   
   $��Description��6   $
��Left=�6&   $
��12.5(�6A   $��
20,220,0,0q�6Q   $	��Top=�6e   �� 5Q   
   $��Discount��6   $
��Left=�6#   $
��12.5(�6>   $��
20,350,0,0q�6N   $	��Top=�6b   �� 5R   
   $��Periode��6   $
��Left=�6"   $
��12.5(�6=   $��
20,400,0,0q�6M   $	��Top=�6a   �� 5S   
   $��Upload Image��6   $
��Left=�6'   $
��12.5(�6B   $��
20,440,0,0q�6R   $	��Top=�6f   �� 5T   
   -   5         ��Name$ txtGroupName��5T      $
��Left=�6(   $��28��6C   $
��12.5(�6O   $��
170,70,0,0q�6_    �� TextWrapping$
 Wrap=�6s   $	��Top=�6�   $	��200��6�   6�   �� 5U   
   -   5        $ txtSKU��5U      $
��Left=�6"   $��28��6=   $
��12.5(�6I   $��170,120,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��200��6�   6�   �� 5V   
   -   5         ��Name$ 
cbCategory��5V      $
��Left=�6'   $��28��6B   $
��12.5(�6N   $��170,170,0,0q�6^   $	��Top=�6s   $	��200��6�   6�   �� 5W   
   -   5        $ txtDescription��5W      $
��Left=�6*   $��70��6E   $
��12.5(�6Q   $��170,220,0,0q�6a   $
 Wrap=�6v   $	��Top=�6�   $	��200��6�   �� 5X   
   -   5         ��Name$ chkDiscount��5X      $��Discount��6(   $
��12.5(�6;   $
��Left=�6L   $��
20,310,0,0q�6g   $	��Top=�6{   �� 5Y   
   -   5        $ txtDiscount��5Y      $
��12.5(�6e   $
��Left=�6u   $��28��6�   $��170,350,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   {�6'   ��  �� ElementName$ chkDiscount�� �� Path$ 	IsChecked�6�   (  "System.Windows.Controls.DatePicker  5Z   
   -	   5          Name$ dtTanggalMulaiDiskon��5Z      $
��Left=�63   $
��12.5(�6N   $��170,400,0,0q�6^   $	��Top=�6s   $	��100��6�     5[   
   -
   5        $ dtTanggalAkhirDiskon��5[      $
��Left=�63   $
��12.5(�6N   $��280,400,0,0q�6^   $	��Top=�6s   $	��100��6�   �� 5\   
   $
��Left=�6   $��
20,465,0,0q�6,   
������ $��0q�6Y   #��[" �5]      $	��Top=�6T   $��35��6l   $��45��6x   .��5^      �� $ 
Horizontal=�6   .+�5_      �� $1��+/Reyuko.App;component/Icons/chooseFile1.png��6   $��40��6M   $��40��6Y   5`      5a      �� 5b   
   $
��Left=�6   $��
70,465,0,0q�6,   
������ $��0q�6Y   #��[" �5c      $	��Top=�6T   $��35��6l   $��45��6x   .��5d      �� $ 
Horizontal=�6   .+�5e      �� $1��+/Reyuko.App;component/Icons/chooseFile1.png��6   $��40��6M   $��40��6Y   5f      5g      �� 5h   
   $
��Left=�6   $��120,465,0,0q�6,   
������ $��0q�6Z   #��[" �5i      $	��Top=�6T   $��35��6l   $��45��6x   .��5j      �� $ 
Horizontal=�6   .+�5k      �� $1��+/Reyuko.App;component/Icons/chooseFile1.png��6   $��40��6M   $��40��6Y   5l      5m      �� 5n   
   $
��Left=�6   $��170,465,0,0q�6,   
������ $��0q�6Z   #��[" �5o      $	��Top=�6T   $��35��6l   $��45��6x   .��5p      �� $ 
Horizontal=�6   .+�5q      �� $1��+/Reyuko.App;component/Icons/chooseFile1.png��6   $��40��6M   $��40��6Y   5r      5s      5t      5v      