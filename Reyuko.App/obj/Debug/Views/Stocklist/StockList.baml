   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5       
Reyuko.App*   $Reyuko.App.Views.Stocklist.StockList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      mControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $	��340��5      $	��550��5	      $��14(�5
        � WindowStyle$
  None=�5      
���   � � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�5      
�������$��Center=�5      $��Center=�61   $��1q�6N    � 
ResizeMode$ NoResize=�6b    � 	Resources 5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType	 �� Triggers
 P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5      	 5      P� 5      
 �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5       5"      5#      5$      .��5&      � .+�5'   
   �� -   5        $��Right=�5'      $��	0,19,24,0q�6-   
������ $��0q�6Y   #��[  5(      $	��Top=�6/   $��70��6G   .��5)      ��  �� Orientation$ 
Horizontal=�6   .+�5*      �� $+��%/Reyuko.App;component/Icons/close.png��6   $��20��6G   �� 5+      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5,      5-      �� 5.   
   -   5         ��Name$ 
cbLocation��5.      $
��12.5(�6'   $
��Left=�67   $��28��6R   $��	10,70,0,0q�6^   $	��Top=�6q   $	��170��6�   �� 5/   
   -   5        $ 
cbCategory��5/      $
��12.5(�6'   $
��Left=�67   $��28��6R   $��
200,70,0,0q�6^   $	��Top=�6r   $	��170��6�   �� 50   
   $	��151��51      $��55��52      $��	10,10,0,0q�53      $
��Left=�54      $	��Top=�55      $��Segoe)�56      $��36(�57      $��Normal$�58      $��
Stock List��59      $
��Wrap=�5:      �� 5;   
   
���   �$��1q�5<      $
��Left=�5=      $	��Top=�5>       �� CornerRadius$ 0��5?      $��
230,15,0,0q�6*   ._�5@      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��177��6h   .+�5A      -   'System.Windows.Controls.AutoCompleteBox  -   5          Name$ 
srcustomer��5A   +   $
��12.5(�6?   $��Segoe)�6O   
������ $��Center=�6|   $��28��6�   $	��148��6�   $��
-1,-1,0,-1q�6�   $��Center=�6�      ValueMemberPath$ 
NamaProduk��6�      ItemTemplate 5B      �� 5C      .R�5D      �� $ 
Horizontal=�6)   .+�5E   "   �� ��6,   �� *NamaPelanggan+5F      5G      5I      �� 5J      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $
��Left=�6j   $��Center=�6�   $��5,0,0,0q�6�   5K      5L      &   System.Windows.Controls.DataGrid  5M   
   -   5          Name$ DGStocklist��5N      $
��Auto��5O      $	��400��5P      $��10,117,10,0q�5Q         AutoGenerateColumns .  $��0q�5U         CanUserResizeRows .     ColumnHeaderHeight$ 32Q�5W      $
��12.5(�5X         GridLinesVisibility$
 None=�5Y         HeadersVisibility$ Column=�5Z         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�5\         	RowHeight$ 30Q�5]         SelectionMode$ Single=�5^      ��5S      Z� ��5T      Z�  5_      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5`      8   "  6Q   .�5a      ��  � ��$ Center=�6C   �� 5b       � �� �#d3d3d363   �� 5c       � ��
 �����63   5d      5g         Columns 5h      0  *System.Windows.Controls.DataGridTextColumn  5i      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 5j         CanUserReorder .      CanUserResize  .  !   CanUserSort! . "   FontSize$
" 12.5Q�5o      #   Header$# 
SKU / Name��5p      1  +System.Windows.Controls.DataGridBoundColumn$   Binding$ 5k      �� *SKU+%   HeaderStyle% 5q      �� 5r      # [B 6    "  6Y   .�5s      ��  � ��$
 Left=�6K   �� 5t       � �� �#d3d3d36;   �� 5u       � ��
 �����6;   5v      &   ElementStyle& 5x      �� 5y      # [B��6    " ��6N   .�5z      ��  �@��TextAlignment$ Center=�6H   �� 5{       � ��$ Center=�6B   5|      5~        5      $ 80 5�       .    .  ! . $
" 12.5Q�5�      $# Jumlah��5�      $ 5�      �� *Jumlah+% 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �#d3d3d36;   �� 5�       � ��
 �����6;   5�      & 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $ 80 5�       .    .  ! . $
" 12.5Q�5�      $# Satuan��5�      $ 5�      �� *Satuan+% 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �#d3d3d36;   �� 5�       � ��
 �����6;   5�      & 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $ 80 5�       .    .  ! . $
" 12.5Q�5�      $# Harga��5�      $ 5�      �� *Harga+% 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �#d3d3d36;   �� 5�       � ��
 �����6;   5�      & 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $ 80 5�       .    .  ! . $
" 12.5Q�5�      $# Discount��5�      $ 5�      �� *
Discount+% 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �#d3d3d36;   �� 5�       � ��
 �����6;   5�      & 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�      5�      5�      5�      