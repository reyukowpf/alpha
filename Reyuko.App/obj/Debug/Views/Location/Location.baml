   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5       
Reyuko.App(   "Reyuko.App.Views.Location.Location   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V	 RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 5      $	��Top=�5      
�������  � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5       5!      .��5#      � -   5         �Name$ grid1��5#      .+�5$   
   ' 	 !MaterialDesignThemes.Wpf.PopupBox  	   ToggleContent$		 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,10,8,0q�6l   $	��Top=�6   $��40��6�   5%      �� 5&   
   $	��178��5'      $��39��5(      $��	10,20,0,0q�5)      $
��Left=�5*      $	��Top=�5+      $��Segoe)�5,      $��36(�5-      $��Normal$�5.      $��Location��5/      $
��Wrap=�50      �� 52   
   -   5        $��Right=�52      $��
0,20,200,0q�6-   
������ $��0q�6Z   #��[  53      $	��Top=�6/   $��60��6G   .��54      �� 
 �� Orientation$
 
Horizontal=�6   .+�55      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 56      $
�� New��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   57      58      �� 5:   
   -   5        $��Right=�5:      $��
0,20,130,0q�6-   
������ $��0q�6Z   #��[  5;      $	��Top=�6/   $��60��6G   .��5<      �� $
 
Horizontal=�6   .+�5=      �� $*��$/Reyuko.App;component/Icons/edit.png��6   $��20��6F   �� 5>      $�� Edit��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5?      5@      �� 5B   
   -   5        $��Right=�5B      $��	0,20,55,0q�6-   
������ $��0q�6Y   #��[  5C      $	��Top=�6/   $��60��6G   .��5D      �� $
 
Horizontal=�6   .+�5E      �� $+��%/Reyuko.App;component/Icons/print.png��6   $��20��6G   �� 5F      $�� Print��6   $
��12.5(�6*   $��Center=�6:   $��Center=�6W   5G      5H      � 5I   
   $��8,125,612,10q�6    � ColumnDefinitions 5J      �� 5K      $
��Auto �6#   �� 5L      $��* �6#   .+�5N      �� -   5         ��Name$ 
LiLocation��5O      $	��180��5P      $��0,0,0,0q�5Q      $	��Top=�5R      $
��Left=�5S      ��5T      �� 5U      .R�5V      �� $��41��5W      $��0,0,0,0q�5X      $
 
Horizontal=�5Y      .+�5Z      �� $	��165��5[   !   $��26��5\   !   $��0,10,1,8q�5]   !   $��Center=�5^   !   $��Center=�5_   !   ��5`   !   �� *NamaTempatLokasi+5b      5c      5e      5g      �� 5i   
   $��Search��6   $
��Left=�6!   $
��12.5(�6<   $��
200,60,0,0q�6L   $	��Top=�6`   $��26��6x   �� 5j   
   $��Category��6   $
��Left=�6#   $
��12.5(�6>   $��
363,60,0,0q�6N   $	��Top=�6b   �� 5k   
   
���   �$��1q�5l      $
��Left=�5m      $	��Top=�5n       �� CornerRadius$ 0��5o      $��7,84,0,0q�6*   ._�5p      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��177��6h   .+�5q      -   'System.Windows.Controls.AutoCompleteBox  -   5          Name$ 
srsidelist��5q   +   $
��12.5(�6?   $��Segoe)�6O   
������ $��Center=�6|   $��28��6�   $	��118��6�   $��
-1,-1,0,-1q�6�   $��Center=�6�      ValueMemberPath$ NamaTempatLokasi��6�      ItemTemplate 5r      �� 5s      .R�5t      �� $
 
Horizontal=�6)   .+�5u   "   �� ��6,   �� *NamaTempatLokasi+5v      5w      5y      �� 5z      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��30,0,0,0q�6�   5{      5|      �� 5}   
   
���   �$��1q�5~      $
��Left=�5      $	��Top=�5�      $ 0��5�      $��
202,84,0,0q�6*   ._�5�      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��140��6h   .+�5�        -   5        $ srtable��5�   +   $
��12.5(�6<   $��Segoe)�6L   
������ $��Center=�6y   $��28��6�   $	��118��6�   $��
-1,-1,0,-1q�6�   $��Center=�6�   $ 
NamaProduk��6�    5�      �� 5�      .R�5�      �� $
 
Horizontal=�6)   .+�5�   "   �� ��6,   �� *
NamaProduk+5�      5�      5�      �� 5�      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��0,0,0,0q�6�   5�      5�      �� 5�   
   -   5         ��Name$ 
cbkategori��5�      $
��Left=�6'   $
��12.5(�6B   $��
363,84,0,0q�6R   $��28��6f   $	��Top=�6r   $	��152��6�   6�   &   System.Windows.Controls.DataGrid  5�   
   -	   5          Name$ 
DGLocation��5�      $
��Auto��5�      $	��400��5�      $��200,125,0,10q�5�         AutoGenerateColumns .  $��0q�5�         CanUserResizeRows .     ColumnHeaderHeight$ 32Q�5�      $
��12.5(�5�         GridLinesVisibility$
 None=�5�         HeadersVisibility$ Column=�5�         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�5�         	RowHeight$ 30Q�5�         SelectionMode$ Single=�5�      ��5�      Z� ��5�      Z�   5�      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5�      8   "  6Q   .�5�      ��  � ��$ Center=�6C   �� 5�       � �� �	#FF5684C363   �� 5�       � ��
 �����63   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 5�         CanUserReorder .      CanUserResize  .  !   CanUserSort! . "   FontSize$
" 12.5Q�5�      #   Header$#   SKU / Name��5�      1  +System.Windows.Controls.DataGridBoundColumn$   Binding$ 5�      �� *Sku+%   HeaderStyle% 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      &   ElementStyle& 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 120 5�       .    .  ! . $
" 12.5Q�5�      $# Category��5�      $ 5�      �� *
Category+% 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      & 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 100 5�       .    .  ! . $
" 12.5Q�5�      $# Satuan��5�      $ 5�      �� *SatuanDasar+% 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      & 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 120 5�       .    .  ! . $
" 12.5Q�5�      $# 	Inventory��5�      $ 5�      �� *IdOrderInventori+% 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      & 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5      5     5     5     5     