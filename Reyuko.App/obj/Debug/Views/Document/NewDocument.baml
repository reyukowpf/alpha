   M S B A M L   `   `   `  ����  
Reyuko.App+    %Reyuko.App.Views.Document.NewDocument   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $��14(�5
      
�������$
��Left=�5      $	��Top=�61   $
��1040��6I   $	��700��6V     � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5       .��5"      � .+�5#   
   �� $	��262��5$      $��52��5%      $��	20,12,0,0q�5&      $
��Left=�5'      $	��Top=�5(      $��Segoe)�5)      $��36(�5*      $��Normal$�5+      $��New Document��5,      $
��Wrap=�5-      �� 5.   
   -   5        $��Right=�5.      $��
0,25,100,0q�6-   
������ $��0q�6Z   #��[  5/      $	��Top=�6/   $��60��6G   .��50      ��  �� Orientation$ 
Horizontal=�6   .+�51      �� $*��$/Reyuko.App;component/Icons/save.png��6   $��20��6F   �� 52      $�� Save��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   53      54      �� 55   
   -   5        $��Right=�55      $��	0,25,20,0q�6-   
������ $��0q�6Y   #��[  56      $	��Top=�6/   $��70��6G   .��57      �� $ 
Horizontal=�6   .+�58      �� $+��%/Reyuko.App;component/Icons/close.png��6   $��20��6G   �� 59      $�� Cancel��6   $
��12.5(�6+   $��Center=�6;   $��Center=�6X   5:      5;      �� 5<   
   $��Document Type��6   $
��12.5(�6(   $
��Left=�68   $��
20,100,0,0q�6S   $	��Top=�6g   �� 5=   
   $��Document No��6   $
��12.5(�6&   $
��Left=�66   $��
20,150,0,0q�6Q   $	��Top=�6e   �� 5>   
   $
��Date��6   $
��12.5(�6   $
��Left=�6/   $��
20,200,0,0q�6J   $	��Top=�6^   �� 5?   
   $��Contact Name��6   $
��12.5(�6'   $
��Left=�67   $��
20,250,0,0q�6R   $	��Top=�6f   �� 5@   
   $��Description��6   $
��12.5(�6&   $
��Left=�66   $��
20,380,0,0q�6Q   $	��Top=�6e   �� 5A   
   $��Uploaded File��6   $
��12.5(�6(   $
��Left=�68   $��520,100,0,0q�6S   $	��Top=�6h   �� 5B   
   $��:��6   $
��Left=�6   $��190,100,0,0q�67   $	��Top=�6L   �� 5C   
   $��:��6   $
��Left=�6   $��190,150,0,0q�67   $	��Top=�6L   �� 5D   
   $��:��6   $
��Left=�6   $��190,200,0,0q�67   $	��Top=�6L   �� 5E   
   $��:��6   $
��Left=�6   $��190,250,0,0q�67   $	��Top=�6L   �� 5F   
   $��:��6   $
��Left=�6   $��190,380,0,0q�67   $	��Top=�6L   �� 5G   
   -   5        	 ��Name$	 cbDocumentTipe��5G      
 �� 
IsEditable
 . $
��12.5(�6=   $
��Left=�6M   $��28��6h   $��220,100,0,0q�6t   $	��Top=�6�   $	��212��6�   6�   �� 5H   
   -   5         ��Name$ txtDocumentNo��5H      $
��Left=�6)   $
��12.5(�6D   $��28��6T   $��220,150,0,0q�6`    �� TextWrapping$
 Wrap=�6u   $	��Top=�6�   $	��212��6�   6�   (  "System.Windows.Controls.DatePicker  5I   
   -   5          Name$ dtTanggalDokumen��5I      $
��Left=�6/   $
��12.5(�6J   $��28��6Z   $��220,200,0,0q�6f   $	��Top=�6{   $	��212��6�   �� 5J   
   -   5        $	 cbNamakontak��5J      
 . $
��Left=�6;   $
��12.5(�6V   $��28��6f   $��220,250,0,0q�6r   $	��Top=�6�   $	��212��6�   6�   �� 5K   
   -   5        $	 cbdepartment��5K      
 . $
��Left=�6;   $��28��6V   $
��12.5(�6b   $��220,330,0,0q�6r   $	��Top=�6�   $	��170��6�   6�   �� 5L   
   -   5        $	 cbproyek��5L      
 . $
��Left=�67   $��28��6R   $
��12.5(�6^   $��220,330,0,0q�6n   $	��Top=�6�   $	��212��6�   6�   �� 5M   
   -	   5        $ txtDescription��5M      $
��Left=�6*   $��80��6E   $��220,380,0,0q�6Q   $
��12.5(�6f   $
 Wrap=�6v   $	��Top=�6�   $	��212��6�   6�   	� 5N   
   -
   5         	�Name$ 	Departmen��5N      $��
Department��6)   $
��Left=�6>   $
��12.5(�6Y   $��220,300,0,0q�6i   $	��Top=�6~   6�   	� 5O   
   -   5        $ Projec��5O      $��Project��6&   $
��Left=�68   $��320,300,0,0q�6S   $
��12.5(�6h   $	��Top=�6x   6�   �� 5P   
   -   5        $
��Left=�5P      $��620,100,0,0q�6,   
������ $��0q�6Z   #��[" �5Q      $	��Top=�6H   $	��105��6`   .��5R      �� $ 
Horizontal=�6   .+�5S      �� $0��*/Reyuko.App;component/Icons/chooseFile.png��6   $��80��6L   $	��100��6X   5T      5U      �� 5V   
   -   5        $
��Left=�5V      $��620,200,0,0q�6,   
������ $��0q�6Z   #��[" �5W      $	��Top=�6H   $	��105��6`   .��5X      �� $ 
Horizontal=�6   .+�5Y      �� $0��*/Reyuko.App;component/Icons/chooseFile.png��6   $��80��6L   $	��100��6X   5Z      5[      �� 5\   
   -   5        $
��Left=�5\      $��620,300,0,0q�6,   
������ $��0q�6Z   #��[" �5]      $	��Top=�6H   $	��105��6`   .��5^      �� $ 
Horizontal=�6   .+�5_      �� $0��*/Reyuko.App;component/Icons/chooseFile.png��6   $��80��6L   $	��100��6X   5`      5a      �� 5b   
   -   5        $
��Left=�5b      $��620,400,0,0q�6,   
������ $��0q�6Z   #��[" �5c      $	��Top=�6H   $	��105��6`   .��5d      �� $ 
Horizontal=�6   .+�5e      �� $0��*/Reyuko.App;component/Icons/chooseFile.png��6   $��80��6L   $	��100��6X   5f      5g      5h      5j      