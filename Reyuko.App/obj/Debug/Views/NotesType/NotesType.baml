   M S B A M L   `   `   `  ����  
Reyuko.App*    $Reyuko.App.Views.NotesType.NotesType   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      
�������$	��Top=�5        � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5      .��5!      � $��0,0,0,0q�6   .+�5"   
   �� $	��273��5#      $��52��5$      $��	30,20,0,0q�5%      $
��Left=�5&      $	��Top=�5'      $��Segoe)�5(      $��36(�5)      $��Normal$�5*      $��
Notes Type��5+      $
��Wrap=�5,      '  !MaterialDesignThemes.Wpf.PopupBox  5-   
      ToggleContent$	 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,10,8,0q�6l   $	��Top=�6   $��40��6�   	   PopupContent.	 5.      �� .+�5/      �� -   5        $
��Left=�5/      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �50      $	��Top=�6P   $��90��6h   .��51      �� 
 �� Orientation$
 
Horizontal=�6!   .+�52      �� $,��&/Reyuko.App;component/Icons/delete.png��6    $��23��6P   $��23��6\   �� 53      $��Delete��6$   $
��12.5(�62   $
��Left=�6B   $��10,0,0,0q�6]   $��Center=�6o   54      55      �� 56      -   5        $
��Left=�56      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �57      $	��Top=�6P   $	��120��6h   .��58      �� $
 
Horizontal=�6!   .+�59      �� $.��(/Reyuko.App;component/Icons/tutorial.png��6    $��23��6R   $��23��6^   �� 5:      $��Play Tutorial��6$   $
��12.5(�69   $
��Left=�6I   $��10,0,0,0q�6d   $��Center=�6v   5;      5<      5=      5>      �� 5?   
   -   5        $��Right=�5?      $��
0,20,120,0q�6-   
������ $��0q�6Z   #��[  5@      $	��Top=�6/   $��60��6G   .��5A      �� $
 
Horizontal=�6   .+�5B      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5C      $
�� New��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5D      5E      �� 5F   
   -   5        $��Right=�5F      $��	0,20,55,0q�6-   
������ $��0q�6Y   #��[  5G      $	��Top=�6/   $��60��6G   .��5H      �� $
 
Horizontal=�6   .+�5I      �� $*��$/Reyuko.App;component/Icons/edit.png��6   $��20��6F   �� 5J      $�� Edit��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5K      5L      &   System.Windows.Controls.DataGrid  5M   
   -   5          Name$ DGNotesType��5N      $
��Auto��5O      $	��400��5P      $��30,77,0,-10q�5Q         AutoGenerateColumns .  $��0q�5U         CanUserResizeRows .     ColumnHeaderHeight$ 32Q�5W      $
��12.5(�5X         GridLinesVisibility$
 None=�5Y         HeadersVisibility$ Column=�5Z         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�5\         	RowHeight$ 30Q�5]         SelectionMode$ Single=�5^      ��5S      Z� ��5T      Z�   5_      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5`      8   "  6Q   .�5a      ��  � ��$ Center=�6C   �� 5b       � �� �	#FF5684C363   �� 5c       � ��
 �����63   5d      5g         Columns 5h      0  *System.Windows.Controls.DataGridTextColumn  5i      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 5j         CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$
 12.5Q�5o         Header$ Notes Type ID��5p      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5k      �� *Id+   HeaderStyle 5q      �� 5r      # [B 6    "  6Y   .�5s      ��  � ��$ Center=�6K   �� 5t       � �� �	#FF5684C36;   �� 5u       � ��
 �����6;   5v         ElementStyle 5x      �� 5y      # [B��6    " ��6N   .�5z      ��  �@��TextAlignment$ Center=�6H   �� 5{       � ��$ Center=�6L   5|      5~        5      $	 150 5�       .   .   . $
 12.5Q�5�      $ 
Notes Type��5�       5�      �� *Type+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6L   5�      5�        5�      $ * 5�       .   .   . $
 12.5Q�5�      $ Description��5�       5�      �� *
Keterangan+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6L   5�      5�      5�      5�      5�      