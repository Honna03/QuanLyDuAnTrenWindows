   M S B A M L   `   `   `  ����E  AQuanLyDuAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:QuanLyDuAn.FormsQuanLyDuAn.Forms  5      '    !QuanLyDuAn.Forms.DanhSachNhanVien   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:QuanLyDuAn.Forms     5        � 	Resources  5	       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value	 ��Name&   System.Windows.Controls.DataGrid=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '��       '�� �    '  4    '  �    �� 5   
   " ��6   .�5      ��  � ��$
 10,5q�6(   �� 5       � ��$ 5q�6'   �� 5       � �� �#0078D76+   �� 5       � ��
 �����6+   �� 5       � ��$ 0q�60   �� 5       � ��$ 14(�6)   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 5��5      #��z��5      ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver$
 True��6=   . �5   "   ��  � �� �#005EA66?   5      P� 5       � ��$
 True��6;   . �5   "   ��  � �� �#003E756?   5       5"      5$      5%      �� 5(   
   " ��6   .�5)      ��  � ��$ 5q�6(   �� 5*       � ��$ 14(�6)   �� 5+       � �� �#D1D1D16,   �� 5,       � ��$ 1q�60   �� 5-       � �� 5.      �� 5/      " ��6&   .R�50      �� #��z��6!   #��z��51      #��z��52      $ 5��53      ._�54      �� $	 PART_ContentHost��6+   $��2q�6E   55      56      58      59      �� 5<   
   "  6   .�5=      ��  � �� �#D1D1D16,   �� 5>       � ��$ 1q�60   �� 5?       �@ RowBackground
 �����6.   �� 5@        �@ AlternatingRowBackground �#F5F5F569   �� 5A       �@ HeadersVisibility$ Column=�62   �� 5B       �@ GridLinesVisibility$ 
Horizontal=�64   �� 5C        �@ HorizontalGridLinesBrush �#E0E0E069   5D      �� 5G   
   "  6   .�5H      ��  � �� �#F0F0F06+   �� 5I       � ��$
 Bold"�6+   �� 5J       � ��$ 5q�6(   �� 5K       � ��$ 0,0,1,1q�60   �� 5L       � �� �#D1D1D16,   5M      5N      .��5P      � $��20q�6   
 � RowDefinitions
 5Q   
   �� 5R      $
��Auto �6   �� 5S      $��* �6   �� 5T      $
��Auto �6   .+�5X   
   �� $��0��6   $��Danh Sáchn nhân viên��5Y      $��24(�5Z      $
��Bold"�5[      ���#333333$��0,0,0,15q�5]      �� 5`   
   $��0��6    �� Orientation$ 
Horizontal=�5a      $��Right=�5b      .+�5c      �� -   5         ��Name$ 	SearchBox��5d      $	��250��5c      $��Tìm kiếm nhân viên��5e      �� 5f      $��Tìm kiếm��6   �� 5g      $��Thêm nhân viên��6   5h        5k   
   -   5          Name$ EmployeeDataGrid��5l      $��1��5k         AutoGenerateColumns$ False��5m         
IsReadOnly$
 True��5n         SelectionMode$ Single=�5o         CanUserSortColumns$
 True��5p      $��0,0,0,10q�5q         Columns 5r      4  .System.Windows.Controls.DataGridCheckBoxColumn  5s      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 5t   "   0  *System.Windows.Controls.DataGridTextColumn  5u      $ Mã nhân viên��6%   $ * 5w      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5v      �� *nv_Ma+5w        5x      $ Họ và tên��6%   $ * 5z       5y      �� *nv_Ten+5z        5{      $ Giới tính��6%   $ * 5}       5|      �� *nv_GioiTinh+5}        5~      $ 
Ngày sinh��6%   $ * 5�       5      �� *nv_NgaySinh+5�        5�      $ Chức vụ��6%   $ * 5�       5�      �� *	nv_ChucVu+5�      5�      �� 5�   
   -   5         ��Name$ TotalRecordsTextBlock��5�      $��2��5�      $��14(�5�      ���#666666$��0,5,0,0q�5�      5�      5�      