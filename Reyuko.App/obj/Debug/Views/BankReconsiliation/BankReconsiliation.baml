   M S B A M L   `   `   `  ����  
Reyuko.App<    6Reyuko.App.Views.BankReconsiliation.BankReconsiliation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��Top=�5
      
�������  � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5       .��5"      � .+�5#   
   '  !MaterialDesignThemes.Wpf.PopupBox     ToggleContent$	 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,3,8,0q�6l   $	��Top=�6~   $��40��6�   	   PopupContent.	 5$      �� .+�5%      �� -   5        $
��Left=�5%      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5&      $	��Top=�6P   $	��120��6h   .��5'      �� 
 �� Orientation$
 
Horizontal=�6!   .+�5(      �� $.��(/Reyuko.App;component/Icons/tutorial.png��6    $��23��6R   $��23��6^   �� 5)      $��Play Tutorial��6$   $
��12.5(�69   $
��Left=�6I   $��10,0,0,0q�6d   $��Center=�6v   5*      5+      5,      5-      �� 5.   
   $	��245��5/      $��39��50      $��	10,10,0,0q�51      $
��Left=�52      $	��Top=�53      $��Segoe)�54      $��36(�55      $��Normal$�56      $��Cash Activities��57      $
��Wrap=�58      �� 5:   
   -   5        $��Right=�5:      $��
0,12,378,0q�6-   
������ $��0q�6Z   #��[  5;      $	��Top=�6.   $��80��6F   .��5<      �� $
 
Horizontal=�6   .+�5=      �� $��
 Adjusment��6   $
��12.5(�6.   $��Center=�6>   $��Center=�6[   5>      5?      �� 5A   
   -   5        $��Right=�5A      $��
0,12,243,0q�6-   
������ $��0q�6Z   #��[  5B      $	��Top=�6/   $	��130��6G   .��5C      �� $
 
Horizontal=�6   .+�5D      �� $�� Auto Reconsiliation��6   $
��12.5(�68   $��Center=�6H   $��Center=�6e   5E      5F      �� 5H   
   -   5        $��Right=�5H      $��
0,12,136,0q�6-   
������ $��0q�6Z   #��[  5I      $	��Top=�6/   $	��100��6G   .��5J      �� $
 
Horizontal=�6   .+�5K      �� $�� Reconsiliation��6   $
��12.5(�63   $��Center=�6C   $��Center=�6`   5L      5M      �� 5O   
   -   5        $��Right=�5O      $��	0,12,54,0q�6-   
������ $��0q�6Y   #��[  5P      $	��Top=�60   $��75��6H   .��5Q      �� $
 
Horizontal=�6   .+�5R      �� $-��'/Reyuko.App;component/Icons/refresh.png��6   $��20��6I   �� 5S      $�� Refresh��6   $
��12.5(�6,   $��Center=�6<   $��Center=�6Y   5T      5U      �� 5V   
   $��Account Code��6   $
��12.5(�6'   $
��Left=�67   $��	10,70,0,0q�6R   $	��Top=�6e   �� 5W   
   $��Currenct Account Balance��6   $
��12.5(�63   $
��Left=�6C   $��
567,70,0,0q�6^   $	��Top=�6r   �� 5X   
   $��Currenct Account Date��6   $
��12.5(�60   $
��Left=�6@   $��
270,70,0,0q�6[   $	��Top=�6o   �� 5Y   
   -   5         ��Name$ cbAccountcode��5Y      $
��12.5(�6*   $
��Left=�6:   $��	97,70,0,0q�6U   $��28��6h   $	��Top=�6t   $	��152��6�   (  "System.Windows.Controls.DatePicker  5Z   
   $
��Left=�6   $
��12.5(�60   $��
399,70,0,0q�6@   $	��Top=�6T   $��28��6l   $	��152��6x   �� 5[   
   -   5         ��Name$ txtaccountbalance��5[      $
��12.5(�6-   $
��Left=�6=   $��28��6X   $��
720,70,0,0q�6d    �� TextWrapping$
 Wrap=�6x   $	��Top=�6�   $	��152��6�   6�   &   System.Windows.Controls.DataGrid  5]   
   -   5          Name$ DGReconsiliation��5^      $
��Auto��5_      $	��400��5`      $��10,127,370,203q�5a         AutoGenerateColumns .  $��0q�5e         CanUserResizeRows .     ColumnHeaderHeight$ 32Q�5g      $
��12.5(�5h         GridLinesVisibility$
 None=�5i         HeadersVisibility$ Column=�5j         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�5l         	RowHeight$ 30Q�5m         SelectionMode$ Single=�5n      ��5c      Z� ��5d      Z�   5p      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5q      8   "  6Q   .�5r      ��  � ��$ Center=�6C   �� 5s       � �� �	#FF5684C363   �� 5t       � ��
 �����63   5u      5w         Columns 5x      0  *System.Windows.Controls.DataGridTextColumn  5y      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 450 5z         CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$
 12.5Q�5         Header$    Reconsiliation��5�      1  +System.Windows.Controls.DataGridBoundColumn    Binding  5{      �� *Reconsiliation+!   HeaderStyle! 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      "   ElementStyle" 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�      5�        5�   
   -	   5        $ DGBankReconsiliation��5�      $
��Auto��5�      $	��400��5�      $��
10,317,0,0q�5�       .  $��0q�5�       .  $ 32Q�5�      $
��12.5(�5�      $
 None=�5�      $ Column=�5�       . $ Visible=�5�      $ 30Q�5�      $ Single=�5�      ��5�      Z� ��5�      Z�   5�      ��%�   '        7 �� 5�      8   "  6Q   .�5�      ��  � ��$ Center=�6C   �� 5�       � �� �	#FF5684C363   �� 5�       � ��
 �����63   5�      5�       5�        5�      $	 150 5�       .   .   . $
 12.5Q�5�      $
 Date��5�        5�      �� *Tgl+! 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      " 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 150 5�       .   .   . $
 12.5Q�5�      $ 	Reference��5�        5�      �� *	Reference+! 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      " 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 300 5�       .   .   . $
 12.5Q�5�      $
 Note��5�        5�      �� *Note+! 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      " 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	 120 5�       .   .   . $
 12.5Q�5�      $ Debit��5�        5�      �� *Debit+! 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      " 5      �� 5     # [B��6    " ��6N   .�5     ��  �@��TextAlignment$ Center=�6H   �� 5      � ��$ Center=�6B   5     5       5     $	 120 5      .   .   . $
 12.5Q�5     $ Kredit��5       5	     �� *Kredit+! 5     �� 5     # [B 6    "  6Y   .�5     ��  � ��$
 Left=�6K   �� 5      � �� �	#FF5684C36;   �� 5      � ��
 �����6;   5     " 5     �� 5     # [B��6    " ��6N   .�5     ��  �@��TextAlignment$ Center=�6H   �� 5      � ��$ Center=�6B   5     5       5     $ * 5      .   .   . $
 12.5Q�5#     $ Check��5$       5     �� *Check+! 5%     �� 5&     # [B 6    "  6Y   .�5'     ��  � ��$ Center=�6K   �� 5(      � �� �	#FF5684C36;   �� 5)      � ��
 �����6;   5*     " 5,     �� 5-     # [B��6    " ��6N   .�5.     ��  �@��TextAlignment$ Center=�6H   �� 5/      � ��$ Center=�6B   50     52     54       55  
   -
   5        $ 
DGAnalysis��56     $
��Auto��57     $	��400��58     $��480,127,10,203q�59      .  $��0q�5=      .  $ 32Q�5?     $
��12.5(�5@     $
 None=�5A     $ Column=�5B      . $ Visible=�5D     $ 30Q�5E     $ Single=�5F     ��5;     Z� ��5<     Z�   5H     ��%�   '        7 �� 5I     8   "  6Q   .�5J     ��  � ��$ Center=�6C   �� 5K      � �� �	#FF5684C363   �� 5L      � ��
 �����63   5M     5O      5P       5Q     $	 500 5R      .   .   . $
 12.5Q�5W     $     Analysis��5X       5S     �� *
Analysis+! 5Y     �� 5Z     # [B 6    "  6Y   .�5[     ��  � ��$
 Left=�6K   �� 5\      � �� �	#FF5684C36;   �� 5]      � ��
 �����6;   5^     " 5`     �� 5a     # [B��6    " ��6N   .�5b     ��  �@��TextAlignment$ Center=�6H   �� 5c      � ��$ Center=�6B   5d     5f     5h     5k     5m     