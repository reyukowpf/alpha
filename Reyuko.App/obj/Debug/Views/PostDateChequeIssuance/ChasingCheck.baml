   M S B A M L   `   `   `  ����  
Reyuko.App:    4Reyuko.App.Views.PostDateChequeIssuance.ChasingCheck   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $	��350��5      $	��550��5      $��14(�5	        � WindowStyle$
  None=�5
       � 
ResizeMode$ NoResize=�5      $��1q�5       � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�5      
�������$��Center=�5      $��Center=�63    � 	Resources 5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType	 �� Triggers
 P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5      	 5      P� 5      
 �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5       5"      5#      5$      .��5&      � .+�5'   
   �� $	��253��5(      $��50��5)      $��49,9,0,0q�5*      $
��Left=�5+      $	��Top=�5,      $��Segoe)�5-      $��36(�5.      $��Normal$�5/      $��Chasing Check��50      $
��Wrap=�51      �� 53   
   -   5        $��Right=�53      $��
0,12,115,0q�6-   
������ $��0q�6Z   #��[  54      $	��Top=�6.   $��60��6F   .��55      ��  �� Orientation$ 
Horizontal=�6   .+�56      �� $*��$/Reyuko.App;component/Icons/save.png��6   $��20��6F   �� 57      $�� Save��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   58      59      �� 5:   
   -   5        $��Right=�5:      $��	0,12,40,0q�6-   
������ $��0q�6Y   #��[  5;      $	��Top=�6/   $��70��6G   .��5<      �� $ 
Horizontal=�6   .+�5=      �� $+��%/Reyuko.App;component/Icons/close.png��6   $��20��6G   �� 5>      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5?      5@      �� 5B   
   $��	Cheque No��6   $
��Left=�6$   $
��12.5(�6?   $��	50,64,0,0q�6O   $	��Top=�6b   �� 5C   
   $��Cheque Account No��6   $
��Left=�6,   $
��12.5(�6G   $��
49,104,0,0q�6W   $	��Top=�6k   �� 5D   
   $��	Bank Name��6   $
��Left=�6$   $
��12.5(�6?   $��
49,144,0,0q�6O   $	��Top=�6c   �� 5E   
   $��Due Date��6   $
��Left=�6#   $
��12.5(�6>   $��
49,184,0,0q�6N   $	��Top=�6b   �� 5F   
   $��Cash / Bank��6   $
��Left=�6&   $
��12.5(�6A   $��
49,224,0,0q�6Q   $	��Top=�6e   �� 5G   
   -   5         ��Name$ txtChequeNo��5G      $
��Left=�6'   $��28��6B   $
��12.5(�6N   $��
200,67,0,0q�6^    �� TextWrapping$
 Wrap=�6r   $	��Top=�6�   $	��170��6�   �� 5H   
   -   5        $ txtChequeAccountNo��5H      $
��Left=�6.   $��28��6I   $
��12.5(�6U   $��200,107,0,0q�6e   $
 Wrap=�6z   $	��Top=�6�   $	��170��6�   �� 5I   
   -   5        $ txtBankName��5I      $
��Left=�6'   $��28��6B   $
��12.5(�6N   $��200,147,0,0q�6^   $
 Wrap=�6s   $	��Top=�6�   $	��170��6�   (  "System.Windows.Controls.DatePicker  5J   
   -   5          Name$ tanggal��5J      $
��Left=�6&   $��28��6A   $
��12.5(�6M   $��200,184,0,0q�6]   $	��Top=�6r   $	��170��6�   �� 5K   
   -   5         ��Name$ cbCash��5K      $
��Left=�6#   $��28��6>   $
��12.5(�6J   $��200,224,0,0q�6Z   $	��Top=�6o   $	��170��6�   5L      5N      