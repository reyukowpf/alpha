   M S B A M L   `   `   `  ����   
Reyuko.App(    "Reyuko.App.Views.Location.Location   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  U	 QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 
�������.��� .+�' 	 !MaterialDesignThemes.Wpf.PopupBox      ToggleContent$	  ...��$��32��$��20(�$��Right=�$��0,1,8,0q�$	��Top=�$��40���� $��Right=�$��20��$��
0,13,270,0q�$	��Top=�$��20��$)��#/Reyuko.App;component/Icons/new.png���� $��Right=�$��20��$��	0,13,94,0q�$	��Top=�$��20��$-��'/Reyuko.App;component/Icons/refresh.png���� $��Right=�$��20��$��
0,13,152,0q�$	��Top=�$��20��$+��%/Reyuko.App;component/Icons/print.png���� $��Right=�$��20��$��
0,13,212,0q�$	��Top=�$��20��$*��$/Reyuko.App;component/Icons/edit.png���� $	��178��$��30��$��	10,10,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$��Location��$
��Wrap=��� -    ��Name$ Print��$��42��$��24��$��
0,10,115,0q�$��Right=�$	��Top=�
������ $��0q�#��[" �$��Print���� -   $ Refresh��$��50��$��24��$��	0,10,45,0q�$��Right=�$	��Top=�
������ $��0q�#��[" �$��Refresh���� -   $	 New��$��39��$��24��$��
0,10,237,0q�$��Right=�$	��Top=�
������ $��0q�#��[" �$	��New���� -   $
 Edit��$��39��$��24��$��
0,10,180,0q�$��Right=�$	��Top=�
������ $��0q�#��[" �$
��Edit���� -    ��Name$ LstLocation��$	��180��$
��Auto��$��	8,100,0,0q�$
��Left=����� .R��� $��44��$��0,0,0,0q� �� Orientation$ 
Horizontal=�.+��� $��44��$��26��$��0,10,1,8q�$��Center=�$��Center=����� *KodeLocation+�� $��2��$	��121��$��0,2,0,10q�$
��Wrap=�$��Center=�$��Center=����� *NamaLocation+�� $��Search��$
��Left=�$��
200,70,0,0q�$	��Top=�$��26���� $��Periode��$
��Left=�$��
528,70,0,0q�$	��Top=�$��26���� $��Category��$
��Left=�$��
363,70,0,0q�$	��Top=��� $��Value Range��$
��Left=�$��
772,70,0,0q�$	��Top=�*  $DevExpress.Xpf.Editors.SearchControl  $
��Left=�$��28��$��	10,64,0,0q�$	��Top=� J� RenderTransformOrigin$ -0.212,1&�$	��178��  -     Name$ Search��$
��Left=�$��28��$��
200,94,0,0q�$	��Top=�$ 0.212,1&�$	��152��(  "System.Windows.Controls.DatePicker  $
��Left=�$��28��$��
528,94,0,0q�$	��Top=�$	��110��  $
��Left=�$��28��$��
650,94,0,0q�$	��Top=�$	��110���� -    ��Name$ 
cbCategory��$
��Left=�$��
363,94,0,0q�$��28��$	��Top=�$	��152���� -    ��Name$ txtvalue��$
��Left=�$��28��$��
772,94,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��110���� -	   $ txtRange��$
��Left=�$��28��$��
892,94,0,0q�$
 Wrap=�$	��Top=�$	��110��&   System.Windows.Controls.DataGrid  -
   	  Name$	 
DGLocation��$
��Auto��$	��400��$��200,135,0,0q�
   AutoGenerateColumns
 .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$��14(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�   	RowHeight$ 30Q�   SelectionMode$ Single=���Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�   Header$   SKU / Name��1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding �� *	SKUName+    HeaderStyle  �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����! 	  ElementStyle! �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $ 14Q�$ Category�� �� *
Category+  �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����! �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Satuan�� �� *Satuan+  �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����! �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $ 14Q�$ 	Inventory�� �� *	Inventory+  �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����! �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�