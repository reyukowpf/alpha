   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5      E AReyuko.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Reyuko.App
Reyuko.App 5	      2   ,Reyuko.App.Views.SalaryPayment.SalaryPayment   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V	 RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 5      $localclr-namespace:Reyuko.App 	 5	      $��14(�5      
�������$
��Left=�5      $	��Top=�61   $
��1040��6I   $	��688��6V     � DataContext  5      $  Reyuko.App.MainWindowViewModel  5   
    � 	Resources 5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5!      5#      5$      5%      .��5'      � .+�5(   
   ' 	 !MaterialDesignThemes.Wpf.PopupBox  	   ToggleContent$		 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,10,8,0q�6l   $	��Top=�6   $��40��6�   
   PopupContent.
 5)      �� .+�5*      �� -   5        $
��Left=�5*      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5+      $	��Top=�6P   $	��120��6h   .��5,      ��  �� Orientation$ 
Horizontal=�6!   .+�5-      �� $.��(/Reyuko.App;component/Icons/tutorial.png��6    $��23��6R   $��23��6^   �� 5.      $��Play Tutorial��6$   $
��12.5(�69   $
��Left=�6I   $��10,0,0,0q�6d   $��Center=�6v   5/      50      51      52      �� 53   
   $	��335��54      $��55��55      $��	10,20,0,0q�56      $
��Left=�57      $	��Top=�58      $��Segoe)�59      $��36(�5:      $��Normal$�5;      $��Salary Payment��5<      $
��Wrap=�5=      �� 5?   
   -   5        $��Right=�5?      $��
0,21,209,0q�6-   
������ $��0q�6Z   #��[  5@      $	��Top=�6/   $��60��6G   .��5A      �� $ 
Horizontal=�6   .+�5B      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5C      $
�� New��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5D      5E        5G   
   $
	 View��6"   $��22��67   $
��12.5(�6C   $��Right=�6S   $��
0,21,129,0q�6o   $	��Top=�6�   $��60��6�   .
 5H      �� $��10,0,0,0q�5I      $	��150��5J      $	��Top=�5K      $
��Left=�5L      .+�5M      �� -   5         ��Name$ chksalaryno��5M      $
��12.5(�60   $��Salary Payment No.��5O       d� 	IsChecked 5N      ��  �� Path$  SalaryPaymentColumnChecked� �� Mode$ TwoWay=�5O      �� 5P      -   5        $ chkdate��5P      $
��12.5(�6,   $
��Date��5R       5Q      �� $ DateColumnChecked�$ TwoWay=�5R      �� 5S      -   5        $ chkemployee��5S      $
��12.5(�60   $��Employee / ID��5U       5T      �� $ EmployeeColumnChecked�$ TwoWay=�5U      �� 5V      -   5        $ chkbasic��5V      $
��12.5(�6-   $��Basic Salary��5X       5W      �� $ BasicColumnChecked�$ TwoWay=�5X      �� 5Y      -   5        $ chkallowance��5Y      $
��12.5(�61   $��	Allowance��5[       5Z      �� $ AllowanceColumnChecked�$ TwoWay=�5[      �� 5\      -   5        $ chktotalovertime��5\      $
��12.5(�65   $��Total Overtime��5^       5]      �� $  TotalovertimeColumnChecked�$ TwoWay=�5^      �� 5_      -	   5        $ chkother��5_      $
��12.5(�6-   $��Others��5a       5`      �� $ OthersColumnChecked�$ TwoWay=�5a      �� 5b      -
   5        $ chktax��5b      $
��12.5(�6+   $	��Tax��5d       5c      �� $ TaxColumnChecked�$ TwoWay=�5d      �� 5e      -   5        $ chknote��5e      $
��12.5(�6,   $
��Note��5g       5f      �� $ NoteColumnChecked�$ TwoWay=�5g      �� 5h      -   5        $ chkbank��5h      $
��12.5(�6,   $��	Bank Data��5j       5i      �� $ BankDataColumnChecked�$ TwoWay=�5j      �� 5k      -   5        $ chktotal��5k      $
��12.5(�6-   $��Total��5m       5l      �� $ TotalColumnChecked�$ TwoWay=�5m      �� 5n      -   5        $ chkdepartmen��5n      $
��12.5(�61   $��
Department��5p       5o      �� $ DepartmenColumnChecked�$ TwoWay=�5p      �� 5q      -   5        $ 	chkproyek��5q      $
��12.5(�6.   $��Project��5s       5r      �� $ ProjectColumnChecked�$ TwoWay=�5s      5t      5u      �� 5w   
   -   5        $��Right=�5w      $��	0,21,59,0q�6-   
������ $��0q�6Y   #��[  5x      $	��Top=�6/   $��60��6G   .��5y      �� $ 
Horizontal=�6   .+�5z      �� $+��%/Reyuko.App;component/Icons/print.png��6   $��20��6G   �� 5{      $�� Print��6   $
��12.5(�6*   $��Center=�6:   $��Center=�6W   5|      5}      �� 5   
   -   5        $��Right=�5      $��	0,20,55,0q�6-   
������ $��0q�6Y   #��[  5�      $	��Top=�6/   $��70��6G   .��5�      �� $ 
Horizontal=�6   5�      �� 5�   
   
���   �$��1q�5�      $
��Left=�5�      $	��Top=�5�       �� CornerRadius$ 0��5�      $��	10,80,0,0q�6*   ._�5�      ]� $
��Left=�6   $	��Top=�63   $��0,0,0,0q�6K   $��26��6\   $	��170��6h   .+�5�      -   'System.Windows.Controls.AutoCompleteBox  -   5          Name$ srsalary��5�   +   $
��12.5(�6=   
������ $��Center=�6g   $��28��6�   $	��140��6�   $��
-1,-1,0,-1q�6�   $��Center=�6�      ValueMemberPath$ NamaGrupProduk��6�      ItemTemplate 5�      �� 5�      .R�5�      �� $ 
Horizontal=�6)   .+�5�   "   �� ��6,   �� *NamaGrupProduk+5�      5�      5�      �� 5�      $
��Left=�6   $,��&/Reyuko.App;component/Icons/search.png��6.   $��20��6^   $��Center=�6j   $��Center=�6�   $��0,0,0,0q�6�   5�      5�      &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ DGSalaryPayment��5�      $��Visible=�5�      $
��Auto��5�      $
��Auto��5�      $��10,117,10,10q�5�         AutoGenerateColumns .  $��0q�5�         CanUserResizeRows .     ColumnHeaderHeight$ 32Q�5�      $
��12.5(�5�         GridLinesVisibility$
 None=�5�         HeadersVisibility$ Column=�5�         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�5�         	RowHeight$ 30Q�5�         SelectionMode$ Single=�5�      ��5�      Z� ��5�      Z�  5�        Reyuko.App.BindingProxy  ColumnCheckedProxy   Data  ColumnCheckedProxy1  ColumnCheckedProxy2  ColumnCheckedProxy3  ColumnCheckedProxy4  ColumnCheckedProxy5  ColumnCheckedProxy6  ColumnCheckedProxy7 	 ColumnCheckedProxy8 
 ColumnCheckedProxy9  ColumnCheckedProxy10  ColumnCheckedProxy11  ColumnCheckedProxy12=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�  &	       &	 ;     &	 m     &	 �     &	 �     &	     &	 H    &	 |    &		 �    &	
 �    &	     &	 H    &	     '  �    7   5�       6@   �� *SalaryPaymentColumnChecked+  5�       6A   �� *DateColumnChecked+  5�       6A   �� *EmployeeColumnChecked+  5�       6A   �� *BasicColumnChecked+  5�       6A   �� *AllowanceColumnChecked+  5�       6A   �� *TotalovertimeColumnChecked+  5�       6A   �� *OthersColumnChecked+  5�       6A   �� *TaxColumnChecked+  5�       6A   �� *NoteColumnChecked+  5�       6A   �� *BankDataColumnChecked+  5�       6B   �� *TotalColumnChecked+  5�       6B   �� *DepartmenColumnChecked+  5�       6B   �� *ProjectColumnChecked+�� 5�      8   "  6Q   .�5�      ��  � ��$ Center=�6C   �� 5�       � �� �	#FF5684C363   �� 5�       � ��
 �����63   5�      5�          Columns  5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn!   Width5	  /System.Windows.Controls.DataGridLengthConverter$	! 120	 5�      "   CanUserReorder" .  #   CanUserResize# .  $   CanUserSort$ . %   FontSize$
% 12.5Q�5�      &   Header$& Salary Payment No��5�      1
  +System.Windows.Controls.DataGridBoundColumn' 
  Binding' 5�      �� *NoPembayaranGaji+(   
Visibility( 5�      �� *Data+  BoolToVisibilityConverter) �� 	Converter#) [ * �� Source#* [ +   HeaderStyle+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      , 
  ElementStyle, 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $! 80	 5�      " .  # .  $ . $
% 12.5Q�5�      $
& Date��5�      ' 5�      �� *	Tanggal+- �� StringFormat$- {0:MM/dd/yy}��( 5�      �� *Data+#) [ #* [ + 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      , 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5�        5�      $	! 120	 5�      " .  # .  $ . $
% 12.5Q�5�      $& Employee / ID��5�      ' 5�      �� *NamaEmployee+( 5�      �� *Data+#) [ #* [ + 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�      , 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6B   5�      5       5     $	! 100	 5     " .  # .  $ . $
% 12.5Q�5     $& Basic Salary��5	     ' 5     �� *	GajiPokok+( 5
     �� *Data+#) [ #* [ + 5     �� 5     # [B 6    "  6Y   .�5     ��  � ��$ Center=�6K   �� 5      � �� �	#FF5684C36;   �� 5      � ��
 �����6;   5     , 5     �� 5     # [B��6    " ��6N   .�5     ��  �@��TextAlignment$ Center=�6H   �� 5      � ��$ Center=�6B   5     5       5     $	! 100	 5     " .  # .  $ . $
% 12.5Q�5     $& 	Allowance��5      ' 5     �� *	Tunjangan+( 5!     �� *Data+#) [ #* [ + 5"     �� 5#     # [B 6    "  6Y   .�5$     ��  � ��$ Center=�6K   �� 5%      � �� �	#FF5684C36;   �� 5&      � ��
 �����6;   5'     , 5)     �� 5*     # [B��6    " ��6N   .�5+     ��  �@��TextAlignment$ Center=�6H   �� 5,      � ��$ Center=�6B   5-     5/       50     $	! 100	 51     " .  # .  $ . $
% 12.5Q�56     $& Total Overtime��57     ' 52     �� *TotalOvertime+( 58     �� *Data+#) [ #* [ + 59     �� 5:     # [B 6    "  6Y   .�5;     ��  � ��$ Center=�6K   �� 5<      � �� �	#FF5684C36;   �� 5=      � ��
 �����6;   5>     , 5@     �� 5A     # [B��6    " ��6N   .�5B     ��  �@��TextAlignment$ Center=�6H   �� 5C      � ��$ Center=�6B   5D     5F       5G     $	! 100	 5H     " .  # .  $ . $
% 12.5Q�5M     $& Others��5N     ' 5I     �� *
Lainlain+( 5O     �� *Data+#) [ #* [ + 5P     �� 5Q     # [B 6    "  6Y   .�5R     ��  � ��$ Center=�6K   �� 5S      � �� �	#FF5684C36;   �� 5T      � ��
 �����6;   5U     , 5W     �� 5X     # [B��6    " ��6N   .�5Y     ��  �@��TextAlignment$ Center=�6H   �� 5Z      � ��$ Center=�6B   5[     5]       5^     $! 60	 5_     " .  # .  $ . $
% 12.5Q�5d     $	& Tax��5e     ' 5`     �� *Pajak+( 5f     �� *Data+#) [ #* [ + 5g     �� 5h     # [B 6    "  6Y   .�5i     ��  � ��$ Center=�6K   �� 5j      � �� �	#FF5684C36;   �� 5k      � ��
 �����6;   5l     , 5n     �� 5o     # [B��6    " ��6N   .�5p     ��  �@��TextAlignment$ Center=�6H   �� 5q      � ��$ Center=�6B   5r     5t       5u     $	! 200	 5v     " .  # .  $ . $
% 12.5Q�5{     $
& Note��5|     ' 5w     �� *
Keterangan+( 5}     �� *Data+#) [ #* [	 + 5~     �� 5     # [B 6    "  6Y   .�5�     ��  � ��$
 Left=�6K   �� 5�      � �� �	#FF5684C36;   �� 5�      � ��
 �����6;   5�     , 5�     �� 5�     # [B��6    " ��6N   .�5�     ��  �@��TextAlignment$ Center=�6H   �� 5�      � ��$ Center=�6B   5�     5�       5�     $	! 120	 5�     " .  # .  $ . $
% 12.5Q�5�     $& 	Bank Data��5�     ' 5�     �� *
BankData+( 5�     �� *Data+#) [ #* [
 + 5�     �� 5�     # [B 6    "  6Y   .�5�     ��  � ��$
 Left=�6K   �� 5�      � �� �	#FF5684C36;   �� 5�      � ��
 �����6;   5�     , 5�     �� 5�     # [B��6    " ��6N   .�5�     ��  �@��TextAlignment$ Center=�6H   �� 5�      � ��$ Center=�6B   5�     5�       5�     $	! 100	 5�     " .  # .  $ . $
% 12.5Q�5�     $& Total��5�     ' 5�     �� *Total+( 5�     �� *Data+#) [ #* [ + 5�     �� 5�     # [B 6    "  6Y   .�5�     ��  � ��$
 Left=�6K   �� 5�      � �� �	#FF5684C36;   �� 5�      � ��
 �����6;   5�     , 5�     �� 5�     # [B��6    " ��6N   .�5�     ��  �@��TextAlignment$ Center=�6H   �� 5�      � ��$ Center=�6B   5�     5�       5�     $! 80	 5�     " .  # .  $ . $
% 12.5Q�5�     $& 
Department��5�     ' 5�     �� *IdDepartment+( 5�     �� *Data+#) [ #* [ + 5�     �� 5�     # [B 6    "  6Y   .�5�     ��  � ��$
 Left=�6K   �� 5�      � �� �	#FF5684C36;   �� 5�      � ��
 �����6;   5�     , 5�     �� 5�     # [B��6    " ��6N   .�5�     ��  �@��TextAlignment$ Center=�6H   �� 5�      � ��$ Center=�6B   5�     5�       5�     $! 80	 5�     " .  # .  $ . $
% 12.5Q�5�     $& Project��5�     ' 5�     �� *
IdProyek+( 5�     �� *Data+#) [ #* [ + 5�     �� 5�     # [B 6    "  6Y   .�5�     ��  � ��$ Center=�6K   �� 5�      � �� �	#FF5684C36;   �� 5�      � ��
 �����6;   5�     , 5�     �� 5�     # [B��6    " ��6N   .�5�     ��  �@��TextAlignment$ Center=�6H   �� 5�      � ��$ Center=�6B   5�     5�     5�     5�     5�     