   M S B A M L   `   `   `  ����  
Reyuko.App*    $Reyuko.App.Views.CashActivities.Giro   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $	��350��5      $	��300��5        � WindowStyle$
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
��Left=�5,      $	��Top=�5-      $��Segoe)�5.      $��36(�5/      $��Normal$�50      $
��Data��51      $
��Wrap=�52      �� 53   
   $��	Cheque No��6   $
��Left=�6$   $��	10,80,0,0q�6?   $	��Top=�6R   �� 54   
   $��Cheque Account No��6   $
��Left=�6,   $��
10,130,0,0q�6G   $	��Top=�6[   �� 55   
   $��	Bank Name��6   $
��Left=�6$   $��
10,180,0,0q�6?   $	��Top=�6S   �� 56   
   $��Due Date��6   $
��Left=�6#   $��
10,230,0,0q�6>   $	��Top=�6R   �� 57   
   -   5         ��Name$ txtchequeno��57      $
��Left=�6'   $��28��6B   $��
170,80,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��150��6�   �� 58   
   -   5        $ txtchequeaccountno��58      $
��Left=�6.   $��28��6I   $��170,130,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��150��6�   �� 59   
   -   5        $ txtbank��59      $
��Left=�6#   $��28��6>   $��170,180,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��150��6�   (  "System.Windows.Controls.DatePicker  5:   
   -   5          Name$ tanggalgiro��5:      $
��12.5(�6*   $
��Left=�6:   $��28��6U   $��170,230,0,0q�6a   $	��Top=�6v   $	��150��6�   �� 5;   
   -   5        $��Right=�5;      $��
0,18,100,0q�6-   
������ $��0q�6Z   #��[  5<      $	��Top=�6/   $��60��6G   .��5=      ��  �� Orientation$ 
Horizontal=�6   .+�5>      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5?      $�� Save��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5@      5A      �� 5B   
   -   5        $��Right=�5B      $��	0,18,20,0q�6-   
������ $��0q�6Y   #��[  5C      $	��Top=�6/   $��70��6G   .��5D      �� $ 
Horizontal=�6   .+�5E      �� $+��%/Reyuko.App;component/Icons/close.png��6   $��20��6G   �� 5F      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5G      5H      5I      5J      