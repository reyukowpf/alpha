   M S B A M L   `   `   `  ����   
Reyuko.App(    "Reyuko.App.Views.Currency.Currency   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  :d2http://schemas.microsoft.com/expression/blend/2008  ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa	 ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid  	 Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006  	 
�������.��� .+��� -     ��Name$  
LICurrency��$	��200��$
��Auto��$��8,57,0,0q�$
��Left=����� .R��� $��46��$��0,0,0,0q� �� Orientation$ 
Horizontal=�.+��� $��44��$��26��$��0,10,1,8q�$��Center=�$��Center=����� *KodeMataUang+�� $��2��$	��121��$��0,2,0,10q�$
��Wrap=��� ���� *NamaMataUang+�� �� ���� *	KursTukar+&   System.Windows.Controls.DataGrid  -     Name$ DGCurrencyDetail��$
��Auto��$	��400��$��
213,57,0,0q�   AutoGenerateColumns .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$��14(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly . 	   RowDetailsVisibilityMode$	 Visible=�
   	RowHeight$
 30Q�   SelectionMode$ Single=���Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 160    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�   Header$
 Date��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	Tanggal+   HeaderStyle �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   ElementStyle �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 180  .   .   . $ 14Q�$ Currency�� �� *KodeMataUang+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 150  .   .   . $ 14Q�$
 Rate�� �� *Exrate+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ *  .   .   . $ 14Q�$ Up Date�� �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=��� $	��178��$��30��$��	10,10,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$��Currency Data��$
��Wrap=�'  !MaterialDesignThemes.Wpf.PopupBox     ToggleContent$	 ...��$��32��$��20(�$��Right=�$��0,1,8,0q�$	��Top=�$��40��   PopupContent. �� .+��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��125��.���� $ 
Horizontal=�.+��� $.��(/Reyuko.App;component/Icons/currency.png��$��23��$��23���� $��Set as Default��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��140��.���� $ 
Horizontal=�.+��� $-��'/Reyuko.App;component/Icons/setting.png��$��23��$��23���� $��Account Setting��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��105��.���� $ 
Horizontal=�.+��� $+��%/Reyuko.App;component/Icons/close.png��$��23��$��23���� $��
Deactivate��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��120��.���� $ 
Horizontal=�.+��� $.��(/Reyuko.App;component/Icons/tutorial.png��$��23��$��23���� $��Play Tutorial��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� -   $��Right=�$��
0,12,190,0q�
������ $��0q�#��[" �$	��Top=�$��60��.���� $ 
Horizontal=�.+��� $)��#/Reyuko.App;component/Icons/new.png��$��20���� $
�� New��$��14(�$��Center=�$��Center=��� -   $��Right=�$��	0,12,55,0q�
������ $��0q�#��[" �$	��Top=�$	��130��.���� $ 
Horizontal=�.+��� $*��$/Reyuko.App;component/Icons/edit.png��$��20���� $�� Ex Rate Update��$��14(�$��Center=�$��Center=�