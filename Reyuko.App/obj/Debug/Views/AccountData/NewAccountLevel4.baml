   M S B A M L   `   `   `  ����  
Reyuko.App2    ,Reyuko.App.Views.AccountData.NewAccounLevel4   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $	��350��5      $	��490��5        � WindowStyle$
  None=�5	      $��14(�5
       � 
ResizeMode$ NoResize=�5       � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�5      
�������$��Center=�5      $��Center=�63    � 	Resources 5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType	 �� Triggers
 P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5      	 5      P� 5      
 �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5!      5"      5#      .��5$      � .+�5&   
   �� -   5        $��Right=�5&      $��	0,12,97,0q�6-   
������ $��0q�6Y   #��[  5'      $	��Top=�6/   $��60��6G   .��5(      ��  �� Orientation$ 
Horizontal=�6   .+�5)      �� $*��$/Reyuko.App;component/Icons/save.png��6   $��20��6F   �� 5*      $�� Save��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5+      5,      �� 5.   
   -   5        $��Right=�5.      $��	0,12,20,0q�6-   
������ $��0q�6Y   #��[  5/      $	��Top=�6.   $��70��6F   .��50      �� $ 
Horizontal=�6   .+�51      �� $+��%/Reyuko.App;component/Icons/close.png��6   $��20��6G   �� 52      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   53      54      �� 56   
   $��Account Name��6   $
��12.5(�6'   $
��Left=�67   $��	50,54,0,0q�6R   $	��Top=�6e   �� 57   
   $��Account Code��6   $
��12.5(�6'   $
��Left=�67   $��
260,54,0,0q�6R   $	��Top=�6f   �� 58   
   $��
Department��6   $
��12.5(�6%   $
��Left=�65   $��
50,129,0,0q�6P   $	��Top=�6d   �� 59   
   $��Currency��6   $
��12.5(�6#   $
��Left=�63   $��260,129,0,0q�6N   $	��Top=�6c   �� 5:   
   -   5         ��Name$ txtAccountName��5:      $
��12.5(�6*   $
��Left=�6:   $��28��6U   $��	50,84,0,0q�6a    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��170��6�   6�   �� 5;   
   -   5        $ txtAccountcode��5;      $
��12.5(�6*   $
��Left=�6:   $��28��6U   $��
260,84,0,0q�6a   $
 Wrap=�6u   $	��Top=�6�   $	��120��6�   6�   �� 5<   
   -   5         ��Name$ cbDepartment��5<      $
��12.5(�6)   $
��Left=�69   $��28��6T   $��
50,159,0,0q�6`   $	��Top=�6t   $	��170��6�   6�   �� 5=   
   -   5        $ 
cbCurrency��5=      $
��12.5(�6'   $
��Left=�67   $��28��6R   $��260,159,0,0q�6^   $	��Top=�6s   $	��120��6�   6�   	� 5>   
   -   5         	�Name$ 
rdStandard��5>      $��Standard��6*   $
��12.5(�6=   $
��Left=�6M   $��
50,204,0,0q�6h   $	��Top=�6|   	� 5?   
   -   5        $ 
rdCashBank��5?      $��Cash / Bank��6*   $
��12.5(�6@   $
��Left=�6P   $��
50,234,0,0q�6k   $	��Top=�6   	� 5@   
   -	   5        $ 
rdDebtLoan��5@      $��Debt / Loan��6*   $
��12.5(�6@   $
��Left=�6P   $��
50,264,0,0q�6k   $	��Top=�6   �� 5A   
   -
   5         ��Name$ chkNotActive��5A      $��
Not Active��6)   $
��12.5(�6>   $
��Left=�6N   $��180,204,0,0q�6i   $	��Top=�6~   �� 5B   
   -   5        $ chkPasswordLock��5B      $��Password Lock��6,   $
��12.5(�6D   $
��Left=�6T   $��180,234,0,0q�6o   $	��Top=�6�   �� 5C   
   $	��195��5D      $��37��5E      $��	50,10,0,0q�5F      $
��Left=�5G      $	��Top=�5H      $��Segoe)�5I      $��36(�5J      $��Normal$�5K      $��
Account L4��5L      $
��Wrap=�5M      5O      5Q      