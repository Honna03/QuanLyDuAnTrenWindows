using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace QuanLyDuAn.Controls
{
    public partial class RegisterControl : UserControl
    {
        public event EventHandler RegisterSuccess;
        public event EventHandler BackToLoginRequested;

        public RegisterControl()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Password;
            string confirmPassword = txtConfirmPassword.Password;

            // Validation
            if (!ValidateInput(username, email, password, confirmPassword))
            {
                return;
            }

            // Thực hiện đăng ký
            if (RegisterUser(username, email, password))
            {
                RegisterSuccess?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.",
                              "Thành công",
                              MessageBoxButton.OK,
                              MessageBoxImage.Information);
            }
            else
            {
                ShowError("Đăng ký thất bại! Tên đăng nhập hoặc email đã tồn tại.");
            }
        }

        private void BackToLogin_Click(object sender, RoutedEventArgs e)
        {
            BackToLoginRequested?.Invoke(this, EventArgs.Empty);
        }

        private bool ValidateInput(string username, string email, string password, string confirmPassword)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                ShowError("Vui lòng điền đầy đủ thông tin!");
                return false;
            }

            // Kiểm tra độ dài username
            if (username.Length < 4 || username.Length > 20)
            {
                ShowError("Tên đăng nhập phải từ 4-20 ký tự!");
                return false;
            }

            // Kiểm tra định dạng email
            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                ShowError("Email không đúng định dạng!");
                return false;
            }

            // Kiểm tra độ dài và độ mạnh mật khẩu
            if (password.Length < 6)
            {
                ShowError("Mật khẩu phải ít nhất 6 ký tự!");
                return false;
            }

            // Kiểm tra xác nhận mật khẩu
            if (password != confirmPassword)
            {
                ShowError("Mật khẩu xác nhận không khớp!");
                return false;
            }

            return true;
        }

        private bool RegisterUser(string username, string email, string password)
        {
            // Logic đăng ký thực tế với database
            // Kiểm tra username và email đã tồn tại chưa
            // Lưu thông tin user
            return true; // Giả lập thành công
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}