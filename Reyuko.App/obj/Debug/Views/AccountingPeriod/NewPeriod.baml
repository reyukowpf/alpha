   M S B A M L   `   `   `  ����  
Reyuko.App1    +Reyuko.App.Views.AccountingPeriod.NewPeriod   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $	��232��5        � WindowStyle$
  None=�5       � WindowStartupLocation$ CenterScreen=�5	      $	��460��5
      $��Center=�6   $��Center=�67   $��1q�6R    � 
ResizeMode$ NoResize=�6f    � 	Resources 5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers	 P� Property
 P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5      	 �@J�IsMouseOver
 . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5      .��5      � .+�5    
   �� $��
New Period��6   $��36(�6%   $
��Left=�63   $��	50,15,0,0q�6N   $	��Top=�6a   $	��196��6y   �� 5!   
   $��Tahun Buku Awal��6   $
��12.5(�6*   $
��Left=�6:   $��	50,82,0,0q�6U   $	��Top=�6h   $��94��6�   �� 5"   
   $��Tahun Buku Akhir��6   $
��12.5(�6+   $
��Left=�6;   $��
50,120,0,0q�6V   $	��Top=�6j   (  "System.Windows.Controls.DatePicker  5#   
   -   5          Name$ DtTahunBukuAwal��5#      $
��12.5(�6.   $
��Left=�6>   $��
180,80,0,0q�6Y   $	��Top=�6m   $	��202��6�     5$   
   -   5        $ DtTahunBukuAkhir��5$      $
��12.5(�6/   $
��Left=�6?   $��180,120,0,0q�6Z   $	��Top=�6o   $	��202��6�   �� 5%   
   -   5         ��Name$ ChkAktif��5%      $��InActive��6%   $
��12.5(�68   $
��Left=�6H   $��323,160,0,0q�6c   $	��Top=�6x   �� 5&   
   -   5        $��Right=�5&      $��	0,31,90,0q�6-   
������ $��0q�6Y   #��[  5'      $	��Top=�60   $��60��6H   .��5(      ��  �� Orientation$ 
Horizontal=�6   .+�5)      �� $*��$/Reyuko.App;component/Icons/save.png��6   $��20��6F   �� 5*      $�� Save��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5+      5,      �� 5.   
   -   5        $��Right=�5.      $��	0,31,10,0q�6-   
������ $��0q�6Y   #��[  5/      $	��Top=�60   $��70��6H   .��50      �� $ 
Horizontal=�6   .+�51      �� $*��$/Reyuko.App;component/Icons/edit.png��6   $��20��6F   �� 52      $�� Edit��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   53      54      55      56      