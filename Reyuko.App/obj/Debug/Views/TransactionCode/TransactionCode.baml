   M S B A M L   `   `   `  ����  
Reyuko.App6    0Reyuko.App.Views.TransactionCode.TransactionCode   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������$	��Top=�5        � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5      .��5!      � $��0,0,0,0q�6   .+�5"   
   �� $	��273��5#      $��42��5$      $��	30,20,0,0q�5%      $
��Left=�5&      $	��Top=�5'      $��Segoe)�5(      $��36(�5)      $��Normal$�5*      $��Transation Code��5+      $
��Wrap=�5,      �� 5-   
   -   5        $��Right=�5-      $��	0,20,55,0q�6-   
������ $��0q�6Y   #��[  5.      $	��Top=�6/   $��60��6G   .��5/      ��  �� Orientation$ 
Horizontal=�6   .+�50      �� $*��$/Reyuko.App;component/Icons/edit.png��6   $��20��6F   �� 51      $�� Edit��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   52      53      &   System.Windows.Controls.DataGrid  54   
   -   5        	  Name$	 DGTransactionCode��55      $
��Auto��56      $	��400��57      $��	30,67,0,0q�58      
   AutoGenerateColumns
 .  $��0q�5<         CanUserResizeRows .     ColumnHeaderHeight$ 32Q�5>      $
��12.5(�5?         GridLinesVisibility$
 None=�5@         HeadersVisibility$ Column=�5A         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�5C         	RowHeight$ 30Q�5D         SelectionMode$ Single=�5E      ��5:      Z� ��5;      Z�   5F      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5G      8   "  6Q   .�5H      ��  � ��$ Center=�6C   �� 5I       � �� �	#FF5684C363   �� 5J       � ��
 �����63   5K      5N         Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 5Q         CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$
 12.5Q�5V         Header$ Transaction Code��5W      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5R      �� *Kode+   HeaderStyle 5X      �� 5Y      # [B 6    "  6Y   .�5Z      ��  � ��$ Center=�6K   �� 5[       � �� �	#FF5684C36;   �� 5\       � ��
 �����6;   5]         ElementStyle 5_      �� 5`      # [B��6    " ��6N   .�5a      ��  �@��TextAlignment$ Center=�6H   �� 5b       � ��$ Center=�6B   5c      5e        5f      $	 600 5g       .   .   . $
 12.5Q�5l      $ Description��5m       5h      �� *
Keterangan+ 5n      �� 5o      # [B 6    "  6Y   .�5p      ��  � ��$
 Left=�6K   �� 5q       � �� �	#FF5684C36;   �� 5r       � ��
 �����6;   5s       5u      �� 5v      # [B��6    " ��6N   .�5w      ��  �@��TextAlignment$ Center=�6H   �� 5x       � ��$ Center=�6B   5y      5{      5~      '  !MaterialDesignThemes.Wpf.PopupBox  5�   
      ToggleContent$	 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,10,8,0q�6l   $	��Top=�6   $��40��6�      PopupContent. 5�      �� .+�5�      �� -   5        $
��Left=�5�      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5�      $	��Top=�6P   $	��120��6h   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� $.��(/Reyuko.App;component/Icons/tutorial.png��6    $��23��6R   $��23��6^   �� 5�      $��Play Tutorial��6$   $
��12.5(�69   $
��Left=�6I   $��10,0,0,0q�6d   $��Center=�6v   5�      5�      5�      5�      5�      5�      