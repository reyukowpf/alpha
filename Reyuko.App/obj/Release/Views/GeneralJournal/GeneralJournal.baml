   M S B A M L   `   `   `  ����   
Reyuko.App4    .Reyuko.App.Views.GeneralJournal.GeneralJournal   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   
�������.��� $��0,0,0,0q�.+��� $	��273��$��30��$��	20,20,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$��General Journal��$
��Wrap=��� -     ��Name$  other��$��33��$��	0,20,10,0q�$��Right=�$	��Top=�
������ $��0q�$	��...��$
��Bold"�#��[" ��� -   $��38��$��
0,20,241,0q�$��Right=�$	��Top=�
������ $��0q�$	��New��#��[" ��� -   $��70��$��
0,20,163,0q�$��Right=�$	��Top=�
������ $��0q�$��Detail��#��[" ��� -   $��60��$��
0,20,101,0q�$��Right=�$	��Top=�
������ $��0q�$��Refresh��#��[" ��� -   $��60��$��	0,20,51,0q�$��Right=�$	��Top=�
������ $��0q�$��Delete��#��[" �&   System.Windows.Controls.DataGrid  -     Name$ 	DGGeneral��$
��Auto��$	��400��$��
20,130,0,0q�   AutoGenerateColumns .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$��14(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�	   	RowHeight$	 30Q�
   SelectionMode$
 Single=���Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 160    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�   Header$
 Date��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	TglJurnal+   HeaderStyle �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����   ElementStyle �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 160  .   .   . $ 14Q�$ General Journal No�� �� *
NoJurnal+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 300  .   .   . $ 14Q�$
 Note�� �� *Note+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 160  .   .   . $ 14Q�$ Currency�� �� *
Currency+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 160  .   .   . $ 14Q�$ Value�� �� *Value+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=��� $��General Journal No��$
��Left=�$��	20,64,0,0q�$	��Top=�*  $DevExpress.Xpf.Editors.SearchControl  $
��Left=�$��	20,91,0,0q�$	��Top=�$	��135���� $��Periode��$
��Left=�$��
170,64,0,0q�$	��Top=�(  "System.Windows.Controls.DatePicker  $
��Left=�$��
171,90,0,0q�$	��Top=�$	��117��  $
��Left=�$��
305,90,0,0q�$	��Top=�$	��117���� $��Value Range��$
��Left=�$��
440,64,0,0q�$	��Top=��� $
��Left=�$��23��$��
440,90,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120���� $
��Left=�$��23��$��
575,90,0,0q�$
 Wrap=�$	��Top=�$	��120���� $��Currency��$
��Left=�$��
710,64,0,0q�$	��Top=��� $
��Left=�$��
710,90,0,0q�$	��Top=�$	��120���� $
��Left=�$��850,90,-30,0q�$	��Top=�$	��120���� $��Value��$
��Left=�$��
850,64,0,0q�$	��Top=�