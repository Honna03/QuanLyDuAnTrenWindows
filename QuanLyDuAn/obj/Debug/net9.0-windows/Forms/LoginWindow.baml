   M S B A M L   `   `   `  ����  
QuanLyDuAn&     QuanLyDuAn.Controls.LoginControl   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � ���#F0F2F5$��
0,10,50,34q�6    .+�5	   
   �� 
�������$��50q�5
        �� CornerRadius$  15��5       �� Padding$ 30q�5      $	��450��5      $	��400��5         MaterialDesignShadow J� Effect# [  5      ._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   �� 5      $
��Auto �6$   .+�5      �� $��QUẢN LÝ DỰ ÁN��6   $��28(�5      $
��Bold"�5      $��Center=�5      $��0,0,0,40q�5      ���#2D3748 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$
 #888��6+      ShadowDepth$ 2Q�68      
BlurRadius$ 5Q�6H   5!      �� 5$      $��1��6   .+�5%      �� -   5         ��Name$ txtUsername��5%        MaterialTextBox#��[ 5&      
 � Tag$ Tên đăng nhập��5'      $��0,0,0,15q�5(      G� 5*      -   5        	 G�Name$	 txtPassword��5*   "     MaterialPasswordBox#��[ 5+       $ Mật khẩu��5,       $��0,0,0,15q�5-       �� 50      $��Right=�6    $��0,0,0,20q�51      �� 52      -   5        ���#3182CE
 �� TextDecorations$

 None{�54   "    � Cursor$
 Hand��55   "   .�60   Quên mật khẩu?��57      �� 58   "    �� 
TargetType" ��6(    �� Triggers 59   &   P� 5:   *    P� Property �@��IsMouseOver P� Value$
 True��6I   . �5;   .   ��  �� Property �@��TextDecorations �� Value$ 	Underline{�6P   5<   +   5>   #   .�5?   /   5@      5A      �� 5B      -   5         ��Name$ btnLogin��5B      $��Đăng nhập��5D        MaterialButton#��[ 5E      ���#3182CE$	��150��5G      $��45��5H       J� RenderTransformOrigin$ 0.487,0.625&�6)   �� 5I      -   5        $ btnRegister��5I      $��
Đăng ký��5K      #��[ 5L      ���#48BB78$	��150��5N      $��45��5O      $ 0.501,0.642&�6)   5T      5U      5V      5W      5X      