   M S B A M L   `   `   `  ����M  IRichTextBoxToolBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS<clr-namespace:RichTextBoxToolBar;assembly=RichTextBoxToolBarRichTextBoxToolBar  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	       
Reyuko.App,   &Reyuko.App.Views.NotesType.NewNoteType   5      U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R	 NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml    	 5      @d2http://schemas.microsoft.com/expression/blend/2008    	 5      Lrtb<clr-namespace:RichTextBoxToolBar;assembly=RichTextBoxToolBar    	 5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006    	 5      V
 RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 
 5      MComponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase 
 5      3System&clr-namespace:System;assembly=mscorlib 
 5	      $��14(�5      
�������$��Center=�5      $��Center=�63     � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5!      5"      5#      .��5&      � .+�5'   
   �� $	��221��5(      $��51��5)      $��	10,10,0,0q�5*      $
��Left=�5+      $	��Top=�5,      $��Segoe)�5-      $��36(�5.      $��Normal$�5/      $��	Note Type��50      $
��Wrap=�51      �� 53   
   -   5        $��Right=�53      $��
0,12,100,0q�6-   
������ $��0q�6Z   #��[  54      $	��Top=�6/   $��60��6G   .��55      ��  �� Orientation$ 
Horizontal=�6   .+�56      �� $*��$/Reyuko.App;component/Icons/save.png��6   $��20��6F   �� 57      $�� Save��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   58      59      �� 5;   
   -   5        $��Right=�5;      $��	0,12,20,0q�6-   
������ $��0q�6Y   #��[  5<      $	��Top=�6.   $��70��6F   .��5=      �� $ 
Horizontal=�6   .+�5>      �� $+��%/Reyuko.App;component/Icons/close.png��6   $��20��6G   �� 5?      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5@      5A      �� 5C   
   $
��Left=�6   $��
167,70,0,0q�6,   
������ $��0q�6Y   #��[" �5D      $	��Top=�6H   $��20��6`   .��5E      �� $ 
Horizontal=�6   5F      �� 5G   
   $
��Left=�6   $��690,136,0,0q�6,   
������ $��0q�6Z   #��[" �5H      $	��Top=�6H   $��20��6`   .��5I      �� $ 
Horizontal=�6   5J      �� 5K   
   $��	Note Type��6   $
��12.5(�6$   $
��Left=�64   $��	10,66,0,0q�6O   $	��Top=�6b   $��26��6z   �� 5L   
   $��Description��6   $
��12.5(�6&   $
��Left=�66   $��
10,116,0,0q�6Q   $	��Top=�6e   �� 5M   
   $��:��6   $
��Left=�6   $
��12.5(�67   $��
140,66,0,0q�6G   $	��Top=�6[   �� 5N   
   $��:��6   $
��Left=�6   $
��12.5(�67   $��140,116,0,0q�6G   $	��Top=�6\   �� 5O   
   -   5        	 ��Name$	 txtDescription��5O      $
��Left=�6*   $
��12.5(�6E   $��28��6U   $��150,116,0,0q�6a   
 �� TextWrapping$

 Wrap=�6v   $	��Top=�6�   $	��152��6�   6�   �� 5P   
   -   5        $	 txtNoteType��5P      $
��Left=�6'   $
��12.5(�6B   $��28��6R   $��
150,66,0,0q�6^   $

 Wrap=�6r   $	��Top=�6�   $	��152��6�   6�   ]� 5Q   
   ��. $��
0,177,0,-6q�6)   .+�5R      `� $	��Top=�6   .�5S      +   %RichTextBoxToolBar.RichTextBoxToolBar  -   5          Name$ _rttb1��5S   )   5T      � 5U      .+�5V      �� -   5         ��Name$
 _rtb��5V      $��Stretch=�5W      $��Stretch=�5X      ��.  $��Hidden=�5Z      $��Hidden=�5[       �� 	IsEnabled .  �� AcceptsReturn .  �� 
AcceptsTab . 5^      �� 5_      -   5        $
 Note��5`      $��Stretch=�5a      $��Stretch=�5b      ��.  $��Hidden=�5d      $��Hidden=�5e       .  .  . 5i      �� 5j      $ 
Horizontal=�6   5l      5m      5n      5q      5s      