   M S B A M L   `   `   `  ����   
Reyuko.App<    6Reyuko.App.Views.DeprectiationTable.DeprectiationTable   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   U	 QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006 	 
�������.��� $��0,0,0,0q�.+��� $	��273��$��30��$��	30,20,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$��Deprectiation Table��$
��Wrap=�' 	 !MaterialDesignThemes.Wpf.PopupBox      ToggleContent$	  ...��$��32��$��20(�$��Right=�$��0,8,8,0q�$	��Top=�$��40��   PopupContent. �� .+��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$��90��.����  �� Orientation$ 
Horizontal=�.+��� $,��&/Reyuko.App;component/Icons/delete.png��$��23��$��23���� $��Delete��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��127��.���� $ 
Horizontal=�.+��� $.��(/Reyuko.App;component/Icons/tutorial.png��$��23��$��23���� $��Play Tutorial��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� -   $��Right=�$��
0,18,130,0q�
������ $��0q�#��[" �$	��Top=�$��60��.���� $ 
Horizontal=�.+��� $)��#/Reyuko.App;component/Icons/new.png��$��20���� $
�� New��$��14(�$��Center=�$��Center=��� -   $��Right=�$��	0,18,55,0q�
������ $��0q�#��[" �$	��Top=�$��60��.���� $ 
Horizontal=�.+��� $*��$/Reyuko.App;component/Icons/edit.png��$��20���� $�� Edit��$��14(�$��Center=�$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ DGDeprectiation��$
��Auto��$	��400��$��	23,67,0,0q�   AutoGenerateColumns .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$��14(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�	   
IsReadOnly	 . 
   RowDetailsVisibilityMode$
 Visible=�   	RowHeight$ 30Q�   SelectionMode$ Single=���Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�   Header$   Deprectiation��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *NamaPenyusutan+   HeaderStyle �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����   ElementStyle �� # [B��" ��.���  �@��TextAlignment$
 Left=���  � ��$	 Top=�  $ 70  .   .   . $ 14Q�$ 1st Year�� �� *Tahun1+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 70  .   .   . $ 14Q�$ 2nd Year�� �� *Tahun2+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 70  .   .   . $ 14Q�$ 3rd Year�� �� *Tahun3+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 70  .   .   . $ 14Q�$ 4th Year�� �� *Tahun4+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 70  .   .   . $ 14Q�$ 5th Year�� �� *Tahun5+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 70  .   .   . $ 14Q�$ 6th Year�� �� *Tahun6+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 70  .   .   . $ 14Q�$ 7th Year�� �� *Tahun7+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 70  .   .   . $ 14Q�$ 8th Year�� �� *Tahun8+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 70  .   .   . $ 14Q�$ 9th Year�� �� *Tahun9+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 90  .   .   . $ 14Q�$ 10th Year >�� �� *	Tahun10+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�