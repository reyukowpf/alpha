   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5       
Reyuko.App4   .Reyuko.App.Views.StockOpname.InventoryChecking   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V	 RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 5      
�������$	��Top=�5        � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5       .��5"      � .+�5#   
   ' 	 !MaterialDesignThemes.Wpf.PopupBox     ToggleContent$	 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,3,8,0q�6l   $	��Top=�6~   $��40��6�   	   PopupContent.	 5$      �� .+�5%      �� -   5        $
��Left=�5%      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5&      $	��Top=�6P   $	��120��6h   .��5'      �� 
 �� Orientation$
 
Horizontal=�6!   .+�5(      �� $.��(/Reyuko.App;component/Icons/tutorial.png��6    $��23��6R   $��23��6^   �� 5)      $��Play Tutorial��6$   $
��12.5(�69   $
��Left=�6I   $��10,0,0,0q�6d   $��Center=�6v   5*      5+      5,      5-      �� 5.   
   $	��330��5/      $��49��50      $��	10,10,0,0q�51      $
��Left=�52      $	��Top=�53      $��Segoe)�54      $��36(�55      $��Normal$�56      $��Inventory Checking��57      $
��Wrap=�58      �� 5:   
   -   5        $��Right=�5:      $��
0,12,215,0q�6-   
������ $��0q�6Z   #��[  5;      $	��Top=�6.   $��60��6F   .��5<      �� $
 
Horizontal=�6   .+�5=      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5>      $
�� New��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5?      5@      �� 5B   
   -   5        $��Right=�5B      $��
0,12,145,0q�6-   
������ $��0q�6Z   #��[  5C      $	��Top=�6/   $��60��6G   .��5D      �� $
 
Horizontal=�6   .+�5E      �� $*��$/Reyuko.App;component/Icons/edit.png��6   $��20��6F   �� 5F      $�� Edit��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5G      5H      �� 5J   
   -   5        $��Right=�5J      $��	0,12,55,0q�6-   
������ $��0q�6Y   #��[  5K      $	��Top=�6/   $��85��6G   .��5L      �� $
 
Horizontal=�6   .+�5M      �� $-��'/Reyuko.App;component/Icons/refresh.png��6   $��20��6I   �� 5N      $�� Refresh��6   $
��12.5(�6,   $��Center=�6<   $��Center=�6Y   5O      5P      �� 5R   
   -   5         ��Name$ LstInventoryChecking��5S      $	��180��5T      $	��580��5U      $��	8,135,0,0q�5V      $
��Left=�5W      ��5X      �� 5Y      .R�5Z      �� $��44��5[      $��0,0,0,0q�5\      $
 
Horizontal=�5]      .+�5^      �� $��44��5_      $��26��5`      $��0,10,1,8q�5a      $��Center=�5b      $��Center=�5c      ��5d      �� *KodeInventory+�� 5f      $��2��5g      $	��121��5h      $��0,2,0,10q�5i      $
��Wrap=�5j      $��Center=�5k      $��Center=�5l      ��5m      �� *NamaInventory+5o      5p      5r      �� 5t   
   $��Reference Number��6   $
��Left=�6+   $
��12.5(�6F   $��
200,65,0,0q�6V   $	��Top=�6j   $��26��6�   �� 5u   
   $��Periode��6   $
��Left=�6"   $
��12.5(�6=   $��
363,65,0,0q�6M   $	��Top=�6a   $��26��6y   �� 5v   
   $��Value Range��6   $
��Left=�6&   $
��12.5(�6A   $��
610,65,0,0q�6Q   $	��Top=�6e   �� 5w   
   
���   �$��1q�5x      $
��Left=�5y      $	��Top=�5z       �� CornerRadius$ 0��5{      $��7,94,0,0q�6*   ._�5|      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��177��6h   .+�5}      -   'System.Windows.Controls.AutoCompleteBox  -   5          Name$ 
srlocation��5}   +   $
��12.5(�6?   $��Segoe)�6O   
������ $��Center=�6|   $��28��6�   $	��118��6�   $��
-1,-1,0,-1q�6�   $��Center=�6�      ValueMemberPath$ NamaTempatLokasi��6�      ItemTemplate 5~      �� 5      .R�5�      �� $
 
Horizontal=�6)   .+�5�   "   �� ��6,   �� *NamaTempatLokasi+5�      5�      5�      �� 5�      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��30,0,0,0q�6�   5�      5�      �� 5�   
   
���   �$��1q�5�      $
��Left=�5�      $	��Top=�5�      $ 0��5�      $��
200,94,0,0q�6*   ._�5�      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��150��6h   .+�5�        -   5        $ srdocumentnumber��5�   +   $
��12.5(�6E   $��Segoe)�6U   
������ $��Center=�6�   $��28��6�   $	��118��6�   $��
-1,-1,0,-1q�6�   $��Center=�6�   $ NoReferensiDokumen��6�    5�      �� 5�      .R�5�      �� $
 
Horizontal=�6)   .+�5�   "   �� ��6,   �� *NoReferensiDokumen+5�      5�      5�      �� 5�      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��0,0,0,0q�6�   5�      5�      (  "System.Windows.Controls.DatePicker  5�   
   $
��Left=�6   $��28��60   $
��12.5(�6<   $��
363,94,0,0q�6L   $	��Top=�6`   $	��110��6x     5�   
   $
��Left=�6   $��28��60   $
��12.5(�6<   $��
485,94,0,0q�6L   $	��Top=�6`   $	��110��6x   �� 5�   
   -   5         ��Name$ txtvalue��5�      $
��Left=�6$   $
��12.5(�6?   $��28��6O   $��
610,94,0,0q�6[    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��110��6�   6�   �� 5�   
   -	   5        $ txtRange��5�      $
��Left=�6$   $��28��6?   $
��12.5(�6K   $��
730,94,0,0q�6[   $
 Wrap=�6o   $	��Top=�6�   $	��110��6�   6�   &   System.Windows.Controls.DataGrid  5�   
   -
   5          Name$ DGInventoryChecking��5�      $
��Auto��5�      $	��400��5�      $��200,135,0,-28q�5�         AutoGenerateColumns .  $��0q�5�         CanUserResizeRows .     ColumnHeaderHeight$ 32Q�5�      $
��12.5(�5�         GridLinesVisibility$
 None=�5�         HeadersVisibility$ Column=�5�         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�5�         	RowHeight$ 30Q�5�         SelectionMode$ Single=�5�      ��5�      Z� ��5�      Z�   5�      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5�      8   "  6Q   .�5�      ��  � ��$ Center=�6C   �� 5�       � �� �	#FF5684C363   �� 5�       � ��
 �����63   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 5�         CanUserReorder .      CanUserResize  .  !   CanUserSort! . "   FontSize$
" 12.5Q�5�      #   Header$#   Date��5�      1	  +System.Windows.Controls.DataGridBoundColumn$ 	  Binding$ 5�      �� *TglChecking+%   HeaderStyle% 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      & 	  ElementStyle& 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 120 5�       .    .  ! . $
" 12.5Q�5�      $# 	Reference��5�      $ 5�      �� *	Reference+% 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      & 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 300 5�       .    .  ! . $
" 12.5Q�5�      $# Description��5�      $ 5�      �� *Description+% 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      & 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 120 5�       .    .  ! . $
" 12.5Q�5     $# Value��5     $ 5�      �� *Value+% 5     �� 5     # [B 6    "  6Y   .�5     ��  � ��$
 Left=�6K   �� 5      � �� �	#FF5684C36;   �� 5      � ��
 �����6;   5	     & 5     �� 5     # [B��6    " ��6N   .�5     ��  �@��TextAlignment$ Center=�6H   �� 5      � ��$ Center=�6B   5     5     5     5     5     