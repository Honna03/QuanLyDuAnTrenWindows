   M S B A M L   `   `   `  ����E  AQuanLyDuAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:QuanLyDuAn.FormsQuanLyDuAn.Forms  5      '    !QuanLyDuAn.Forms.DanhSachCongViec   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:QuanLyDuAn.Forms     5        � 	Resources  5	       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value	 ��Name&   System.Windows.Controls.DataGrid=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '��       '�� �    '  4    '  �    �� 5   
   " ��6   .�5      ��  � ��$
 10,5q�6(   �� 5       � ��$ 5q�6'   �� 5       � �� �#0078D76+   �� 5       � ��
 �����6+   �� 5       � ��$ 0q�60   �� 5       � ��$ 14(�6)   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 5��5      #��z��5      ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver$
 True��6=   . �5   "   ��  � �� �#005EA66?   5      P� 5       � ��$
 True��6;   . �5   "   ��  � �� �#003E756?   5       5"      5$      5%      �� 5(   
   " ��6   .�5)      ��  � ��$ 5q�6(   �� 5*       � ��$ 14(�6)   �� 5+       � �� �#D1D1D16,   �� 5,       � ��$ 1q�60   �� 5-       � �� 5.      �� 5/      " ��6&   .R�50      �� #��z��6!   #��z��51      #��z��52      $ 5��53      ._�54      �� $	 PART_ContentHost��6+   $��2q�6E   55      56      58      59      �� 5<   
   "  6   .�5=      ��  � �� �#D1D1D16,   �� 5>       � ��$ 1q�60   �� 5?       �@ RowBackground
 �����6.   �� 5@        �@ AlternatingRowBackground �#F5F5F569   �� 5A       �@ HeadersVisibility$ Column=�62   �� 5B       �@ GridLinesVisibility$ 
Horizontal=�64   �� 5C        �@ HorizontalGridLinesBrush �#E0E0E069   5D      �� 5G   
   "  6   .�5H      ��  � �� �#F0F0F06+   �� 5I       � ��$
 Bold"�6+   �� 5J       � ��$ 5q�6(   �� 5K       � ��$ 0,0,1,1q�60   �� 5L       � �� �#D1D1D16,   5M      5N      .��5O      � $��20q�6   
 � RowDefinitions
 5P   
   �� 5Q      $
��Auto �6   �� 5R      $��* �6   �� 5S      $
��Auto �6   .+�5W   
   �� $��0��6   $��Danh Sáchn công việc��5X   	   $��24(�5Y   	   $
��Bold"�5Z   	   ���#333333$��0,0,0,15q�5\   	   �� 5_   
   $��0��6    �� Orientation$ 
Horizontal=�5`   
   $��Right=�5a   
   .+�5b      �� -   5         ��Name$ 	SearchBox��5c      $	��250��5b      $��Tìm kiếm nhân viên��5d      �� 5e      $��Tìm kiếm��6   �� 5f      $��Thêm nhân viên��6   5g        5j   
   -   5          Name$ EmployeeDataGrid��5k      $��1��5j         AutoGenerateColumns$ False��5l         
IsReadOnly$
 True��5m         SelectionMode$ Single=�5n         CanUserSortColumns$
 True��5o      $��0,0,0,10q�5p         Columns 5q      4  .System.Windows.Controls.DataGridCheckBoxColumn  5r      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 5s      0  *System.Windows.Controls.DataGridTextColumn  5t      $ Mã công việc��6%   $ * 5v      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5u      �� *cv_Ma+5v        5w      $ Tên công việc��6%   $ * 5y       5x      �� *cv_Ten+5y        5z      $ Tên dự án��6%   $ * 5|       5{      �� *da_Ten+5|        5}      $ tiến độ��6%   $ * 5       5~      �� *	cv_TienDo+5        5�      $ Trạng thái��6%   $ * 5�       5�      �� *cv_TrangThai+5�      5�      �� 5�   
   -   5         ��Name$ TotalRecordsTextBlock��5�   	   $��2��5�      $��14(�5�   	   ���#666666$��0,5,0,0q�5�   	   5�      5�      