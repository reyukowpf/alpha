   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5      M IRichTextBoxToolBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS<clr-namespace:RichTextBoxToolBar;assembly=RichTextBoxToolBarRichTextBoxToolBar 5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5	      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5
   	    
Reyuko.App)   #Reyuko.App.Views.Sales.InternalNote   5      U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^	 ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      	 R
 NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml    
 5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit    
 5      @d2http://schemas.microsoft.com/expression/blend/2008    
 5      Lrtb<clr-namespace:RichTextBoxToolBar;assembly=RichTextBoxToolBar    
 5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006    
 5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      MComponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase  5	      3System&clr-namespace:System;assembly=mscorlib  5
   	   $	��730��5        � WindowStyle$
  None=�5      $��14(�5       � 
ResizeMode$ NoResize=�5       � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�5      
�������$	��Top=�5       � 	Resources 5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType	 �� Triggers
 P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5      	 5      P� 5       
 �@J�IsMouseOver . . �5!   "   ��  �@J�Opacity$	 0.8Q�6<   5"      5$      5&      5'      5(      .��5+      � .+�5,   
   �� $	��221��5-      $��39��5.      $��10,2,0,0q�5/      $
��Left=�50      $	��Top=�51      $��Segoe)�52      $��36(�53      $��Normal$�54      $��Internal Note��55      $
��Wrap=�56      �� 58   
   -   5         ��Name$ Print��59      $��39��5:      $��24��5;      $��	0,10,93,0q�5<      $
��12.5(�5=      $��Right=�5>      $	��Top=�5?      
������ $��0q�5A      #��[  5B      $��Print��6B   �� 5D   
   -   5        $ Cancel��5E      $��51��5F      $��24��5G      $��	0,10,20,0q�5H      $
��12.5(�5I      $��Right=�5J      $	��Top=�5K      
������ $��0q�5M      #��[  5N      $��Cancel��6D   �� 5P   
   .+�5Q      �� -   5        $
 Save��5R      $��39��5S      $��24��5T      $��
0,10,160,0q�5U      $
��12.5(�5V      $��Right=�5W      $	��Top=�5X      
������ $��0q�5Z      #��[  5[      $
��Save��6/   6>   5\      �� 5]   
   $��Customer / Id��6   $
��12.5(�6(   $
��Left=�68   $��	10,40,0,0q�6S   $	��Top=�6f   $��26��6~   �� 5^   
   $��	Note Type��6   $
��12.5(�6$   $
��Left=�64   $��
190,40,0,0q�6O   $	��Top=�6c   $��26��6{   �� 5_   
   $��Reference Number��6   $
��12.5(�6+   $
��Left=�6;   $��
360,40,0,0q�6V   $	��Top=�6j   $��26��6�   �� 5`   
   $��	Note Date��6   $
��12.5(�6$   $
��Left=�64   $��
530,40,0,0q�6O   $	��Top=�6c   �� 5a   
   $��
Note Title��6   $
��12.5(�6%   $
��Left=�65   $��
10,100,0,0q�6P   $	��Top=�6d   �� 5b   
   $��Reminder Date��6   $
��12.5(�6(   $
��Left=�68   $��360,100,0,0q�6S   $	��Top=�6h   �� 5c   
   
���   �$��1q�5d      $
��Left=�5e      $	��Top=�5f       �� CornerRadius$ 0��5g      $��	10,64,0,0q�6*   ._�5h      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��160��6h   .+�5i      -   'System.Windows.Controls.AutoCompleteBox  -   5          Name$ 
srcustomer��5i   +   $
��12.5(�6?   $��Segoe)�6O   
������ $��Center=�6|   $��28��6�   $	��130��6�   $��
-1,-1,0,-1q�6�   $��Center=�6�      ValueMemberPath$ 
NamaProduk��6�      ItemTemplate 5j      �� 5k      .R�5l      ��  �� Orientation$ 
Horizontal=�6)   .+�5m   "   �� ��6,   �� *NamaPelanggan+5n      5o      5q      �� 5r      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $
��Left=�6j   $��Center=�6�   $��5,0,0,0q�6�   5s      5t      �� 5u   
   -   5         ��Name$ txtRefereneNumber��5u      $
��12.5(�6-   $
��Left=�6=   $��28��6X   $��
360,64,0,0q�6d    �� TextWrapping$
 Wrap=�6x   $	��Top=�6�   $	��152��6�   6�   (  "System.Windows.Controls.DatePicker  5v   
   -   5          Name$ dtNote��5v      $
��Left=�6%   $
��12.5(�6@   $��28��6P   $��
530,64,0,0q�6\   $	��Top=�6p   $	��150��6�     5w   
   -   5        $ 
dtReminder��5w      $
��Left=�6)   $
��12.5(�6D   $��28��6T   $��360,125,0,0q�6`   $	��Top=�6u   $	��150��6�   �� 5x   
   -   5        $ txtNoteTitle��5x      $
��12.5(�6(   $
��Left=�68   $��28��6S   $��
10,125,0,0q�6_   $
 Wrap=�6s   $	��Top=�6�   $	��330��6�   6�   �� 5y   
   -	   5        $ txtNoteType��5y      $
��12.5(�6'   $
��Left=�67   $��28��6R   $��
190,64,0,0q�6^   $
 Wrap=�6r   $	��Top=�6�   $	��152��6�   6�   ]� 5z   
   ��. $��	0,171,0,0q�6)   .+�5{      `� $	��Top=�6   .�5|      +  %RichTextBoxToolBar.RichTextBoxToolBar  -
   5          Name$ _rttb1��5|   )   5}      � 5~      .+�5      �� -   5         ��Name$
 _rtb��5      $��Stretch=�5�      $��Stretch=�5�      ��.  $��Hidden=�5�      $��Hidden=�5�       �� 	IsEnabled .  �� AcceptsReturn .  �� 
AcceptsTab . 5�      �� 5�      $��Stretch=�5�      $��Stretch=�5�      ��.  $��Hidden=�5�      $��Hidden=�5�       .  .  . 5�      �� 5�      $ 
Horizontal=�6   5�      5�      5�      5�      5�      