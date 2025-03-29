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
    /// Interaction logic for DanhSachCongViec.xaml
    /// </summary>
    public partial class DanhSachCongViec : UserControl
    {
        private ObservableCollection<Employee> employees; // Danh sách hiển thị
        private List<Employee> allEmployees; // Danh sách gốc
        public DanhSachCongViec()
        {
            InitializeComponent();
            LoadSampleData();
            EmployeeDataGrid.ItemsSource = employees;
        }
        public class Employee
        {
            public string cv_Ma { get; set; }
            public string cv_Ten { get; set; }
            public string da_Ten { get; set; }
            public Decimal cv_TienDo { get; set; }
            public string cv_TrangThai { get; set; }
        }
        private void LoadSampleData()
        {
            // Tạo danh sách nhân viên mẫu với các trường mới
            allEmployees = new List<Employee>
            {
                new Employee { cv_Ma = "CV001", cv_Ten = "Phân tích yêu cầu", da_Ten = "Dự án A", cv_TienDo = 100, cv_TrangThai = "Hoàn thành" },
                new Employee { cv_Ma = "CV002", cv_Ten = "Thiết kế hệ thống", da_Ten = "Dự án B", cv_TienDo = 70, cv_TrangThai = "Đang thực hiện" },
                new Employee { cv_Ma = "CV003", cv_Ten = "Lập trình module", da_Ten = "Dự án C", cv_TienDo = 0, cv_TrangThai = "Chưa bắt đầu" },
                new Employee { cv_Ma = "CV004", cv_Ten = "Kiểm thử", da_Ten = "Dự án D", cv_TienDo = 100, cv_TrangThai = "Hoàn thành" },
                new Employee { cv_Ma = "CV005", cv_Ten = "Triển khai hệ thống", da_Ten = "Dự án E", cv_TienDo = 50, cv_TrangThai = "Đang thực hiện" },
                new Employee { cv_Ma = "CV006", cv_Ten = "Bảo trì", da_Ten = "Dự án F", cv_TienDo = 0, cv_TrangThai = "Chưa bắt đầu" },
                new Employee { cv_Ma = "CV007", cv_Ten = "Nâng cấp hệ thống", da_Ten = "Dự án G", cv_TienDo = 40, cv_TrangThai = "Đang thực hiện" }
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
