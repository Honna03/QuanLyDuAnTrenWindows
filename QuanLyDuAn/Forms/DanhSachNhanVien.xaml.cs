using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyDuAn.Forms
{
    /// <summary>
    /// Interaction logic for DanhSachNhanVien.xaml
    /// </summary>
    public partial class DanhSachNhanVien : UserControl
    {
        private ObservableCollection<Employee> employees; // Danh sách hiển thị
        private List<Employee> allEmployees; // Danh sách gốc
        public DanhSachNhanVien()
        {
            InitializeComponent();
            LoadSampleData();
            EmployeeDataGrid.ItemsSource = employees;
        }
        public class Employee
        {
            public string nv_Ma { get; set; }
            public string nv_Ten { get; set; }
            public string nv_GioiTinh { get; set; }
            public DateTime nv_NgaySinh { get; set; }
            public string nv_ChucVu { get; set; }
        }
        private void LoadSampleData()
        {
            // Tạo danh sách nhân viên mẫu với các trường mới
            allEmployees = new List<Employee>
            {
                new Employee { nv_Ma = "NV001", nv_Ten = "Châu Lâm Ngọc Phụng", nv_GioiTinh = "Nữ", nv_NgaySinh = new DateTime(1990, 5, 15), nv_ChucVu = "Giám đốc" },
                new Employee { nv_Ma = "NV002", nv_Ten = "Lê Hà", nv_GioiTinh = "Nữ", nv_NgaySinh = new DateTime(1985, 8, 22), nv_ChucVu = "Trưởng phòng" },
                new Employee { nv_Ma = "NV003", nv_Ten = "Nguyễn Huyền", nv_GioiTinh = "Nữ", nv_NgaySinh = new DateTime(1992, 3, 10), nv_ChucVu = "Nhân viên" },
                new Employee { nv_Ma = "NV004", nv_Ten = "Trần Văn Nam", nv_GioiTinh = "Nam", nv_NgaySinh = new DateTime(1988, 12, 5), nv_ChucVu = "Trưởng phòng" },
                new Employee { nv_Ma = "NV005", nv_Ten = "Phạm Thị Lan", nv_GioiTinh = "Nữ", nv_NgaySinh = new DateTime(1991, 7, 19), nv_ChucVu = "Giám sát" },
                new Employee { nv_Ma = "NV006", nv_Ten = "Hoàng Minh Tuấn", nv_GioiTinh = "Nam", nv_NgaySinh = new DateTime(1993, 4, 11), nv_ChucVu = "Nhân viên" },
                new Employee { nv_Ma = "NV007", nv_Ten = "Đỗ Thị Hồng", nv_GioiTinh = "Nữ", nv_NgaySinh = new DateTime(1989, 10, 2), nv_ChucVu = "Giám sát" },
                new Employee { nv_Ma = "NV008", nv_Ten = "Nguyễn Văn Hùng", nv_GioiTinh = "Nam", nv_NgaySinh = new DateTime(1990, 1, 25), nv_ChucVu = "Trưởng phòng" },
                new Employee { nv_Ma = "NV009", nv_Ten = "Lê Thị Mai", nv_GioiTinh = "Nữ", nv_NgaySinh = new DateTime(1995, 6, 8), nv_ChucVu = "Nhân viên" },
                new Employee { nv_Ma = "NV010", nv_Ten = "Vũ Quốc Anh", nv_GioiTinh = "Nam", nv_NgaySinh = new DateTime(1987, 9, 15), nv_ChucVu = "Nhân viên" },
                new Employee { nv_Ma = "NV011", nv_Ten = "Trương Thị Ngọc", nv_GioiTinh = "Nữ", nv_NgaySinh = new DateTime(1996, 12, 1), nv_ChucVu = "Nhân viên" },
                new Employee { nv_Ma = "NV012", nv_Ten = "Bùi Văn Long", nv_GioiTinh = "Nam", nv_NgaySinh = new DateTime(1986, 4, 20), nv_ChucVu = "Giám sát" },
                new Employee { nv_Ma = "NV013", nv_Ten = "Phan Thị Thu", nv_GioiTinh = "Nữ", nv_NgaySinh = new DateTime(1993, 11, 30), nv_ChucVu = "Nhân viên" },
                new Employee { nv_Ma = "NV014", nv_Ten = "Đặng Minh Khoa", nv_GioiTinh = "Nam", nv_NgaySinh = new DateTime(1994, 7, 13), nv_ChucVu = "Giám sát" },
                new Employee { nv_Ma = "NV015", nv_Ten = "Ngô Thị Hà", nv_GioiTinh = "Nữ", nv_NgaySinh = new DateTime(1988, 5, 6), nv_ChucVu = "Trưởng phòng" },
                new Employee { nv_Ma = "NV016", nv_Ten = "Lý Văn Phong", nv_GioiTinh = "Nam", nv_NgaySinh = new DateTime(1991, 3, 24), nv_ChucVu = "Nhân viên" },
                new Employee { nv_Ma = "NV017", nv_Ten = "Hà Thị Bích", nv_GioiTinh = "Nữ", nv_NgaySinh = new DateTime(1990, 9, 19), nv_ChucVu = "Giám đốc" },
                new Employee { nv_Ma = "NV018", nv_Ten = "Trần Quốc Bảo", nv_GioiTinh = "Nam", nv_NgaySinh = new DateTime(1992, 6, 14), nv_ChucVu = "Nhân viên" },
                new Employee { nv_Ma = "NV019", nv_Ten = "Nguyễn Thị Linh", nv_GioiTinh = "Nữ", nv_NgaySinh = new DateTime(1994, 10, 7), nv_ChucVu = "Giám sát" },
                new Employee { nv_Ma = "NV020", nv_Ten = "Võ Văn Thành", nv_GioiTinh = "Nam", nv_NgaySinh = new DateTime(1995, 1, 3), nv_ChucVu = "Trưởng phòng" }
            };

            // Khởi tạo danh sách hiển thị
            employees = new ObservableCollection<Employee>(allEmployees);

            // Cập nhật tổng số bản ghi
            UpdateRecordCount();
        }
        private void UpdateRecordCount()
        {
            // Cập nhật TextBlock hiển thị tổng số bản ghi
            var totalRecordsTextBlock = (TextBlock)FindName("TotalRecordsTextBlock");
            if (totalRecordsTextBlock != null)
            {
                totalRecordsTextBlock.Text = $"Tổng số bản ghi: {employees.Count}";
            }
        }
    }
}
