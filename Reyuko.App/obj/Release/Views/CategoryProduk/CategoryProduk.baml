   M S B A M L   `   `   `  ����   
Reyuko.App4    .Reyuko.App.Views.CategoryProduk.CategoryProduk   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   U	 QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 
�������.��� $��0,0,0,0q�.+��� $	��273��$��30��$��	20,20,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$ ��Category Product - Service��$
��Wrap=��� -   $��Right=�$��
0,20,120,0q�
������ $��0q�#��[" �$	��Top=�$��60��.����   �� Orientation$  
Horizontal=�.+��� $)��#/Reyuko.App;component/Icons/new.png��$��20���� $
�� New��$��14(�$��Center=�$��Center=��� -   $��Right=�$��	0,20,55,0q�
������ $��0q�#��[" �$	��Top=�$��60��.���� $  
Horizontal=�.+��� $*��$/Reyuko.App;component/Icons/edit.png��$��20���� $�� Edit��$��14(�$��Center=�$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ DGCategoryProduk��$
��Auto��$	��400��$��
233,57,0,0q�   AutoGenerateColumns .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$��14(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�	   	RowHeight$	 30Q�
   SelectionMode$
 Single=���Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 160    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�   Header$ Category ID��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+   HeaderStyle �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   ElementStyle �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 150  .   .   . $ 14Q�$ Category�� �� *ProdukKategori+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 150  .   .   . $ 14Q�$ Parent Category�� �� *ProdukKategoriParent+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ *  .   .   . $ 14Q�$ Description�� �� *	Deskripsi+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�R� -    R�Name$ TvCategoryProduk��$
��Left=�$	��569��$��	22,57,0,0q�$	��Top=�$	��190��' 	 !MaterialDesignThemes.Wpf.PopupBox     ToggleContent$	 ...��$��32��$��20(�$��Right=�$��0,8,8,0q�$	��Top=�$��40��   PopupContent. �� .+��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$��90��.���� $  
Horizontal=�.+��� $,��&/Reyuko.App;component/Icons/delete.png��$��23��$��23���� $��Delete��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��120��.���� $  
Horizontal=�.+��� $.��(/Reyuko.App;component/Icons/tutorial.png��$��23��$��23���� $��Play Tutorial��$��14(�$
��Left=�$��10,0,0,0q�$��Center=�