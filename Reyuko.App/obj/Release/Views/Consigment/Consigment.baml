   M S B A M L   `   `   `  ����   
Reyuko.App,    &Reyuko.App.Views.Consigment.Consigment   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  U	 QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 
�������.��� .+�' 	 !MaterialDesignThemes.Wpf.PopupBox      ToggleContent$	  New��
������ $��0q�$��24��$��Right=�$��	0,9,235,0q�$	��Top=�$��50��   PopupContent. �� .+���  �� Orientation$ 
Horizontal=�$	��150��.+��� $)��#/Reyuko.App;component/Icons/new.png��$��21��$��30���� -   $��Receive��$	��Top=��� $ 
Horizontal=�$	��150��.+��� $)��#/Reyuko.App;component/Icons/new.png��$��21��$��30���� -   $��Return��$	��Top=�  $	  ...��$��32��$��20(�$��Right=�$��0,1,8,0q�$	��Top=�$��40��. �� .+��� $ 
Horizontal=�$	��150��.+��� $.��(/Reyuko.App;component/Icons/tutorial.png��$��21��$��30���� -   $��Play Tutorial���� $��Right=�$��20��$��	0,13,94,0q�$	��Top=�$��20��$-��'/Reyuko.App;component/Icons/refresh.png���� $��Right=�$��20��$��
0,13,152,0q�$	��Top=�$��20��$+��%/Reyuko.App;component/Icons/print.png���� $��Right=�$��20��$��
0,13,212,0q�$	��Top=�$��20��$*��$/Reyuko.App;component/Icons/edit.png���� $	��178��$��30��$��	10,10,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$��
Consigment��$
��Wrap=��� -    ��Name$ Print��$��42��$��24��$��
0,10,115,0q�$��Right=�$	��Top=�
������ $��0q�#��[" �$��Print���� -   $ Refresh��$��50��$��24��$��	0,10,45,0q�$��Right=�$	��Top=�
������ $��0q�#��[" �$��Refresh���� -   $
 Edit��$��39��$��24��$��
0,10,180,0q�$��Right=�$	��Top=�
������ $��0q�#��[" �$
��Edit���� $��Vendor / Id��$
��Left=�$��	10,40,0,0q�$	��Top=�$��26���� $��Periode��$
��Left=�$��
177,40,0,0q�$	��Top=�$��26���� $��Recap��$
��Left=�$��
430,40,0,0q�$	��Top=��� $��Receive / Return��$
��Left=�$��
10,100,0,0q�$	��Top=��� $��Value Range��$
��Left=�$��177,100,0,0q�$	��Top=��� $��Currency��$
��Left=�$��430,100,0,0q�$	��Top=�*  $DevExpress.Xpf.Editors.SearchControl  -     Name$ Vendor��$
��Left=�$��28��$��	10,64,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.212,1&�$	��152��(  "System.Windows.Controls.DatePicker  $
��Left=�$��28��$��
177,64,0,0q�$	��Top=�$	��110��  $
��Left=�$��28��$��
300,64,0,0q�$	��Top=�$	��110���� -    ��Name$ cbRecap��$
��Left=�$��
430,64,0,0q�$��28��$	��Top=�$	��152���� -	   $ 	cbReceive��$
��Left=�$��
10,125,0,0q�$��28��$	��Top=�$	��152���� -
    ��Name$ txtvalue��$
��Left=�$��28��$��177,125,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��110���� -   $ txtRange��$
��Left=�$��28��$��300,125,0,0q�$
 Wrap=�$	��Top=�$	��110���� -   $ 
cbCurrency��$
��Left=�$��430,125,0,0q�$��28��$	��Top=�$	��152��&   System.Windows.Controls.DataGrid  -   	  Name$	 DGConsigment��$
��Auto��$	��400��$��
10,167,0,0q�
   AutoGenerateColumns
 .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$��14(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�   	RowHeight$ 30Q�   SelectionMode$ Single=���Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�   Header$   Consigment No.��1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding �� *NoConsigment+    HeaderStyle  �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����! 	  ElementStyle! �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$
 Date�� �� *TglConsigment+  �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����! �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 150  .   .   . $ 14Q�$ 	Vendor/ID�� �� *
IDVendor+  �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����! �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $ 14Q�$ Receive/Return�� �� *	Receive+  �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����! �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Currency�� �� *
Currency+  �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����! �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 150  .   .   . $ 14Q�$ Value�� �� *Value+  �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����! �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�