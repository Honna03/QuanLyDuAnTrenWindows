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
using System.Windows.Shapes;

namespace QuanLyDuAn.Forms
{
    public partial class Luong : UserControl
    {
        private ObservableCollection<Employee> employees; // Danh sách hiển thị
        private List<Employee> allEmployees; // Danh sách gốc

        public Luong()
        {
            InitializeComponent();
            LoadSampleData();
            EmployeeDataGrid.ItemsSource = employees;
        }

        private void LoadSampleData()
        {
            // Tạo danh sách nhân viên mẫu
            allEmployees = new List<Employee>
{
    new Employee { FullName = "Châu Lâm Ngọc Phụng", Email = "chaulamngocphung@gmail.com", Salary = 15000000 },
    new Employee { FullName = "Lê Hà", Email = "ltha2@hcm.misa.com.vn", Salary = 12000000 },
    new Employee { FullName = "Nguyễn Huyền", Email = "nbhuyen@hcm.misa.com.vn", Salary = 18000000 },
    new Employee { FullName = "Trần Văn Nam", Email = "tranvannam@gmail.com", Salary = 14000000 },
    new Employee { FullName = "Phạm Thị Lan", Email = "phamthilan@hcm.misa.com.vn", Salary = 16000000 },
    new Employee { FullName = "Hoàng Minh Tuấn", Email = "hoangminhtuan@gmail.com", Salary = 13000000 },
    new Employee { FullName = "Đỗ Thị Hồng", Email = "dothihong@hcm.misa.com.vn", Salary = 17500000 },
    new Employee { FullName = "Nguyễn Văn Hùng", Email = "nguyenvanhung@gmail.com", Salary = 14500000 },
    new Employee { FullName = "Lê Thị Mai", Email = "lethimai@hcm.misa.com.vn", Salary = 15500000 },
    new Employee { FullName = "Vũ Quốc Anh", Email = "vuquocanh@gmail.com", Salary = 16500000 },
    new Employee { FullName = "Trương Thị Ngọc", Email = "truongthingoc@hcm.misa.com.vn", Salary = 12500000 },
    new Employee { FullName = "Bùi Văn Long", Email = "buivanlong@gmail.com", Salary = 17000000 },
    new Employee { FullName = "Phan Thị Thu", Email = "phanthithu@hcm.misa.com.vn", Salary = 13500000 },
    new Employee { FullName = "Đặng Minh Khoa", Email = "dangminhkhoa@gmail.com", Salary = 18500000 },
    new Employee { FullName = "Ngô Thị Hà", Email = "ngothiha@hcm.misa.com.vn", Salary = 15000000 },
    new Employee { FullName = "Lý Văn Phong", Email = "lyvanphong@gmail.com", Salary = 14000000 },
    new Employee { FullName = "Hà Thị Bích", Email = "hathibich@hcm.misa.com.vn", Salary = 16000000 },
    new Employee { FullName = "Trần Quốc Bảo", Email = "tranquocbao@gmail.com", Salary = 14500000 },
    new Employee { FullName = "Nguyễn Thị Linh", Email = "nguyenthilinh@hcm.misa.com.vn", Salary = 17500000 },
    new Employee { FullName = "Võ Văn Thành", Email = "vovanthanh@gmail.com", Salary = 13000000 },
    new Employee { FullName = "Đoàn Thị Yến", Email = "doanthiyen@hcm.misa.com.vn", Salary = 15500000 },
    new Employee { FullName = "Phùng Minh Đức", Email = "phungminhduc@gmail.com", Salary = 16500000 },
    new Employee { FullName = "Lê Thị Thảo", Email = "lethithao@hcm.misa.com.vn", Salary = 14000000 },
    new Employee { FullName = "Nguyễn Văn Tâm", Email = "nguyenvantam@gmail.com", Salary = 17000000 },
    new Employee { FullName = "Trần Thị Hương", Email = "tranthihuong@hcm.misa.com.vn", Salary = 12500000 },
    new Employee { FullName = "Hoàng Văn Dũng", Email = "hoangvandung@gmail.com", Salary = 18000000 },
    new Employee { FullName = "Phạm Thị Minh", Email = "phamthiminh@hcm.misa.com.vn", Salary = 13500000 },
    new Employee { FullName = "Đỗ Văn Quang", Email = "dovanquang@gmail.com", Salary = 15000000 },
    new Employee { FullName = "Lê Thị Ngọc Ánh", Email = "lethingocanh@hcm.misa.com.vn", Salary = 16000000 },
    new Employee { FullName = "Nguyễn Quốc Hưng", Email = "nguyenquochung@gmail.com", Salary = 14500000 },
    new Employee { FullName = "Trần Thị Kim Oanh", Email = "tranthikimoanh@hcm.misa.com.vn", Salary = 17500000 },
    new Employee { FullName = "Vũ Văn Bình", Email = "vuvanbinh@gmail.com", Salary = 13000000 },
    new Employee { FullName = "Phan Thị Thanh", Email = "phanthithanh@hcm.misa.com.vn", Salary = 15500000 },
    new Employee { FullName = "Bùi Minh Trí", Email = "buiminh tri@gmail.com", Salary = 16500000 }
};

            // Khởi tạo danh sách hiển thị
            employees = new ObservableCollection<Employee>(allEmployees);

            // Cập nhật tổng số bản ghi
            UpdateRecordCount();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchBox.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(searchText) || searchText == "tìm kiếm nhân viên")
            {
                employees.Clear();
                foreach (var emp in allEmployees)
                {
                    employees.Add(emp);
                }
            }
            else
            {
                var filteredEmployees = allEmployees
                    .Where(emp => emp.FullName.ToLower().Contains(searchText))
                    .ToList();

                employees.Clear();
                foreach (var emp in filteredEmployees)
                {
                    employees.Add(emp);
                }
            }
            UpdateRecordCount();
        }

        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == "Tìm kiếm nhân viên")
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }

        private void SearchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Tìm kiếm nhân viên";
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = SearchBox.Text.ToLower();
            if (searchText == "tìm kiếm nhân viên" || string.IsNullOrWhiteSpace(searchText))
            {
                employees.Clear();
                foreach (var emp in allEmployees)
                {
                    employees.Add(emp);
                }
            }
            else
            {
                var filteredEmployees = allEmployees
                    .Where(emp => emp.FullName.ToLower().Contains(searchText))
                    .ToList();

                employees.Clear();
                foreach (var emp in filteredEmployees)
                {
                    employees.Add(emp);
                }
            }
            UpdateRecordCount();
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            var editWindow = new EditLuong(null);
            if (editWindow.ShowDialog() == true)
            {
                employees.Add(editWindow.Employee);
                allEmployees.Add(editWindow.Employee);
                UpdateRecordCount();
            }
        }

        private void EditEmployee_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var employee = button.DataContext as Employee;
            var editWindow = new EditLuong(employee);
            if (editWindow.ShowDialog() == true)
            {
                var index = allEmployees.FindIndex(emp => emp == employee);
                if (index != -1)
                {
                    allEmployees[index] = editWindow.Employee;
                }
            }
        }

        private void DeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var employee = button.DataContext as Employee;
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {employee.FullName}?",
                "Xác nhận xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                employees.Remove(employee);
                allEmployees.Remove(employee);
                UpdateRecordCount();
            }
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

    public class Employee
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
    }
}