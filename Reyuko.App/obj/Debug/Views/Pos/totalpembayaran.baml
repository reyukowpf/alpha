   M S B A M L   `   `   `  ����E  AReyuko.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Reyuko.App.Views.PosReyuko.App.Views.Pos  5   	   *    $Reyuko.App.Views.Pos.totalpembayaran   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Reyuko.App.Views.Pos     5   	     � Title$  totalpembayaran��5   	   $	��550��6!   $	��800��6.   $��Center=�6:   $��Center=�6W    � 	Resources 5	         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5
   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5      .��5      � .+�5   
   �� $��Total Pembayaran��6   $
��Left=�6+   $��
257,38,0,0q�6F   $	��Top=�6Z   $��36(�6r   �� 5    
   $��	Perincian��6   $
��Left=�6$   $��
55,160,0,0q�6?   $	��Top=�6S   $��18(�6k   �� 5!   
   $��Discount��6   $
��Left=�6#   $��105,199,0,0q�6>   $	��Top=�6S   $��14(�6k   �� 5"   
   $��Subtotal��6   $
��Left=�6#   $��105,240,0,0q�6>   $	��Top=�6S   $��14(�6k   �� 5#   
   $	��Tax��6   $
��Left=�6   $��105,280,0,0q�69   $	��Top=�6N   $��14(�6f   �� 5$   
   $��Total Pembayaran��6   $
��Left=�6+   $��105,323,0,0q�6F   $	��Top=�6[   $��14(�6s   �� 5&   
   -   5        $��Right=�5&      $��	0,12,20,0q�6-   
������ $��0q�6Y   #��[  5'      $	��Top=�6/   $��70��6G   .��5(      �� 	 �� Orientation$	 
Horizontal=�6   .+�5)      �� $,��&/Reyuko.App;component/Icons/close2.png��6   $��30��6H   5*      5+      �� 5-   
   -   5        
 ��Name$
 	Lanjutkan��5.      $	��479��5/      $��28��50      $��160,470,0,0q�51      $
��Left=�52      $	��Top=�53      
��� ���$��0q�55      #��[  56      $��	Lanjutkan��67   $��18(�6K   �� 58   
   -   5        $
 Pajak��59      $	��479��5:      $��28��5;      $��160,439,0,0q�5<      $
��Left=�5=      $	��Top=�5>      
�������$��0q�5@      #��[  5A      $��Pajak��67   $��18(�6G   �� 5C   
   -   5        $
 TambahDiskon��5D      $	��479��5E      $��28��5F      $��160,409,0,0q�5G      $
��Left=�5H      $	��Top=�5I      
�������$��0q�5K      #��[  5L      $��Tambah Diskon��67   $��18(�6O   5O      5P      