using System;
using System.Collections.Generic;
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
    /// Interaction logic for EditLuong.xaml
    /// </summary>
    public partial class EditLuong : Window
    {
        public Employee Employee { get; private set; }
        public EditLuong(Employee employee)
        {
            InitializeComponent();
            Employee = employee ?? new Employee();

            // Nếu là chỉnh sửa, điền thông tin vào các ô
            if (employee != null)
            {
                FullNameTextBox.Text = employee.FullName;
                EmailTextBox.Text = employee.Email;
                SalaryTextBox.Text = employee.Salary.ToString();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string fullName = FullNameTextBox.Text;
            string email = EmailTextBox.Text;
            string salary = SalaryTextBox.Text;

            // Kiểm tra dữ liệu (ví dụ: không để trống)
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(salary))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Thêm logic lưu dữ liệu vào cơ sở dữ liệu hoặc danh sách ở đây
            // Ví dụ: Gọi một phương thức để lưu dữ liệu
            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

            // Đóng form EditLuong sau khi lưu thành công
            this.Close();
        }

        // Xử lý sự kiện khi nhấn nút "Hủy"
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            // Xóa dữ liệu trong form hoặc đóng UserControl
            ClearForm();

            // Nếu bạn muốn đóng UserControl, bạn có thể tìm parent Window và ẩn nó
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close(); // Đóng cửa sổ chứa UserControl
            }
        }

        // Phương thức hỗ trợ để xóa dữ liệu trong form
        private void ClearForm()
        {
            FullNameTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            SalaryTextBox.Text = string.Empty;
        }
        private void SalaryTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static bool IsTextAllowed(string text)
        {
            return text.All(char.IsDigit);
        }

    }
}