   M S B A M L   `   `   `  ����   
Reyuko.App2    ,Reyuko.App.Views.AccountBudget.AccountBudget   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   
�������.��� $��0,0,0,0q�.+��� $	��273��$��30��$��	20,20,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$��Budget VS Realization��$
��Wrap=��� -     ��Name$  other��$��33��$��	0,20,10,0q�$��Right=�$	��Top=�
������ $��0q�$	��...��$
��Bold"�#��[" ��� -   $��38��$��
0,20,141,0q�$��Right=�$	��Top=�
������ $��0q�$
��View��#��[" ��� -   $��98��$��	0,20,43,0q�$��Right=�$	��Top=�
������ $��0q�$��Print��#��[" ��� $��	Kas (IDR)��$
��Left=�$��
234,57,0,0q�$	��Top=�$��18(�&   System.Windows.Controls.DataGrid  -     Name$ DGBudget��$
��Auto��$	��400��$��
235,95,0,0q�   AutoGenerateColumns .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$��14(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�	   	RowHeight$	 30Q�
   SelectionMode$
 Single=���Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 90    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�   Header$ Month��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
BulanKas+   HeaderStyle �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����   ElementStyle �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Budget Code�� �� *
BudgetCode+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ 
Department�� �� *
Department+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Project�� �� *	Project+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Location�� �� *
Location+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Description�� �� *Description+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Budget�� �� *Budget+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ *  .   .   . $ 14Q�$ Realization�� �� *Realization+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�R� $
��Left=�$	��433��$��	22,57,0,0q�$	��Top=�$	��206��.@�Q� $��Harta�� Q� 
IsExpanded . .@�Q� $��Harta Lancar�� . .@�Q� $	��Kas�� . .@�Q� $	��Kas��Q� $
��Bank�� . Q� $��Piutang Dagang�� . Q� $��
Persediaan�� . Q� $��Biaya Dibayar Dimuka �� . Q� $��
Biaya Lain�� . Q� $��Harta Tetap Berwujud�� . Q� $ ��Harta Tetap Tidak Berwujud�� . Q� $��Harta Lainnya�� . Q� $��Investasi Jangka Panjang�� . �� $��Accounting Periode��$��Right=�$��
0,63,181,0q�$	��Top=��� $��Right=�$��	0,63,50,0q�$	��Top=�$	��120��