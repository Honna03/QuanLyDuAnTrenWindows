   M S B A M L   `   `   `  ����  
QuanLyDuAn)    #QuanLyDuAn.Controls.ProjectsControl   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5	   
   �� 5
      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� ���#F7FAFC �� Padding$ 10q�5      ���#E2E8F0$��0,0,0,1q�5      ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ btnAddProject��5      $��Thêm dự án��5         MaterialButton#��[  5      ���#48BB78$	��120��5      $��0,0,10,0q�5      �� 5      -   5        $ btnEditProject��5      $��Sửa��5      #��[  5      ���#3182CE$��80��5       $��0,0,10,0q�5!      ${�False��5"      �� 5#      -   5        $ btnDeleteProject��5#      $
��Xóa��5%      #��[  5&      ���#E53E3E$��80��5(      $��0,0,10,0q�5)      ${�False��5*      �� 5+      -   5         ��Name$ 	txtFilter��5+        MaterialTextBox#��[ 5,      
 � Tag$ Tìm kiếm dự án��5-      $	��200��5.      $��0,0,10,0q�5/      50      51      52      &   System.Windows.Controls.DataGrid  55   
   -   5          Name$ projectsGrid��55      $��1��56      $��0,10,0,0q�57         AutoGenerateColumns$ False��58         CanUserAddRows$ False��59      	   SelectionMode$	 Single=�5:        MaterialDataGrid#��[ 5<      
   Columns
 5=      0  *System.Windows.Controls.DataGridTextColumn  5>      ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 5@   #      
IsReadOnly$
 True��5A   #   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5?   #   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType)  #System.Windows.Controls.DataGridRow"   �� Path$ GetIndex�  IndexConverter �� 	Converter# [ 5A   #     5B      $ Tên dự án��6%   $ 2* 5D   #   $
 True��5E   #    5C   #   �� *Name+5E   #     5F      $ Người tạo��6%   $ * 5H   #   $
 True��5I   #    5G   #   �� *	CreatedBy+5I   #     5J      $ Số thành viên��6%   $ * 5L   #   $
 True��5M   #    5K   #   �� *MemberCount+5M   #     5N      $ Ngày bắt đầu��6%   $ * 5P   #   $
 True��5Q   #    5O   #   �� *	StartDate+ �� StringFormat$ d/M/yyyy��5Q   #     5R      $ Ngày kết thúc��6%   $ * 5T   #   $
 True��5U   #    5S   #   �� *	EndDate+$ d/M/yyyy��5U   #     5V      $ Trạng thái��6%   $ * 5X   #   $
 True��5Y   #    5W   #   �� *Status+5Y   #   4  .System.Windows.Controls.DataGridTemplateColumn  5Z      $ Tiến độ��6)   $ * 6:      CellTemplate 5[      �� 5\      .R�5]      �  � Maximum$	 100Q�5^   (   $��20��5_   (   ���#48BB78 � Value 5]   *   �� *
Progress+5`   (   5a      5c      5e      � 5h   
   -   5         �Name$ projectPopup��5h      $��Center=�5i       � 	StaysOpen$ False��5j       � AllowsTransparency$
 True��5k      .��5l      �� 
�������$ 20q�5m      $	��400��5n       �� CornerRadius$ 10��5o        MaterialDesignShadow J� Effect# [ 5p      ._�5q      �� .+�5r      �� -   5         ��Name$ 
popupTitle��5r       $��20(�5s      $
��Bold"�5t      $��0,0,0,20q�5u      �� 5w      -   5        $ txtProjectName��5w      #��[ 5x      $ Tên dự án��5y      $��0,0,0,15q�5z      �� 5|      -	   5        $ txtCreatedBy��5|      #��[ 5}      $ Người tạo��5~      $��0,0,0,15q�5      ${�False��5�      (  "System.Windows.Controls.DatePicker  5�      -
   5          Name$ dpStartDate��5�   !   $��0,0,0,15q�5�         DisplayDateStart 5�      �� *DateTime.Today+  5�      -   5        $ 	dpEndDate��5�   !   $��0,0,0,15q�5�       5�      �� *DateTime.Today+�� 5�      -   5        $ txtMemberCount��5�      #��[ 5�      $ Số thành viên��5�      $��0,0,0,15q�5�      �� 5�      -   5        $ txtProgress��5�      #��[ 5�      $ Tiến độ (%)��5�      $��0,0,0,20q�5�      �� 5�      $ 
Horizontal=�6!   $��Right=�5�      .+�5�      �� -   5        $ btnSavePopup��5�   !   $
��Lưu��5�   !   #��[  5�   !   ���#48BB78$	��100��5�   !   $��0,0,10,0q�5�   !   �� 5�      -   5        $ btnCancelPopup��5�   !   $��Hủy��5�   !   #��[  5�   !   ���#E53E3E$	��100��5�   !   5�      5�      5�      5�      5�      5�      