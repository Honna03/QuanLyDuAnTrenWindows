   M S B A M L   `   `   `  ����  
QuanLyDuAn)    #QuanLyDuAn.Controls.RegisterControl   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � ���#F0F2F5.+�5	   
   �� 
�������$��50q�5
        �� CornerRadius$  15��5       �� Padding$ 30q�5      $	��450��5      $	��450��5         MaterialDesignShadow J� Effect# [  5      ._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   �� 5      $
��Auto �6$   .+�5      �� $��ĐĂNG KÝ TÀI KHOẢN��6   $��28(�5      $
��Bold"�5      $��Center=�5      $��0,0,0,40q�5      ���#2D3748 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$
 #888��6+      ShadowDepth$ 2Q�68      
BlurRadius$ 5Q�6H   5!      �� 5$      $��1��6   .+�5&      �� -   5         ��Name$ txtUsername��5&        MaterialTextBox#��[ 5'      
 � Tag$ Tên đăng nhập��5(      $��0,0,0,15q�5)      �� 5,      -   5        $ txtEmail��5,      #��[ 5-      $ Email��5.      $��0,0,0,15q�5/      G� 52      -   5        	 G�Name$	 txtPassword��52   "     MaterialPasswordBox#��[ 53       $ Mật khẩu��54       $��0,0,0,15q�55       G� 58      -   5        $	 txtConfirmPassword��58   "   #��[ 59       $ Xác nhận mật khẩu��5:       $��0,0,0,20q�5;       �� 5>      -   5        
 ��Name$
 btnRegister��5>      $��
Đăng ký��5@        MaterialButton#��[ 5A      ���#48BB78$	��150��5C      $��45��5D      $��0,0,0,15q�5E      �� 5H      $��Center=�6    $��0,0,0,0q�5I      �� 5J      -   5        ���#3182CE �� TextDecorations$
 None{�5L   "    � Cursor$
 Hand��5M   "   .�60   Quay lại đăng nhập��5O      �� 5P   "    �� 
TargetType" ��6(    �� Triggers 5Q   &   P� 5R   *    P� Property �@��IsMouseOver P� Value$
 True��6I   . �5S   .   ��  �� Property �@��TextDecorations �� Value$ 	Underline{�6P   5T   +   5V   #   .�5W   /   5X      5Y      5Z      5[      5\      5]      5^      