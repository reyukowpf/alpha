   M S B A M L   `   `   `  ����   
Reyuko.App&     Reyuko.App.Views.Sales.StockList   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   $	��340��$	��550��$��14(�  � 
ResizeMode$  NoResize=� � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�
�������.��� .+��� -   $��Right=�$��	0,15,20,0q�
������ $��0q�#��[" �$	��Top=�$��70��.����  �� Orientation$ 
Horizontal=�.+��� $+��%/Reyuko.App;component/Icons/close.png��$��20���� $�� Cancel��$��14(�$��Center=�$��Center=��� -    ��Name$ 
cbLocation��$
��Left=�$��28��$��	50,70,0,0q�$	��Top=�$	��170���� -   $ 
cbCategory��$
��Left=�$��28��$��
240,70,0,0q�$	��Top=�$	��170���� $	��151��$��30��$��	50,10,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$��
Stock List��$
��Wrap=�*  $DevExpress.Xpf.Editors.SearchControl  $
��Left=�$��
290,15,0,0q�$	��Top=�$	��160��&   System.Windows.Controls.DataGrid  -     Name$ DGStocklist��$
��Auto��$	��400��$��
50,117,0,0q�   AutoGenerateColumns .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$��14(�	   GridLinesVisibility$
	 None=�
   HeadersVisibility$
 Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�   	RowHeight$ 30Q�   SelectionMode$ Single=���Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%n   '        7 �� 8   "  .���  � ��$ Center=���  � �� �#d3d3d3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�   Header$ 
SKU / Name��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *SKU+   HeaderStyle �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����   ElementStyle �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 80  .   .   . $ 14Q�$ Jumlah�� �� *Jumlah+ �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 80  .   .   . $ 14Q�$ Satuan�� �� *Satuan+ �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 80  .   .   . $ 14Q�$ Harga�� �� *Harga+ �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 80  .   .   . $ 14Q�$ Discount�� �� *
Discount+ �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�