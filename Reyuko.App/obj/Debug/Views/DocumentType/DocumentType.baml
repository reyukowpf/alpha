   M S B A M L   `   `   `  ����  
Reyuko.App0    *Reyuko.App.Views.DocumentType.DocumentType   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $��14(�5
      
�������$
��Left=�5      $	��Top=�61   $
��1040��6I   $	��700��6V     � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5       .��5"      � $��0,0,0,0q�6   .+�5#   
   �� $	��273��5$      $��52��5%      $��	30,12,0,0q�5&      $
��Left=�5'      $	��Top=�5(      $��Segoe)�5)      $��36(�5*      $��Normal$�5+      $��Document Type��5,      $
��Wrap=�5-      '  !MaterialDesignThemes.Wpf.PopupBox  5/   
      ToggleContent$	 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,10,8,0q�6l   $	��Top=�6   $��40��6�   	   PopupContent.	 50      �� .+�51      �� -   5        $
��Left=�51      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �52      $	��Top=�6P   $��90��6h   .��53      �� 
 �� Orientation$
 
Horizontal=�6!   .+�54      �� $,��&/Reyuko.App;component/Icons/delete.png��6    $��23��6P   $��23��6\   �� 55      $��Delete��6$   $
��12.5(�62   $
��Left=�6B   $��10,0,0,0q�6]   $��Center=�6o   56      57      �� 58      -   5        $
��Left=�58      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �59      $	��Top=�6P   $	��120��6h   .��5:      �� $
 
Horizontal=�6!   .+�5;      �� $.��(/Reyuko.App;component/Icons/tutorial.png��6    $��23��6R   $��23��6^   �� 5<      $��Play Tutorial��6$   $
��12.5(�69   $
��Left=�6I   $��10,0,0,0q�6d   $��Center=�6v   5=      5>      5?      5@      �� 5B   
   -   5        $��Right=�5B      $��
0,20,120,0q�6-   
������ $��0q�6Z   #��[  5C      $	��Top=�6/   $��60��6G   .��5D      �� $
 
Horizontal=�6   .+�5E      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5F      $
�� New��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5G      5H      �� 5I   
   -   5        $��Right=�5I      $��	0,20,55,0q�6-   
������ $��0q�6Y   #��[  5J      $	��Top=�6/   $��60��6G   .��5K      �� $
 
Horizontal=�6   .+�5L      �� $*��$/Reyuko.App;component/Icons/edit.png��6   $��20��6F   �� 5M      $�� Edit��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5N      5O      &   System.Windows.Controls.DataGrid  5P   
   -   5          Name$ DGDocumentType��5Q      $��
10,77,10,0q�5R         AutoGenerateColumns .  $��0q�5V         CanUserResizeRows .     ColumnHeaderHeight$ 32Q�5X      $
��12.5(�5Y         GridLinesVisibility$
 None=�5Z         HeadersVisibility$ Column=�5[         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�5]         	RowHeight$ 30Q�5^      $	��613��5_      $	��Top=�5`         SelectionMode$ Single=�5a      ��5T      Z� ��5U      Z�   5c      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5d      8   "  6Q   .�5e      ��  � ��$ Center=�6C   �� 5f       � �� �	#FF5684C363   �� 5g       � ��
 �����63   5h      5k         Columns 5l      0  *System.Windows.Controls.DataGridTextColumn  5m      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 5n         CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$
 12.5Q�5s         Header$ Document Type ID��5t      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5o      �� *Id+   HeaderStyle 5u      �� 5v      # [B 6    "  6Y   .�5w      ��  � ��$ Center=�6K   �� 5x       � �� �	#FF5684C36;   �� 5y       � ��
 �����6;   5z         ElementStyle 5|      �� 5}      # [B��6    " ��6N   .�5~      ��  �@��TextAlignment$ Center=�6H   �� 5       � ��$ Center=�6L   5�      5�        5�      $	 150 5�       .   .   . $
 12.5Q�5�      $ Document Type��5�       5�      �� *Type+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6L   5�      5�        5�      $ * 5�       .   .   . $
 12.5Q�5�      $ Description��5�       5�      �� *
Keterangan+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6L   5�      5�      5�      5�      5�      