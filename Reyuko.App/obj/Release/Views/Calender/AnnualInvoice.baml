   M S B A M L   `   `   `  ����   
Reyuko.App-    'Reyuko.App.Views.Calender.AnnualInovice   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    � WindowStyle$
  None=�$	��Top=�
������� � 	Resources    MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%  &	        �� " ��.���  �@�OverridesDefaultStyle . ��  �@�Cursor$
 Hand����  � �� �� " ��.R��� $��border��$��0q�
���   �#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 0.8Q�.��� $��0,0,0,0q�.+��� $	��273��$��42��$��	30,20,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��36(�$��Normal$�$��Annual Invoice��$
��Wrap=��� -   $��Right=�$��
0,18,270,0q�
������ $��0q�#��[  $	��Top=�$��70��.���� 	 �� Orientation$	 
Horizontal=�.+��� $,��&/Reyuko.App;component/Icons/detail.png��$��20���� $�� Open��$
��12.5(�$��Center=�$��Center=��� -   $��Right=�$��
0,18,180,0q�
������ $��0q�#��[  $	��Top=�$��80��.���� $	 
Horizontal=�.+��� $,��&/Reyuko.App;component/Icons/excute.png��$��20���� $�� Execute��$
��12.5(�$��Center=�$��Center=��� -   $��Right=�$��
0,18,100,0q�
������ $��0q�#��[  $	��Top=�$��70��.���� $	 
Horizontal=�.+��� $,��&/Reyuko.App;component/Icons/delete.png��$��20���� $�� Delete��$
��12.5(�$��Center=�$��Center=��� -   $��Right=�$��	0,18,20,0q�
������ $��0q�#��[  $	��Top=�$��70��.���� $	 
Horizontal=�.+��� $+��%/Reyuko.App;component/Icons/close.png��$��20���� $�� Cancel��$
��12.5(�$��Center=�$��Center=�&   System.Windows.Controls.DataGrid  -   
  Name$
 DGAnnualInvoice��$
��Auto��$	��400��$��
23,73,0,-6q�   AutoGenerateColumns .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$
��12.5(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�   	RowHeight$ 30Q�   SelectionMode$ Single=���Z� ��Z�  =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$
 12.5Q�   Header$ 
  Customer��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *NamaCustomer+   HeaderStyle �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����   ElementStyle �� # [B��" ��.���  �@��TextAlignment$
 Left=���  � ��$	 Top=�  $	 100  .   .   . $
 12.5Q�$ Refferal�� �� *
Refferal+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $
 12.5Q�$
 Date�� �� *Tgl+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $
 12.5Q�$ Total�� �� *Total+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ *  .   .   . $
 12.5Q�$ Remarks�� �� *	Remarks+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�