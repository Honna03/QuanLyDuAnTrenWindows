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
    /// Interaction logic for CongThucKPI.xaml
    /// </summary>
    public partial class CongThucKPI : UserControl
    {
        public CongThucKPI()
        {
            InitializeComponent();
            LoadSampleData(); // Tải dữ liệu mẫu
        }
        // Tải dữ liệu mẫu
        private void LoadSampleData()
        {
            var formulas = new List<Formula>
            {
                new Formula { STT = 1, TenCongThuc = "Công thức A", LoaiCongThuc = "Tỷ lệ", MoTa = "Đo lường tỷ lệ hoàn thành công việc", NguoiTao = "Nguyễn Văn A", NgayTao = DateTime.Now.AddDays(-10) },
                new Formula { STT = 2, TenCongThuc = "Công thức B", LoaiCongThuc = "Hiệu suất", MoTa = "Đo lường hiệu suất dự án", NguoiTao = "Trần Thị B", NgayTao = DateTime.Now.AddDays(-5) },
                new Formula { STT = 3, TenCongThuc = "Công thức C", LoaiCongThuc = "Chi phí", MoTa = "Tính toán chi phí vượt ngân sách", NguoiTao = "Lê Văn C", NgayTao = DateTime.Now }
            };
            dgKPI.ItemsSource = formulas; // Sử dụng ItemsControl thay vì DataGrid
        }
        public class Formula
        {
            public int STT { get; set; }
            public string TenCongThuc { get; set; }
            public string LoaiCongThuc { get; set; }
            public string MoTa { get; set; }
            public string NguoiTao { get; set; }
            public DateTime NgayTao { get; set; }
        }

        private void btn_CongThuc_Click(object sender, RoutedEventArgs e)
        {
            Window editWindow = new Window
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            Edit_CongThuc editControl = new Edit_CongThuc();
            editWindow.Content = editControl;

            // Hiển thị cửa sổ dưới dạng modal (khóa cửa sổ cha cho đến khi đóng)
            editWindow.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window
            {
                Content = new Edit_KPI(),
            };
            window.Show();
        }
    }
}
