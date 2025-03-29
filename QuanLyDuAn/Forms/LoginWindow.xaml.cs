using System;
using System.Windows;
using System.Windows.Controls;

namespace QuanLyDuAn.Controls
{
    public partial class LoginControl : UserControl
    {
        public event EventHandler LoginSuccess;
        public event EventHandler RegisterRequested;

        public LoginControl()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (ValidateLogin(username, password))
            {
                LoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                ShowError("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            // Hiển thị form đăng ký hoặc kích hoạt event
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ShowError("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if (RegisterUser(username, password))
            {
                RegisterRequested?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.",
                              "Thành công",
                              MessageBoxButton.OK,
                              MessageBoxImage.Information);
            }
            else
            {
                ShowError("Đăng ký thất bại!");
            }
        }

        private void ForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            if (string.IsNullOrEmpty(username))
            {
                ShowError("Vui lòng nhập tên đăng nhập để khôi phục mật khẩu!");
                return;
            }

            // Logic gửi email khôi phục mật khẩu
            bool resetSuccess = ResetPassword(username);
            if (resetSuccess)
            {
                MessageBox.Show("Đã gửi link khôi phục đến email của bạn!",
                              "Thành công",
                              MessageBoxButton.OK,
                              MessageBoxImage.Information);
            }
            else
            {
                ShowError("Không tìm thấy tài khoản!");
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            // Logic kiểm tra đăng nhập
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
        }

        private bool RegisterUser(string username, string password)
        {
            // Logic đăng ký user
            // Trong thực tế cần kiểm tra username đã tồn tại chưa và lưu vào database
            return true; // Giả lập thành công
        }

        private bool ResetPassword(string username)
        {
            // Logic khôi phục mật khẩu
            // Trong thực tế cần gửi email với link reset
            return true; // Giả lập thành công
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}