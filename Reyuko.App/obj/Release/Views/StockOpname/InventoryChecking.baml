   M S B A M L   `   `   `  ����   
Reyuko.App4    .Reyuko.App.Views.StockOpname.InventoryChecking   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  U	 QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 
�������.��� .+�' 	 !MaterialDesignThemes.Wpf.PopupBox      ToggleContent$	  ...��$��32��$��20(�$��Right=�$��0,1,8,0q�$	��Top=�$��40��   PopupContent. �� .+��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��120��.����  �� Orientation$ 
Horizontal=�.+��� $.��(/Reyuko.App;component/Icons/tutorial.png��$��23��$��23���� $��Play Tutorial��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� $	��178��$��30��$��	10,10,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$��Inventory Checking��$
��Wrap=��� -   $��Right=�$��
0,12,215,0q�
������ $��0q�#��[" �$	��Top=�$��60��.���� $ 
Horizontal=�.+��� $)��#/Reyuko.App;component/Icons/new.png��$��20���� $
�� New��$��14(�$��Center=�$��Center=��� -   $��Right=�$��
0,12,145,0q�
������ $��0q�#��[" �$	��Top=�$��60��.���� $ 
Horizontal=�.+��� $*��$/Reyuko.App;component/Icons/edit.png��$��20���� $�� Edit��$��14(�$��Center=�$��Center=��� -   $��Right=�$��	0,12,55,0q�
������ $��0q�#��[" �$	��Top=�$��85��.���� $ 
Horizontal=�.+��� $-��'/Reyuko.App;component/Icons/refresh.png��$��20���� $�� Refresh��$��14(�$��Center=�$��Center=��� -    ��Name$ LstInventoryChecking��$	��180��$
��Auto��$��	8,100,0,0q�$
��Left=����� .R��� $��44��$��0,0,0,0q�$ 
Horizontal=�.+��� $��44��$��26��$��0,10,1,8q�$��Center=�$��Center=����� *KodeInventory+�� $��2��$	��121��$��0,2,0,10q�$
��Wrap=�$��Center=�$��Center=����� *NamaInventory+�� $��Search��$
��Left=�$��
200,70,0,0q�$	��Top=�$��26���� $��Periode��$
��Left=�$��
363,70,0,0q�$	��Top=�$��26���� $��Value Range��$
��Left=�$��
610,70,0,0q�$	��Top=�*  $DevExpress.Xpf.Editors.SearchControl  $
��Left=�$��28��$��	10,64,0,0q�$	��Top=� J� RenderTransformOrigin$ -0.212,1&�$	��178��  -     Name$ Search��$
��Left=�$��28��$��
200,94,0,0q�$	��Top=�$ 0.212,1&�$	��152��(  "System.Windows.Controls.DatePicker  $
��Left=�$��28��$��
363,94,0,0q�$	��Top=�$	��110��  $
��Left=�$��28��$��
485,94,0,0q�$	��Top=�$	��110���� -    ��Name$ txtvalue��$
��Left=�$��28��$��
610,94,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��110���� -   $ txtRange��$
��Left=�$��28��$��
730,94,0,0q�$
 Wrap=�$	��Top=�$	��110��&   System.Windows.Controls.DataGrid  -	     Name$ DGInventoryChecking��$
��Auto��$	��400��$��200,135,0,0q�	   AutoGenerateColumns	 .  $��0q�
   CanUserResizeRows
 .     ColumnHeaderHeight$ 32Q�$��14(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�   	RowHeight$ 30Q�   SelectionMode$ Single=���Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�   Header$   Date��1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding �� *TglChecking+   HeaderStyle �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����  	  ElementStyle  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $ 14Q�$ 	Reference�� �� *	Reference+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 300  .   .   . $ 14Q�$ Description�� �� *Description+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $ 14Q�$ Value�� �� *Value+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�