   M S B A M L   `   `   `  ����E  AQuanLyDuAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:QuanLyDuAn.FormsQuanLyDuAn.Forms  5          QuanLyDuAn.Forms.KPI   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:QuanLyDuAn.Forms     5      .��5	      � .+�5   
   �� $��Danh sách KPI��6   $��20(�5      $
��Bold"�6"   
�������$��	10,10,0,0q�5      �� 5   
   -   5          ��Name$  btn_AddCongThuc��5      $��+ Thêm công thức��5      $��Right=�5      $	��Top=�5      $��	0,10,10,0q�5      $
��10,5q�5      ���#27AE60
�������$
��Bold"�5      $��0q�5       � Cursor$
 Hand��6%   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgKPI��5         AutoGenerateColumns$ False��6       HeadersVisibility$ Column=�5         CanUserAddRows$ False��5         SelectionMode$ Single=�5      $��10,50,10,10q�5       
����������#E0E0E0$��1q�5!   <      GridLinesVisibility$ 
Horizontal=�5"         HorizontalGridLinesBrush �#E0E0E0   RowBackground
 �����	   AlternatingRowBackground	 �#F9F9F9
   Columns
 5$      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6J      
IsReadOnly$
 True��6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *STT+   ElementStyle 5'      �� 5(       �� 
TargetType" ��6    .�5)      ��  �� Property � �� �� Value$ Center=�6D   �� 5*       � ��$ Center=�6B   5+         HeaderStyle 5-      �� 5.      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .�5/      ��  � �� �#2D2D2D6;   �� 50       � ��
 �����6;   �� 51       � ��$ 0q�6@   �� 52       � ��$ 5q�68   53      55        58      $ Mã KPI��6%   $	 100 6O    65   �� *MaKPI+ 59      �� 5:      " ��6    .�5;      ��  � ��$	 5,0q�67   5<       5>      �� 5?      "  6    .�5@      ��  � �� �#2D2D2D6;   �� 5A       � ��
 �����6;   �� 5B       � ��$ 0q�6@   �� 5C       � ��$ 5q�68   5D      5F      4  .System.Windows.Controls.DataGridTemplateColumn  5I      $ Tên KPI��6)   $	 150 6:      CellTemplate 5J      �� 5K      .R�5L      ��  �� Orientation$ 
Horizontal=�6)   $��Center=�6B   .+�5M   "   �� ���#3498DB$
 Hand��5O   ,   $	��5,0q�5P   ,   ��5M   ,   �� *TenKPI+5P   ,   �� 5Q   "   $  btn_CongThuc��5U   )   $	��➕��5Q   )   
������ ���#27AE60$��0q�5R   >   $
 Hand��5S   )   $	��5,0q�67    � ToolTip$ Thêm KPI mới��5T   )   5U   )   �� 5V   "   $��✏️��6)   
������ ���#F1C40F$��0q�5W   >   $
 Hand��5X   )   $	��5,0q�67   $ 	Sửa KPI��5Y   )   �� 5Z   "   $��🗑️��6)   
������ ���#E74C3C$��0q�5[   >   $
 Hand��5\   )   $	��5,0q�67   $ Xóa KPI��5]   )   5^      5_       5a      �� 5b      "  6    .�5c      ��  � �� �#2D2D2D6;   �� 5d       � ��
 �����6;   �� 5e       � ��$ 0q�6@   �� 5f       � ��$ 5q�68   5g      5i        5l      $ Mô tả��6%   $ 2* 6M    64   �� *MoTa+ 5m      �� 5n      " ��6    .�5o      ��  � ��$	 5,0q�67   �� 5p       � ��$
 Wrap=�6=   5q       5s      �� 5t      "  6    .�5u      ��  � �� �#2D2D2D6;   �� 5v       � ��
 �����6;   �� 5w       � ��$ 0q�6@   �� 5x       � ��$ 5q�68   5y      5{        5~      $ Loại công thức��6%   $ 80 6W    6=   �� *DonVi+ 5      �� 5�      " ��6    .�5�      ��  � ��$	 5,0q�67   �� 5�       � ��$ Center=�6D   5�       5�      �� 5�      "  6    .�5�      ��  � �� �#2D2D2D6;   �� 5�       � ��
 �����6;   �� 5�       � ��$ 0q�6@   �� 5�       � ��$ 5q�68   5�      5�        5�      $ Ngày tạo��6%   $	 100 6r    67   �� *	NgayTao+ �� StringFormat$ {0:dd/MM/yyyy}�� 5�      �� 5�      " ��6    .�5�      ��  � ��$	 5,0q�67   �� 5�       � ��$ Center=�6D   5�       5�      �� 5�      "  6    .�5�      ��  � �� �#2D2D2D6;   �� 5�       � ��
 �����6;   �� 5�       � ��$ 0q�6@   �� 5�       � ��$ 5q�68   5�      5�        5�      $ Ngày kết thúc��6%   $	 100 6{    6<   �� *NgayKetThuc+$ {0:dd/MM/yyyy}�� 5�      �� 5�      " ��6    .�5�      ��  � ��$	 5,0q�67   �� 5�       � ��$ Center=�6D   5�       5�      �� 5�      "  6    .�5�      ��  � �� �#2D2D2D6;   �� 5�       � ��
 �����6;   �� 5�       � ��$ 0q�6@   �� 5�       � ��$ 5q�68   5�      5�        5�      $ Trạng thái��6%   $	 100 6W    69   �� *	TrangThai+ 5�      �� 5�      " ��6    .�5�      ��  � ��$	 5,0q�67   �� 5�       � ��$ Center=�6D   5�       5�      �� 5�      "  6    .�5�      ��  � �� �#2D2D2D6;   �� 5�       � ��
 �����6;   �� 5�       � ��$ 0q�6@   �� 5�       � ��$ 5q�68   5�      5�        5�      $ Người tạo��6%   $	 120 6U    68   �� *
NguoiTao+ 5�      �� 5�      " ��6    .�5�      ��  � ��$	 5,0q�67   5�       5�      �� 5�      "  6    .�5�      ��  � �� �#2D2D2D6;   �� 5�       � ��
 �����6;   �� 5�       � ��$ 0q�6@   �� 5�       � ��$ 5q�68   5�      5�        5�      $ Người báo cáo��6%   $	 120 6\    6<   �� *NguoiBaoCao+ 5�      �� 5�      " ��6    .�5�      ��  � ��$	 5,0q�67   5�       5�      �� 5�      "  6    .�5�      ��  � �� �#2D2D2D6;   �� 5�       � ��
 �����6;   �� 5�       � ��$ 0q�6@   �� 5�       � ��$ 5q�68   5�      5�      5�      5�      5�      