   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5       
Reyuko.App/   )Reyuko.App.Views.PaymentTerm.PaymentTerms   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V	 RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 5      
�������$	��Top=�5        � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5       .��5"      � .+�5#   
   ' 	 !MaterialDesignThemes.Wpf.PopupBox     ToggleContent$	 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,3,8,0q�6l   $	��Top=�6~   $��40��6�   	   PopupContent.	 5$      �� .+�5%      �� -   5        $
��Left=�5%      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5&      $	��Top=�6P   $��82��6h   .��5'      �� 
 �� Orientation$
 
Horizontal=�6!   .+�5(      �� $,��&/Reyuko.App;component/Icons/delete.png��6    $��23��6P   $��23��6\   �� 5)      $��Delete��6$   $
��12.5(�62   $
��Left=�6B   $��10,0,0,0q�6]   $��Center=�6o   5*      5+      �� 5,      -   5        $
��Left=�5,      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5-      $	��Top=�6P   $	��130��6h   .��5.      �� $
 
Horizontal=�6!   .+�5/      �� $-��'/Reyuko.App;component/Icons/payment.png��6    $��22��6Q   $��22��6]   $��3,0,0,0q�6h   �� 50      $��View Inactived��6$   $
��12.5(�6:   $
��Left=�6J   $��10,0,0,0q�6e   $��Center=�6w   51      52      �� 53      -   5        $
��Left=�53      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �54      $	��Top=�6P   $	��116��6h   .��55      �� $
 
Horizontal=�6!   .+�56      �� $.��(/Reyuko.App;component/Icons/tutorial.png��6    $��23��6R   $��23��6^   $��3,0,0,0q�6i   �� 57      $��Play Tutorial��6$   $
��12.5(�69   $
��Left=�6I   $��10,0,0,0q�6d   $��Center=�6v   58      59      5:      5;      �� 5=   
   $	��300��5>      $��45��5?      $��	10,10,0,0q�5@      $
��Left=�5A      $	��Top=�5B      $��Segoe)�5C      $��36(�5D      $��Normal$�5E      $��Payment Terms��5F      $
��Wrap=�5G      �� 5I   
   -   5        $��Right=�5I      $��
0,12,180,0q�6-   
������ $��0q�6Z   #��[  5J      $	��Top=�6/   $��60��6G   .��5K      �� $
 
Horizontal=�6   .+�5L      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5M      $
�� New��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5N      5O      �� 5Q   
   -   5        $��Right=�5Q      $��
0,12,120,0q�6-   
������ $��0q�6Z   #��[  5R      $	��Top=�6/   $��60��6G   .��5S      �� $
 
Horizontal=�6   .+�5T      �� $*��$/Reyuko.App;component/Icons/edit.png��6   $��20��6F   �� 5U      $�� Edit��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5V      5W      �� 5Y   
   -   5        $��Right=�5Y      $��	0,12,40,0q�6-   
������ $��0q�6Y   #��[  5Z      $	��Top=�6/   $��85��6G   .��5[      �� $
 
Horizontal=�6   .+�5\      �� $-��'/Reyuko.App;component/Icons/refresh.png��6   $��20��6I   �� 5]      $�� Refresh��6   $
��12.5(�6,   $��Center=�6<   $��Center=�6Y   5^      5_      �� 5a   
   $��Scheme Name��6   $
��12.5(�6&   $
��Left=�66   $��	10,60,0,0q�6Q   $	��Top=�6d   $��26��6|   �� 5b   
   $��	Recurring��6   $
��12.5(�6$   $
��Left=�64   $��
177,60,0,0q�6O   $	��Top=�6c   $��26��6{   �� 5c   
   
���   �$��1q�5d      $
��Left=�5e      $	��Top=�5f       �� CornerRadius$ 0��5g      $��	10,85,0,0q�6*   ._�5h      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��150��6h   .+�5i      -   'System.Windows.Controls.AutoCompleteBox  -   5          Name$ 
srcustomer��5i   +   $
��12.5(�6?   $��Segoe)�6O   
������ $��Center=�6|   $��28��6�   $	��120��6�   $��
-1,-1,0,-1q�6�   $��Center=�6�      ValueMemberPath$ 
NamaProduk��6�      ItemTemplate 5j      �� 5k      .R�5l      �� $
 
Horizontal=�6)   .+�5m   "   �� ��6,   �� *NamaPelanggan+5n      5o      5q      �� 5r      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $
��Left=�6j   $��Center=�6�   $��5,0,0,0q�6�   5s      5t      �� 5u   
   -   5         ��Name$ cbAnnuality��5u      $
��12.5(�6(   $
��Left=�68   $��
177,85,0,0q�6S   $��28��6g   $	��Top=�6s   $	��152��6�   &   System.Windows.Controls.DataGrid  5v   
   -	   5          Name$ DGSPaymentTerm��5w      $
��Auto��5x      $	��400��5y      $��
10,127,0,0q�5z         AutoGenerateColumns .  $��0q�5~         CanUserResizeRows .     ColumnHeaderHeight$ 32Q�5�      $
��12.5(�5�         GridLinesVisibility$
 None=�5�         HeadersVisibility$ Column=�5�         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�5�         	RowHeight$ 30Q�5�         SelectionMode$ Single=�5�      ��5|      Z� ��5}      Z�   5�      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5�      8   "  6Q   .�5�      ��  � ��$ Center=�6C   �� 5�       � �� �	#FF5684C363   �� 5�       � ��
 �����63   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5�         CanUserReorder .     CanUserResize .     CanUserSort .     FontSize$
  12.5Q�5�      !   Header$!   Scheme Name��5�      1  +System.Windows.Controls.DataGridBoundColumn"   Binding" 5�      �� *	NamaSkema+#   HeaderStyle# 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      $   ElementStyle$ 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$
 Left=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 100 5�       .   .   . $
  12.5Q�5�      $! Grace Period��5�      " 5�      �� *GracePeriod+# 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      $ 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 120 5�       .   .   . $
  12.5Q�5�      $! Down Payment��5�      " 5�      �� *
UangMuka+# 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      $ 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 100 5�       .   .   . $
  12.5Q�5�      $! Anuality��5�      " 5�      �� *Annual+# 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      $ 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 100 5�       .   .   . $
  12.5Q�5�      $! Duration��5�      " 5�      �� *TermPembayaran+# 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      $ 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 100 5       .   .   . $
  12.5Q�5     $! Interest��5     " 5     �� *BungaPerBulan+# 5     �� 5     # [B 6    "  6Y   .�5	     ��  � ��$ Center=�6K   �� 5
      � �� �	#FF5684C36;   �� 5      � ��
 �����6;   5     $ 5     �� 5     # [B��6    " ��6N   .�5     ��  �@��TextAlignment$ Center=�6H   �� 5      � ��$ Center=�6B   5     5     5     5     5     