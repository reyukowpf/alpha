   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5       
Reyuko.App&    Reyuko.App.Views.Note.DocumentNo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      $	��420��5	        � WindowStyle$
  None=�5
      $��14(�5      
������� � WindowStartupLocation$ CenterScreen=�5      
���   �$��Center=�5      $��Center=�63   $��1q�6N    � 
ResizeMode$ NoResize=�6b    � 	Resources 5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers	 P� Property
 P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5      	 �@J�IsMouseOver
 . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5!      5"      5#      .��5%      � .+�5&   
   �� $	��178��5'      $��45��5(      $��	30,10,0,0q�5)      $
��Left=�5*      $	��Top=�5+      $��Segoe)�5,      $��36(�5-      $��Normal$�5.      $��Document��5/      $
��Wrap=�50      �� 51   
   -   5        $��Right=�51      $��
0,12,100,0q�6-   
������ $��0q�6Z   #��[  52      $	��Top=�60   $��60��6H   .��53      ��  �� Orientation$ 
Horizontal=�6   .+�54      �� $*��$/Reyuko.App;component/Icons/save.png��6   $��20��6F   �� 55      $�� Save��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   56      57      �� 59   
   -   5        $��Right=�59      $��	0,12,20,0q�6-   
������ $��0q�6Y   #��[  5:      $	��Top=�60   $��70��6H   .��5;      �� $ 
Horizontal=�6   .+�5<      �� $+��%/Reyuko.App;component/Icons/close.png��6   $��20��6G   �� 5=      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5>      5?      �� 5@   
   $��Document Type��6   $
��12.5(�6(   $
��Left=�68   $��	30,68,0,0q�6S   $	��Top=�6f   �� 5A   
   $
��Date��6   $
��12.5(�6   $
��Left=�6/   $��
30,108,0,0q�6J   $	��Top=�6^   �� 5B   
   $��Document No��6   $
��12.5(�6&   $
��Left=�66   $��
30,148,0,0q�6Q   $	��Top=�6e   �� 5C   
   $��Customer / ID��6   $
��12.5(�6(   $
��Left=�68   $��
30,188,0,0q�6S   $	��Top=�6g   �� 5D   
   $��Remarks��6   $
��12.5(�6"   $
��Left=�62   $��
30,228,0,0q�6M   $	��Top=�6a   �� 5E   
   $��Interest��6   $
��12.5(�6#   $
��Left=�63   $��
30,288,0,0q�6N   $	��Top=�6b   �� 5F   
   $��Uploaded File��6   $
��12.5(�6(   $
��Left=�68   $��
30,328,0,0q�6S   $	��Top=�6g   �� 5G   
   $��From Camera��6   $
��12.5(�6&   $
��Left=�66   $��
30,378,0,0q�6Q   $	��Top=�6e   �� 5H   
   -   5         ��Name$ cbDocumentTipe��5H      $
��Left=�6+   $
��12.5(�6F   $��28��6V   $��
170,68,0,0q�6b   $	��Top=�6v   $	��170��6�   �� 5I   
   -   5         ��Name$ txtDocumentNo��5I      $
��Left=�6)   $
��12.5(�6D   $��28��6T   $��170,148,0,0q�6`    �� TextWrapping$
 Wrap=�6u   $	��Top=�6�   $	��170��6�   6�   (  "System.Windows.Controls.DatePicker  5J   
   -   5          Name$
 date��5J      $
��Left=�6#   $��170,108,0,0q�6>   $
��12.5(�6S   $	��Top=�6c   $	��170��6{   �� 5K   
   
���   �$��1q�5L      $
��Left=�5M      $	��Top=�5N       �� CornerRadius$ 0��5O      $��170,188,0,0q�6*   ._�5P      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��170��6h   .+�5Q      -   'System.Windows.Controls.AutoCompleteBox  -   5          Name$ 
srcustomer��5Q   +   $
��12.5(�6?   $��Segoe)�6O   
������ $��Center=�6|   $��28��6�   $	��140��6�   $��
-1,-1,0,-1q�6�   $��Center=�6�      ValueMemberPath$ 
NamaProduk��6�      ItemTemplate 5R      �� 5S      .R�5T      �� $ 
Horizontal=�6)   .+�5U   "   �� ��6,   �� *NamaPelanggan+5V      5W      5Y      �� 5Z      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $
��Left=�6j   $��Center=�6�   $��5,0,0,0q�6�   5[      5\      �� 5]   
   -   5        $ txtDescription��5]      $
��Left=�6*   $��80��6E   $
��12.5(�6Q   $��170,228,0,0q�6a   $
 Wrap=�6v   $	��Top=�6�   $	��170��6�   6�   �� 5^   
   $
��Left=�6   $��50��6+   $��170,318,0,0q�67   $	��Top=�6L   $��50��6d   �� 5_   
   $
��Left=�6   $��50��6+   $��230,318,0,0q�67   $	��Top=�6L   $��50��6d   �� 5`   
   $
��Left=�6   $��50��6+   $��290,318,0,0q�67   $	��Top=�6L   $��50��6d   �� 5a   
   $
��Left=�6   $��50��6+   $��350,318,0,0q�67   $	��Top=�6L   $��50��6d   �� 5b   
   -   5         ��Name$ kamera��5b      $
��Left=�6    $��50��6;   $��170,388,0,0q�6G   $	��Top=�6\   $��70��6t   5d      5f      