   M S B A M L   `   `   `  ����   
Reyuko.App(    "Reyuko.App.Views.Calender.Calender   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��Top=�
�������  � 	Resources     MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%  &	        �� " ��.���  �@�OverridesDefaultStyle . ��  �@�Cursor$
 Hand����  � �� �� " ��.R��� $��border��$��0q�
���   �#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 0.8Q�.��� .+��� $	��178��$��42��$��	10,20,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��36(�$��Normal$�$��Calendar��$
��Wrap=�'  !MaterialDesignThemes.Wpf.PopupBox     ToggleContent$	 ...��$��32��$��18(�$��Right=�$��0,10,8,0q�$	��Top=�$��40��	   PopupContent.	 �� .+��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$��90��.���� 
 �� Orientation$
 
Horizontal=�.+��� $,��&/Reyuko.App;component/Icons/delete.png��$��23��$��23���� $��Delete��$
��12.5(�$
��Left=�$��10,0,0,0q�$��Center=��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��127��.���� $
 
Horizontal=�.+��� $.��(/Reyuko.App;component/Icons/tutorial.png��$��23��$��23���� $��Play Tutorial��$
��12.5(�$
��Left=�$��10,0,0,0q�$��Center=��� -   $��Right=�$��
0,18,310,0q�
������ $��0q�#��[  $	��Top=�$	��145��.���� $
 
Horizontal=�.+��� $.��(/Reyuko.App;component/Icons/calendar.png��$��20���� $�� Asset Assigment��$
��12.5(�$��Center=�$��Center=��� -   $��Right=�$��
0,18,230,0q�
������ $��0q�#��[  $	��Top=�$��70��.���� $
 
Horizontal=�.+��� $,��&/Reyuko.App;component/Icons/detail.png��$��20���� $�� Open��$
��12.5(�$��Center=�$��Center=��� -   $��Right=�$��
0,18,140,0q�
������ $��0q�#��[  $	��Top=�$��80��.���� $
 
Horizontal=�.+��� $,��&/Reyuko.App;component/Icons/excute.png��$��20���� $�� Execute��$
��12.5(�$��Center=�$��Center=��� -   $��Right=�$��	0,18,55,0q�
������ $��0q�#��[  $	��Top=�$��80��.���� $
 
Horizontal=�.+��� $-��'/Reyuko.App;component/Icons/refresh.png��$��20���� $�� Refresh��$
��12.5(�$��Center=�$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ DGAnnualInvoice��$
��Auto��$	��400��$��580,67,-150,283q�   AutoGenerateColumns .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$
��12.5(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�   	RowHeight$ 30Q�   SelectionMode$ Single=���Z� ��Z�   =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 130    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$
 12.5Q�   Header$   Annual Invoice��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *AnnualInvoice+   HeaderStyle �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����   ElementStyle �� # [B��" ��.���  �@��TextAlignment$
 Left=���  � ��$	 Top=�  $ *  .   .   . $
 12.5Q�$    Total�� �� *Total+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  -   $ DGReceivableDue��$
��Auto��$	��400��$��580,227,-150,123q� .  $��0q� .  $ 32Q�$
��12.5(�$
 None=�$ Column=� . $ Visible=�$ 30Q�$ Single=���Z� ��Z�   ��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   $	 130  .   .   . $
 12.5Q�$   Receivable Due�� �� *Receivabledue+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$
 Left=���  � ��$	 Top=�  $ *  .   .   . $
 12.5Q�$   Total�� �� *Total+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  -	   $ 	DGDebtDue��$
��Auto��$	��400��$��580,387,-150,0q� .  $��0q� .  $ 32Q�$
��12.5(�$
 None=�$ Column=� . $ Visible=�$ 30Q�$ Single=���Z� ��Z�   ��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   $	 120  .   .   . $
 12.5Q�$ 	  DebtDue�� �� *	DebtDue+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$
 Left=���  � ��$	 Top=�  $ *  .   .   . $
 12.5Q�$ Total�� �� *Total+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 ����� �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�