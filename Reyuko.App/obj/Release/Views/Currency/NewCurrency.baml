   M S B A M L   `   `   `  ����   
Reyuko.App+    %Reyuko.App.Views.Currency.NewCurrency   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $	��400��$	��450��$��14(�  � Icon$.  (/Reyuko.App;component/Icons/currency.png�� � 
ResizeMode$ NoResize=� � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.��� .+��� $	��178��$��30��$��	10,10,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$��Currency��$
��Wrap=�&   System.Windows.Controls.DataGrid  -     Name$ DGCurrencyDetail��$	��394��$	��376��$��0,45,0,0q�$	��Top=�$��0q�   ColumnHeaderHeight$ 32Q�$��14(�   HeadersVisibility$ Column=�   	RowHeight$ 30Q�   SelectionMode$ Single=�	   AutoGenerateColumns	 .  
   CanUserAddRows
 . ��Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%n   '        7 �� 8   "  .���  � ��$ Center=���  � �� �#cdcccc��  � ��
 �   �   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 120    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�   Header$  Code��   
IsReadOnly .  1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *KodeMataUang+   HeaderStyle �� # [B "  .���  � ��$ Center=���  � �� �#cdcccc��  � ��
 �   �   ElementStyle �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $ 14Q�$
 Name�� .   �� *NamaMataUang+ �� # [B "  .���  � ��$ Center=���  � �� �#cdcccc��  � ��
 �   � �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Symbol�� .   �� *SimbolMataUang+ �� # [B "  .���  � ��$ Center=���  � �� �#cdcccc��  � ��
 �   � �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=��� -   $��Right=�$��
0,12,100,0q�
������ $��0q�#��[" �$	��Top=�$��60��.����  �� Orientation$ 
Horizontal=�.+��� $)��#/Reyuko.App;component/Icons/new.png��$��20���� $
�� Add��$��14(�$��Center=�$��Center=��� -   $��Right=�$��	0,12,20,0q�
������ $��0q�#��[" �$	��Top=�$��70��.���� $ 
Horizontal=�.+��� $,��&/Reyuko.App;component/Icons/close2.png��$��20���� $�� Cancel��$��14(�$��Center=�$��Center=�