   M S B A M L   `   `   `  ����  
Reyuko.App5    /Reyuko.App.Views.CategoryProduk.CategoryProduks   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��Top=�5
      
�������  � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5       .��5"      � $��0,0,0,0q�6   .+�5#   
   �� $	��457��5$      $��54��5%      $��	20,20,0,0q�5&      $
��Left=�5'      $	��Top=�5(      $��Segoe)�5)      $��36(�5*      $��Normal$�5+      $ ��Category Product - Service��5,      $
��Wrap=�5-      �� 5/   
   -   5        $��Right=�5/      $��
0,20,120,0q�6-   
������ $��0q�6Z   #��[  50      $	��Top=�60   $��60��6H   .��51      ��  �� Orientation$ 
Horizontal=�6   .+�52      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 53      $
�� New��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   54      55      �� 56   
   -   5        $��Right=�56      $��	0,20,55,0q�6-   
������ $��0q�6Y   #��[  57      $	��Top=�60   $��60��6H   .��58      �� $ 
Horizontal=�6   .+�59      �� $*��$/Reyuko.App;component/Icons/edit.png��6   $��20��6F   �� 5:      $�� Edit��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5;      5<      &   System.Windows.Controls.DataGrid  5=   
   -   5        	  Name$	 DGCategoryProduk��5>      $
��Auto��5?      $	��400��5@      $��233,79,40,-22q�5A      
   AutoGenerateColumns
 .  $��0q�5E         CanUserResizeRows .     ColumnHeaderHeight$ 32Q�5G      $
��12.5(�5H         GridLinesVisibility$
 None=�5I         HeadersVisibility$ Column=�5J         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�5L         	RowHeight$ 30Q�5M         SelectionMode$ Single=�5N      ��5C      Z� ��5D      Z�   5O      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5P      8   "  6Q   .�5Q      ��  � ��$ Center=�6C   �� 5R       � �� �	#FF5684C363   �� 5S       � ��
 �����63   5T      5W         Columns 5X      0  *System.Windows.Controls.DataGridTextColumn  5Z      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 160 5[         CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$
 12.5Q�5`         Header$ Category ID��5a      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5\      �� *Id+   HeaderStyle 5b      �� 5c      # [B 6    "  6Y   .�5d      ��  � ��$ Center=�6K   �� 5e       � �� �	#FF5684C36;   �� 5f       � ��
 �����6;   5g         ElementStyle 5i      �� 5j      # [B��6    " ��6N   .�5k      ��  �@��TextAlignment$ Center=�6H   �� 5l       � ��$ Center=�6B   5m      5o        5p      $	 150 5q       .   .   . $
 12.5Q�5v      $ Category��5w       5r      �� *ProdukKategori+ 5x      �� 5y      # [B 6    "  6Y   .�5z      ��  � ��$ Center=�6K   �� 5{       � �� �	#FF5684C36;   �� 5|       � ��
 �����6;   5}       5      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 150 5�       .   .   . $
 12.5Q�5�      $ Parent Category��5�       5�      �� *ProdukKategoriParent+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $ * 5�       .   .   . $
 12.5Q�5�      $ Description��5�       5�      �� *	Deskripsi+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�      5�      R� 5�   
   -   5         R�Name$ TvCategoryProduk��5�      $
��Left=�6-   $	��569��6H   $��22,79,0,-148q�6U   $	��Top=�6k   $	��190��6�   5�      '  !MaterialDesignThemes.Wpf.PopupBox  5�   
      ToggleContent$	 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,10,8,0q�6l   $	��Top=�6   $��40��6�       PopupContent.  5�      �� .+�5�      �� -   5        $
��Left=�5�      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5�      $	��Top=�6P   $��90��6h   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� $,��&/Reyuko.App;component/Icons/delete.png��6    $��23��6P   $��23��6\   �� 5�      $��Delete��6$   $
��12.5(�62   $
��Left=�6B   $��10,0,0,0q�6]   $��Center=�6o   5�      5�      �� 5�      -   5        $
��Left=�5�      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5�      $	��Top=�6P   $	��120��6h   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� $.��(/Reyuko.App;component/Icons/tutorial.png��6    $��23��6R   $��23��6^   �� 5�      $��Play Tutorial��6$   $
��12.5(�69   $
��Left=�6I   $��10,0,0,0q�6d   $��Center=�6v   5�      5�      5�      5�      5�      5�      