   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5       
Reyuko.App   Reyuko.App.Views.Pos.Load   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $	��400��5      $	��250��5	      $��14(�5
        � 
ResizeMode$  NoResize=�5       � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�5      $��Center=�5      $��Center=�63    � 	Resources 5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers	 P� Property
 P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5      	 �@J�IsMouseOver
 . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5       5!      5"      .��5$      � .+�5%   
   �� $	��112��5&      $��40��5'      $��10,5,0,0q�5(      $
��Left=�5)      $	��Top=�5*      $��Segoe)�5+      $��36(�5,      $��Normal$�5-      $
��Load��5.      $
��Wrap=�5/      �� 50   
   
���   �$��1q�51      $��Right=�52      $	��Top=�53       �� CornerRadius$ 0��54      $��
0,12,100,0q�6*   ._�55      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��150��6h   .+�56      -   'System.Windows.Controls.AutoCompleteBox  -   5          Name$ 
srcustomer��56   +   $
��12.5(�6?   
������ $��Center=�6i   $��28��6�   $	��120��6�   $��-1,0,0,0q�6�   $��Center=�6�      ValueMemberPath$ NamaGrupProduk��6�      ItemTemplate 57      �� 58      .R�59      ��  �� Orientation$ 
Horizontal=�6)   .+�5:   "   �� ��6,   �� *NamaGrupProduk+5;      5<      5>      �� 5?      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��0,0,0,0q�6�   5@      5A      &   System.Windows.Controls.DataGrid  5C   
   -   5          Name$ DGload��5D      $��0,55,0,0q�5E      $��0q�5H         ColumnHeaderHeight$ 32Q�5I      $
��12.5(�5J         HeadersVisibility$ Column=�5K         	RowHeight$ 30Q�5L         SelectionMode$ Single=�5M         AutoGenerateColumns .     CanUserAddRows .  ��5F      Z� ��5G      Z�  5Q      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5R      8   "  6Q   .�5S      ��  � ��$ Center=�6C   �� 5T       � �� �#cdcccc63   �� 5U       � ��
 �   �63   5V      5W         Columns 5X      0  *System.Windows.Controls.DataGridTextColumn  5Y      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 5Z         CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$
 12.5Q�5_         Header$ 	 Customer��5`         
IsReadOnly .  1  +System.Windows.Controls.DataGridBoundColumn    Binding  5[      �� *
Customer+!   HeaderStyle! 5b      �� 5c      # [B 6    "  6Y   .�5d      ��  � ��$ Center=�6K   �� 5e       � �� �#cdcccc6;   �� 5f       � ��
 �   �6;   5g      "   ElementStyle" 5i      �� 5j      # [B��6    " ��6N   .�5k      ��  �@��TextAlignment$ Center=�6H   �� 5l       � ��$ Center=�6B   5m      5o        5p      $	 120 5q       .   .   . $
 12.5Q�5v      $ Items��5w       .    5r      �� *Items+! 5y      �� 5z      # [B 6    "  6Y   .�5{      ��  � ��$ Center=�6K   �� 5|       � �� �#cdcccc6;   �� 5}       � ��
 �   �6;   5~      " 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $ * 5�       .   .   . $
 12.5Q�5�      $ Total��5�       .    5�      �� *Total+! 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �#cdcccc6;   �� 5�       � ��
 �   �6;   5�      " 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�      5�      �� 5�   
   -   5        $��Right=�5�      $��	0,12,20,0q�6-   
������ $��0q�6Y   #��[  5�      $	��Top=�6/   $��70��6G   .��5�      �� $ 
Horizontal=�6   .+�5�      �� $,��&/Reyuko.App;component/Icons/close2.png��6   $��20��6H   �� 5�      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5�      5�      5�      5�      