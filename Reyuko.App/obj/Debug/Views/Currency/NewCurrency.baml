   M S B A M L   `   `   `  ����  
Reyuko.App+    %Reyuko.App.Views.Currency.NewCurrency   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $	��500��5      $	��600��5        � WindowStyle$
  None=�5	      $��14(�5
       � Icon$. (/Reyuko.App;component/Icons/currency.png��5       � 
ResizeMode$ NoResize=�5      $��1q�5       � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�5      $��Center=�5      $��Center=�63    � 	Resources 5         MyButton �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5      
 5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5       5"      5#      5$      .��5'      � .+�5(   
   �� $	��178��5)      $��42��5*      $��	10,10,0,0q�5+      $
��Left=�5,      $	��Top=�5-      $��Segoe)�5.      $��36(�5/      $��Normal$�50      $��Currency��51      $
��Wrap=�52      &   System.Windows.Controls.DataGrid  54   
   -   5          Name$ DGCurrencyDetail��55      $��
0,57,0,-12q�56      $��0q�59         ColumnHeaderHeight$ 32Q�5:      $
��12.5(�5;         HeadersVisibility$ Column=�5<         	RowHeight$ 30Q�5=         SelectionMode$ Single=�5>         AutoGenerateColumns .     CanUserAddRows .  ��57      Z� ��58      Z�  5B      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5C      8   "  6Q   .�5D      ��  � ��$ Center=�6C   �� 5E       � �� �#cdcccc63   �� 5F       � ��
 �   �63   5G      5H         Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5K      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 5L         CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$
 12.5Q�5Q         Header$  Code��5R         
IsReadOnly .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 5M      �� *KodeMataUang+   HeaderStyle 5T      �� 5U      # [B 6    "  6Y   .�5V      ��  � ��$ Center=�6K   �� 5W       � �� �#cdcccc6;   �� 5X       � ��
 �   �6;   5Y         ElementStyle 5[      �� 5\      # [B��6    " ��6N   .�5]      ��  �@��TextAlignment$ Center=�6H   �� 5^       � ��$ Center=�6B   5_      5a        5b      $	 120 5c       .   .   . $
 12.5Q�5h      $
 Name��5i       .   5d      �� *NamaMataUang+ 5k      �� 5l      # [B 6    "  6Y   .�5m      ��  � ��$ Center=�6K   �� 5n       � �� �#cdcccc6;   �� 5o       � ��
 �   �6;   5p       5r      �� 5s      # [B��6    " ��6N   .�5t      ��  �@��TextAlignment$ Center=�6H   �� 5u       � ��$ Center=�6B   5v      5x        5y      $	 100 5z       .   .   . $
 12.5Q�5      $ Symbol��5�       .   5{      �� *SimbolMataUang+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �#cdcccc6;   �� 5�       � ��
 �   �6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�      4  .System.Windows.Controls.DataGridCheckBoxColumn  5�      $ Aktif ?��6)       IsThreeState  .  6N   �� *CheckBoxAktif+5�      �� 5�   
   -   5        $��Right=�5�      $��
0,18,100,0q�6-   
������ $��0q�6Z   #��[  5�      $	��Top=�6/   $��60��6G   .��5�      �� ! �� Orientation$! 
Horizontal=�6   .+�5�      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5�      $
�� Add��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5�      5�      �� 5�   
   -   5        $��Right=�5�      $��	0,18,20,0q�6-   
������ $��0q�6Y   #��[  5�      $	��Top=�6/   $��70��6G   .��5�      �� $! 
Horizontal=�6   .+�5�      �� $,��&/Reyuko.App;component/Icons/close2.png��6   $��20��6H   �� 5�      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5�      5�      5�      5�      