   M S B A M L   `   `   `  ����  
Reyuko.App-    'Reyuko.App.Views.Calender.AnnualInovice   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � WindowStyle$
  None=�5
      $	��Top=�5      
������� � 	Resources 5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5       5!      .��5#      � $��0,0,0,0q�6   .+�5$   
   �� $	��273��5%      $��42��5&      $��	30,20,0,0q�5'      $
��Left=�5(      $	��Top=�5)      $��Segoe)�5*      $��36(�5+      $��Normal$�5,      $��Annual Invoice��5-      $
��Wrap=�5.      �� 50   
   -   5        $��Right=�50      $��
0,18,270,0q�6-   
������ $��0q�6Z   #��[  51      $	��Top=�60   $��70��6H   .��52      �� 	 �� Orientation$	 
Horizontal=�6   .+�53      �� $,��&/Reyuko.App;component/Icons/detail.png��6   $��20��6H   �� 54      $�� Open��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   55      56      �� 58   
   -   5        $��Right=�58      $��
0,18,180,0q�6-   
������ $��0q�6Z   #��[  59      $	��Top=�60   $��80��6H   .��5:      �� $	 
Horizontal=�6   .+�5;      �� $,��&/Reyuko.App;component/Icons/excute.png��6   $��20��6H   �� 5<      $�� Execute��6   $
��12.5(�6,   $��Center=�6<   $��Center=�6Y   5=      5>      �� 5@   
   -   5        $��Right=�5@      $��
0,18,100,0q�6-   
������ $��0q�6Z   #��[  5A      $	��Top=�60   $��70��6H   .��5B      �� $	 
Horizontal=�6   .+�5C      �� $,��&/Reyuko.App;component/Icons/delete.png��6   $��20��6H   �� 5D      $�� Delete��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5E      5F      �� 5H   
   -   5        $��Right=�5H      $��	0,18,20,0q�6-   
������ $��0q�6Y   #��[  5I      $	��Top=�60   $��70��6H   .��5J      �� $	 
Horizontal=�6   .+�5K      �� $+��%/Reyuko.App;component/Icons/close.png��6   $��20��6G   �� 5L      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5M      5N      &   System.Windows.Controls.DataGrid  5O   
   -   5        
  Name$
 DGAnnualInvoice��5P      $
��Auto��5Q      $	��400��5R      $��
23,73,0,-6q�5S         AutoGenerateColumns .  $��0q�5W         CanUserResizeRows .     ColumnHeaderHeight$ 32Q�5Y      $
��12.5(�5Z         GridLinesVisibility$
 None=�5[         HeadersVisibility$ Column=�5\         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�5^         	RowHeight$ 30Q�5_         SelectionMode$ Single=�5`      ��5U      Z� ��5V      Z�  5a      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5b      8   "  6Q   .�5c      ��  � ��$ Center=�6C   �� 5d       � �� �	#FF5684C363   �� 5e       � ��
 �����63   5f      5h         Columns 5i      0  *System.Windows.Controls.DataGridTextColumn  5j      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 5k         CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$
 12.5Q�5p         Header$ 
  Customer��5q      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5l      �� *NamaCustomer+   HeaderStyle 5r      �� 5s      # [B 6    "  6Y   .�5t      ��  � ��$
 Left=�6K   �� 5u       � �� �	#FF5684C36;   �� 5v       � ��
 �����6;   5w         ElementStyle 5y      �� 5z      # [B��6    " ��6N   .�5{      ��  �@��TextAlignment$
 Left=�6H   �� 5|       � ��$	 Top=�6L   5}      5        5�      $	 100 5�       .   .   . $
 12.5Q�5�      $ Refferal��5�       5�      �� *
Refferal+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6L   5�      5�        5�      $	 100 5�       .   .   . $
 12.5Q�5�      $
 Date��5�       5�      �� *Tgl+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6L   5�      5�        5�      $	 100 5�       .   .   . $
 12.5Q�5�      $ Total��5�       5�      �� *Total+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6L   5�      5�        5�      $ * 5�       .   .   . $
 12.5Q�5�      $ Remarks��5�       5�      �� *	Remarks+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6L   5�      5�      5�      5�      5�      