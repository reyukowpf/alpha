   M S B A M L   `   `   `  ����M  IRichTextBoxToolBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS<clr-namespace:RichTextBoxToolBar;assembly=RichTextBoxToolBarRichTextBoxToolBar  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	      p lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls 5
       
Reyuko.App+   %Reyuko.App.Views.Note.NewInternalNote   5      U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^	 ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      	 R
 NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml    
 5      @d2http://schemas.microsoft.com/expression/blend/2008    
 5      Lrtb<clr-namespace:RichTextBoxToolBar;assembly=RichTextBoxToolBar    
 5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006    
 5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      MComponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase  5      3System&clr-namespace:System;assembly=mscorlib  5	      cControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit  5
      $��14(�5      
�������$
��Left=�5      $	��Top=�61   $
��1040��6I   $	��700��6V     � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5       5"      5#      5$      .��5'      � .+�5)   
   �� $	��221��5*      $��47��5+      $��	10,10,0,0q�5,      $
��Left=�5-      $	��Top=�5.      $��Segoe)�5/      $��36(�50      $��Normal$�51      $��Internal Note��52      $
��Wrap=�53      �� 56   
   -   5        $��Right=�56      $��
0,12,170,0q�6-   
������ $��0q�6Z   #��[  57      $	��Top=�60   $��60��6H   .��58      ��  �� Orientation$ 
Horizontal=�6   .+�59      �� $*��$/Reyuko.App;component/Icons/save.png��6   $��20��6F   �� 5:      $�� Save��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5;      5<      �� 5>   
   -   5        $��Right=�5>      $��
0,12,100,0q�6-   
������ $��0q�6Z   #��[  5?      $	��Top=�60   $��60��6H   .��5@      �� $ 
Horizontal=�6   .+�5A      �� $+��%/Reyuko.App;component/Icons/print.png��6   $��20��6G   �� 5B      $�� Print��6   $
��12.5(�6*   $��Center=�6:   $��Center=�6W   5C      5D      �� 5F   
   -   5        $��Right=�5F      $��	0,12,20,0q�6-   
������ $��0q�6Y   #��[  5G      $	��Top=�60   $��70��6H   .��5H      �� $ 
Horizontal=�6   .+�5I      �� $+��%/Reyuko.App;component/Icons/close.png��6   $��20��6G   �� 5J      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5K      5L      �� 5N   
   $
��Left=�6   $��
167,88,0,0q�6,   
������ $��0q�6Y   #��[  5O      $	��Top=�6.   $��20��6F   .��5P      �� $ 
Horizontal=�6   .+�5Q      �� $0��*/Reyuko.App;component/Icons/black_plus.png��6   $��15��6L   5R      5S      �� 5T   
   -   5        $
��Left=�5T      $��690,148,0,0q�6,   
������ $��0q�6Z   #��[  5U      $	��Top=�6/   $��20��6G   .��5V      �� $ 
Horizontal=�6   .+�5W      �� $0��*/Reyuko.App;component/Icons/black_plus.png��6   $��15��6L   5X      5Y      �� 5[   
   $��Customer / Id��6   $
��12.5(�6(   $
��Left=�68   $��	10,58,0,0q�6S   $	��Top=�6f   $��26��6~   �� 5\   
   $��	Note Type��6   $
��Left=�6$   $
��12.5(�6?   $��
190,58,0,0q�6O   $	��Top=�6c   $��26��6{   �� 5]   
   $��Reference Number��6   $
��Left=�6+   $
��12.5(�6F   $��
360,58,0,0q�6V   $	��Top=�6j   $��26��6�   �� 5^   
   $��	Note Date��6   $
��Left=�6$   $
��12.5(�6?   $��
530,58,0,0q�6O   $	��Top=�6c   �� 5_   
   $��
Note Title��6   $
��Left=�6%   $
��12.5(�6@   $��
10,118,0,0q�6P   $	��Top=�6d   �� 5`   
   $��Reminder Date��6   $
��Left=�6(   $
��12.5(�6C   $��360,118,0,0q�6S   $	��Top=�6h   �� 5a   
   $��Document Reference No.��6   $
��Left=�61   $
��12.5(�6L   $��530,118,0,0q�6\   $	��Top=�6q   �� 5b   
   $��
Staff / ID��6   $
��Left=�6%   $
��12.5(�6@   $��720,118,0,0q�6P   $	��Top=�6e   �� 5c   
   
���   �$��1q�5d      $
��Left=�5e      $	��Top=�5f      	 �� CornerRadius$	 0��5g      $��	10,82,0,0q�6"   ._�5h      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��152��6h   .+�5i      -  'System.Windows.Controls.AutoCompleteBox  -   5        
  Name$
 srkontak��5i   +   $
��12.5(�6=   
������ $��Center=�6g   $��28��6�   $	��120��6�   $��-1,0,0,0q�6�   $��Center=�6�      ValueMemberPath$ NamaA��6�      ItemTemplate 5j      �� 5k      .R�5l      �� $ 
Horizontal=�6)   .+�5m   "   �� ��6,   �� *NamaA+5n      5o      5q      �� 5r      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��0,0,0,0q�6�   5s      5t      �� 5u   
   
���   �$��1q�5v      $
��Left=�5w      $	��Top=�5x      $	 0��5y      $��
360,82,0,0q�6"   ._�5z      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��150��6h   .+�5{        -   5        $
 noreference��5{   +   $
��12.5(�6@   
������ $��Center=�6j   $��28��6�   $	��120��6�   $��-1,0,0,0q�6�   $��Center=�6�   $ NamaA��6�    5|      �� 5}      .R�5~      �� $ 
Horizontal=�6)   .+�5   "   �� ��6,   �� *
Norefernce+5�      5�      5�      �� 5�      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��0,0,0,0q�6�   5�      5�      �� 5�   
   -   5         ��Name$ cbdepartment��5�      $
��12.5(�6)   $
��Left=�69   $��28��6T   $��
720,82,0,0q�6`   $	��Top=�6t   $	��152��6�   6�   (  "System.Windows.Controls.DatePicker  5�   
   -   5          Name$ 
dtNotedate��5�      $
��Left=�6)   $
��12.5(�6D   $��28��6T   $��
530,82,0,0q�6`   $	��Top=�6t   $	��150��6�   	� 5�   
   -	   5         	�Name$ 
Departmen1��5�      $��
Department��6*   $
��12.5(�6?   $
��Left=�6O   $��
720,58,0,0q�6j   $	��Top=�6~   6�   	� 5�   
   -
   5        $ Project��5�      $��Project��6'   $
��12.5(�69   $
��Left=�6I   $��
820,58,0,0q�6d   $	��Top=�6x   6�     5�   
   -   5        $ 
dtReminder��5�      $
��Left=�6)   $��28��6D   $
��12.5(�6P   $��360,143,0,0q�6`   $	��Top=�6u   $	��150��6�   �� 5�   
   -   5         ��Name$ txtNoteTitle��5�      $
��Left=�6(   $
��12.5(�6C   $��28��6S   $��
10,143,0,0q�6_    �� TextWrapping$
 Wrap=�6s   $	��Top=�6�   $	��330��6�   �� 5�   
   -   5        $ 
cbNoteType��5�      $
��Left=�6'   $
��12.5(�6B   $��28��6R   $��
190,82,0,0q�6^   $	��Top=�6r   $	��152��6�   6�   �� 5�   
   
���   �$��1q�5�      $
��Left=�5�      $	��Top=�5�      $	 0��5�      $��530,143,0,0q�6"   ._�5�      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��150��6h   .+�5�        -   5        $
 noreferencedokumen��5�   +   $
��12.5(�6G   
������ $��Center=�6q   $��28��6�   $	��120��6�   $��-1,0,0,0q�6�   $��Center=�6�   $ NamaA��6�    5�      �� 5�      .R�5�      �� $ 
Horizontal=�6)   .+�5�   "   �� ��6,   �� *
Norefernce+5�      5�      5�      �� 5�      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��0,0,0,0q�6�   5�      5�      �� 5�   
   
���   �$��1q�5�      $
��Left=�5�      $	��Top=�5�      $	 0��5�      $��720,143,0,0q�6"   ._�5�      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��152��6h   .+�5�        -   5        $

 staf��5�   +   $
��12.5(�69   
������ $��Center=�6c   $��28��6�   $	��120��6�   $��-1,0,0,0q�6�   $��Center=�6�   $ NamaA��6�    5�      �� 5�      .R�5�      �� $ 
Horizontal=�6)   .+�5�   "   �� ��6,   �� *
Norefernce+5�      5�      5�      �� 5�      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��0,0,0,0q�6�   5�      5�      ]� 5�   
   ��. $��10,185,10,10q�6)   .+�5�      `� $	��Top=�6   .�5�      +   %RichTextBoxToolBar.RichTextBoxToolBar  -   5          Name$ _rttb1��5�   )   5�      � 5�       � ColumnDefinitions 5�      �� 5�      $
��709* �6'   �� 5�      $
��331* �6'   .+�5�      �� -   5         ��Name$
 _rtb��5�      $��Stretch=�5�      $��Stretch=�5�      ��.  $��Hidden=�5�      $��Hidden=�5�       �� 	IsEnabled .  �� AcceptsReturn .  �� 
AcceptsTab . $��2��5�   ,   �� 5�      $��Stretch=�5�      $��Stretch=�5�      ��.  $��Hidden=�5�      $��Hidden=�5�       .  .  . $��2��5�   ,   �� 5�      $ 
Horizontal=�6   $��2��66   5�      5�      5�      5�      