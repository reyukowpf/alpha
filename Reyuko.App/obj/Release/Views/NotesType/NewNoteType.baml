   M S B A M L   `   `   `  ���� M  IRichTextBoxToolBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS<clr-namespace:RichTextBoxToolBar;assembly=RichTextBoxToolBarRichTextBoxToolBar  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  
Reyuko.App,   &Reyuko.App.Views.NotesType.NewNoteType   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Lrtb<clr-namespace:RichTextBoxToolBar;assembly=RichTextBoxToolBar     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     U	 QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 MComponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase 	 3System&clr-namespace:System;assembly=mscorlib 	 $��14(�
�������$��Center=�$��Center=�  � 	Resources     MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%  &	        �� " ��.���  �@�OverridesDefaultStyle . ��  �@�Cursor$
 Hand����  � �� �� " ��.R��� $��border��$��0q�
���   �#��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 0.8Q�.��� .+��� $	��221��$��51��$��	10,10,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��36(�$��Normal$�$��	Note Type��$
��Wrap=��� -   $��Right=�$��
0,12,100,0q�
������ $��0q�#��[  $	��Top=�$��60��.����  �� Orientation$ 
Horizontal=�.+��� $*��$/Reyuko.App;component/Icons/save.png��$��20���� $�� Save��$
��12.5(�$��Center=�$��Center=��� -   $��Right=�$��	0,12,20,0q�
������ $��0q�#��[  $	��Top=�$��70��.���� $ 
Horizontal=�.+��� $+��%/Reyuko.App;component/Icons/close.png��$��20���� $�� Cancel��$
��12.5(�$��Center=�$��Center=��� $
��Left=�$��
167,70,0,0q�
������ $��0q�#��[" �$	��Top=�$��20��.���� $ 
Horizontal=��� $
��Left=�$��690,136,0,0q�
������ $��0q�#��[" �$	��Top=�$��20��.���� $ 
Horizontal=��� $��	Note Type��$
��12.5(�$
��Left=�$��	10,66,0,0q�$	��Top=�$��26���� $��Description��$
��12.5(�$
��Left=�$��
10,116,0,0q�$	��Top=��� $��:��$
��Left=�$
��12.5(�$��
140,66,0,0q�$	��Top=��� $��:��$
��Left=�$
��12.5(�$��140,116,0,0q�$	��Top=��� -   	 ��Name$	 txtDescription��$
��Left=�$
��12.5(�$��28��$��150,116,0,0q�
 �� TextWrapping$

 Wrap=�$	��Top=�$	��152���� -   $	 txtNoteType��$
��Left=�$
��12.5(�$��28��$��
150,66,0,0q�$

 Wrap=�$	��Top=�$	��152��]� ��. $��
0,177,0,-6q�.+�`� $	��Top=�.�+   %RichTextBoxToolBar.RichTextBoxToolBar  -     Name$ _rttb1��� .+��� -    ��Name$
 _rtb��$��Stretch=�$��Stretch=���.  $��Hidden=�$��Hidden=� �� 	IsEnabled .  �� AcceptsReturn .  �� 
AcceptsTab . �� -   $
 Note��$��Stretch=�$��Stretch=���.  $��Hidden=�$��Hidden=� .  .  . �� $ 
Horizontal=�