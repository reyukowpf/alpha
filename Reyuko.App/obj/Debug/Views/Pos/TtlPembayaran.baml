   M S B A M L   `   `   `  ����E  AReyuko.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Reyuko.App.Views.PosReyuko.App.Views.Pos  5   	   (    "Reyuko.App.Views.Pos.TtlPembayaran   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Reyuko.App.Views.Pos     5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5   	     � Title$  TtlPembayaran��5	   	   $	��450��6   $	��800��6,   $��Center=�68   $��Center=�6U    � 	Resources 5
         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5      .��5      � .+�5    
   �� $��Total Pembayaran��6   $
��Left=�6+   $��
257,38,0,0q�6F   $	��Top=�6Z   $��36(�6r   �� 5!   
   -   5        $��Right=�5!      $��	0,12,20,0q�6-   
������ $��0q�6Y   #��[  5"      $	��Top=�6/   $��70��6G   .��5#      �� 	 �� Orientation$	 
Horizontal=�6   .+�5$      �� $,��&/Reyuko.App;component/Icons/close2.png��6   $��30��6H   5%      5&      �� 5(   
   -   5        
 ��Name$
 TerimaPembayaran��5)      $	��479��5*      $��28��5+      $��160,240,0,0q�5,      $
��Left=�5-      $	��Top=�5.      
��� ���$��0q�50      #��[  51      $��Terima Pembayaran��67   $��18(�6S   (  "DevExpress.Xpf.Core.DropDownButton  53   
   $��Metode Pembayaran��6   
�������$
��Left=�6K   $��28��6f   $��160,195,0,0q�6r   $	��Top=�6�   $	��479��6�   ,  &DevExpress.Xpf.Core.DropDownButtonBase   PopupDropAlignment$ Right=�6�   &   DevExpress.Xpf.Core.SimpleButton   
ButtonKind$ Simple=�6�   $��18(�6�   ��54      �� 55       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��56      �  � Color$ Black��6#    � Offset$ 0Q�61   � 57      $ 	#FFB62828��6#   $ 1Q�65   58      5:      5;      5<      