   M S B A M L   `   `   `  ����   
Reyuko.AppT    NReyuko.App.Views.ReceivedPostDateChequeIssuance.ReceivedPostDateChequeIssuance   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  U	 QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 
�������$	��Top=�  � 	Resources     MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%  &	        �� " ��.���  �@�OverridesDefaultStyle . ��  �@�Cursor$
 Hand����  � �� �� " ��.R��� $��border��$��0q�
���   �#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 0.8Q�.��� .+�' 	 !MaterialDesignThemes.Wpf.PopupBox     ToggleContent$	 ...��$��32��$��18(�$��Right=�$��0,3,8,0q�$	��Top=�$��40��	   PopupContent.	 �� .+��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��120��.���� 
 �� Orientation$
 
Horizontal=�.+��� $.��(/Reyuko.App;component/Icons/tutorial.png��$��23��$��23���� $��Play Tutorial��$
��12.5(�$
��Left=�$��10,0,0,0q�$��Center=��� $	��456��$��47��$��	10,10,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��36(�$��Normal$�$(��"Received Post-Date Cheque Issuance��$
��Wrap=��� -   $��Right=�$��
0,12,137,0q�
������ $��0q�#��[  $	��Top=�$	��140��.���� $
 
Horizontal=�.+��� $.��(/Reyuko.App;component/Icons/currency.png��$��20���� $�� Chasing Check��$
��12.5(�$��Center=�$��Center=��� -   $��Right=�$��	0,12,55,0q�
������ $��0q�#��[  $	��Top=�$��75��.���� $
 
Horizontal=�.+��� $-��'/Reyuko.App;component/Icons/refresh.png��$��20���� $�� Refresh��$
��12.5(�$��Center=�$��Center=��� $��Contact / ID��$
��12.5(�$
��Left=�$��	10,62,0,0q�$	��Top=�$��26���� $��Date Periode��$
��12.5(�$
��Left=�$��
177,62,0,0q�$	��Top=��� $��Due Date Periode��$
��12.5(�$
��Left=�$��
432,62,0,0q�$	��Top=��� $��Currency��$
��12.5(�$
��Left=�$��
10,122,0,0q�$	��Top=��� $��Value Range��$
��12.5(�$
��Left=�$��177,122,0,0q�$	��Top=�*  $DevExpress.Xpf.Editors.SearchControl  -     Name$ Employee��$
��12.5(�$
��Left=�$��28��$��	10,86,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.212,1&�$	��152��(  "System.Windows.Controls.DatePicker  $
��Left=�$��28��$
��12.5(�$��
177,86,0,0q�$	��Top=�$	��110��  $
��Left=�$��28��$
��12.5(�$��
300,86,0,0q�$	��Top=�$	��110��  $
��Left=�$��28��$
��12.5(�$��
432,86,0,0q�$	��Top=�$	��110��  $
��Left=�$��28��$
��12.5(�$��
555,86,0,0q�$	��Top=�$	��110���� -    ��Name$ 
cbCurrency��$
��Left=�$
��12.5(�$��
10,147,0,0q�$��28��$	��Top=�$	��152���� -    ��Name$ txtvalue��$
��Left=�$��28��$
��12.5(�$��177,147,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��110���� -   $ txtRange��$
��Left=�$��28��$
��12.5(�$��300,147,0,0q�$
 Wrap=�$	��Top=�$	��110��&   System.Windows.Controls.DataGrid  -     Name$ DGPostDateChequeIssuance��$
��Auto��$	��400��$��10,189,0,-22q�   AutoGenerateColumns .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$
��12.5(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�   	RowHeight$ 30Q�   SelectionMode$ Single=���Z� ��Z�   =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100    CanUserReorder .     CanUserResize .     CanUserSort .     FontSize$
  12.5Q�!   Header$!   Date��1	  +System.Windows.Controls.DataGridBoundColumn" 	  Binding" �� *TglPostDateCheque+#   HeaderStyle# �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����$ 	  ElementStyle$ �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $
  12.5Q�$! Reference No.��" �� *NoReference+# �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����$ �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 150  .   .   . $
  12.5Q�$! Contact / ID��" �� *	IDContact+# �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����$ �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $
  12.5Q�$! 	Bank Name��" �� *
BankName+# �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����$ �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $
  12.5Q�$! Bank Account No��" �� *BankAccountNo+# �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����$ �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $
  12.5Q�$! Due Date��" �� *	Duedate+# �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����$ �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $
  12.5Q�$! Currency��" �� *
Currency+# �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����$ �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $
  12.5Q�$! 	Cheque No��" �� *Cheque+# �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����$ �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $
  12.5Q�$! Value��" �� *Value+# �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����$ �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�