   M S B A M L   `   `   `  ����   
Reyuko.App5    /Reyuko.App.Views.SalaryPayment.NewSalaryPayment   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  U	 QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 $	��730��$��14(�  � 
ResizeMode$  NoResize=� � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�
�������.��� .+�' 	 !MaterialDesignThemes.Wpf.PopupBox     ToggleContent$	 ...��$��32��$��20(�$��Right=�$��0,2,8,0q�$	��Top=�$��40��   PopupContent. �� .+��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��130��.����  �� Orientation$ 
Horizontal=�.+��� $*��$/Reyuko.App;component/Icons/save.png��$��23��$��23���� $��Save as Draft��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��120��.���� $ 
Horizontal=�.+��� $+��%/Reyuko.App;component/Icons/notes.png��$��28��$��28��$��2,0,0,0q�$
��Left=��� $��Import File��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��120��.���� $ 
Horizontal=�.+��� $.��(/Reyuko.App;component/Icons/tutorial.png��$��26��$��26��$��5,0,0,0q��� $��Play Tutorial��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� $	��351��$��30��$��	10,10,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$��New Salary Payment��$
��Wrap=��� -   $��Right=�$��
0,12,135,0q�
������ $��0q�#��[" �$	��Top=�$��60��.���� $ 
Horizontal=�.+��� $*��$/Reyuko.App;component/Icons/save.png��$��20���� $�� Save��$��14(�$��Center=�$��Center=��� -   $��Right=�$��	0,12,55,0q�
������ $��0q�#��[" �$	��Top=�$��70��.���� $ 
Horizontal=�.+��� $+��%/Reyuko.App;component/Icons/close.png��$��20���� $�� Cancel��$��14(�$��Center=�$��Center=��� $��Salary Payment Date��$
��Left=�$��	10,60,0,0q�$	��Top=��� $��Cash Account��$
��Left=�$��
175,60,0,0q�$	��Top=��� $��Salary Account��$
��Left=�$��
340,60,0,0q�$	��Top=��� $�� ��$
��Left=�$��520,100,0,0q�$	��Top=��� $��	Alocation��$
��Left=�$��
10,130,0,0q�$	��Top=��� $��	Staf / Id��$
��Left=�$��
10,500,0,0q�$	��Top=��� $��Total Payment Value��$��Right=�$��0,490,260,0q�$	��Top=��� $��:��$��Right=�$��0,490,160,0q�$	��Top=�(  "System.Windows.Controls.DatePicker  $
��Left=�$��28��$��	10,85,0,0q�$	��Top=�$	��150���� -    ��Name$ cbCashAccount��$
��Left=�$��
175,85,0,0q�$��28��$	��Top=�$	��152���� -   $ cbSalaryAccount��$
��Left=�$��
340,85,0,0q�$��28��$	��Top=�$	��152���� -   $ cbTaxAccount��$
��Left=�$��
510,85,0,0q�$��28��$	��Top=�$	��152���� $��Tax Account��$��10(�$
��Left=�$��
510,60,0,0q�$	��Top=�*  $DevExpress.Xpf.Editors.SearchControl  -	     Name$ IDstaff��$
��Left=�$��28��$��
10,525,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.212,1&�$	��152���� -
   	 ��Name$	 txtTotalPaymentValue��$
��aaaa��$��Right=�$��28��$��	0,490,0,0q�$
��Wrap=�$	��Top=�$	��150��&   System.Windows.Controls.DataGrid  -   
  Name$
 DGSalaryPayment��$
��Auto��$	��400��$��10,167,0,216q�   AutoGenerateColumns .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$��14(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�   	RowHeight$ 30Q�   SelectionMode$ Single=���Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%n   '        7 �� 8   "  .���  � ��$ Center=���  � �� �#d3d3d3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 120    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�   Header$   No. Pembayaran��1	  +System.Windows.Controls.DataGridBoundColumn  	  Binding  �� *NoPembayaran+!   HeaderStyle! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" 	  ElementStyle" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $ 14Q�$ Employee / ID��  �� *
IDEmployee+! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Basic Salary��  �� *BasicSalary+! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ 	Allowance��  �� *	Allowance+! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Overtime��  �� *
Overtime+! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Overtime/Hour��  �� *Overtimehour+! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Total Overtime��  �� *Totalovertime+! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Others��  �� *Other+! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 80  .   .   . $ 14Q�$	 Tax��  �� *Tax+! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$
 Note��  �� *Note+! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ 	Bank Data��  �� *
BankData+! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$	 Job��  �� *Job+! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Total��  �� *Total+! �� # [B "  .���  � ��$
 Left=���  � �� �#d3d3d3��  � ��
 �����" �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�