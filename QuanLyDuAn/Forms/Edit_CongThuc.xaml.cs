using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Edit_CongThuc.xaml
    /// </summary>
    public partial class Edit_CongThuc : UserControl
    {
        private List<Component> components;
        public Edit_CongThuc()
        {
            InitializeComponent();
            LoadSampleData(); // Tải dữ liệu mẫu
        }
        // Tải dữ liệu mẫu
        private void LoadSampleData()
        {
            components = new List<Component>
            {
                new Component { STT = 1, Tu = "91", Den = "100", TiLe = "A" },
                new Component { STT = 2, Tu = "81", Den = "90", TiLe = "B" },
                new Component { STT = 3, Tu = "71", Den = "80", TiLe = "C" },
                new Component { STT = 4, Tu = "51", Den = "70", TiLe = "D" },
                new Component { STT = 5, Tu = "1", Den = "50", TiLe = "E" }
            };
            icComponents.ItemsSource = components;
            UpdateNewSTT(); // Cập nhật STT cho hàng nhập liệu mới
        }

        // Cập nhật STT cho hàng nhập liệu mới
        private void UpdateNewSTT()
        {
            txtNewSTT.Text = (components.Count + 1).ToString();
        }

        private void AddUpdateComponent_Click(object sender, RoutedEventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(txtNewTu.Text) || string.IsNullOrWhiteSpace(txtNewDen.Text) || string.IsNullOrWhiteSpace(txtNewTiLe.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Từ, Đến và Tỉ lệ!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Thêm một hàng mới vào danh sách
            components.Add(new Component
            {
                STT = components.Count + 1,
                Tu = txtNewTu.Text,
                Den = txtNewDen.Text,
                TiLe = txtNewTiLe.Text
            });

            // Cập nhật lại ItemsSource
            icComponents.ItemsSource = null;
            icComponents.ItemsSource = components;

            // Xóa các TextBox nhập liệu
            txtNewTu.Text = "";
            txtNewDen.Text = "";
            txtNewTiLe.Text = "";

            // Cập nhật STT cho hàng nhập liệu mới
            UpdateNewSTT();
        }
        // Định nghĩa lớp Component
        public class Component
        {
            public int STT { get; set; }
            public string Tu { get; set; }
            public string Den { get; set; }
            public string TiLe { get; set; }
        }
    }
}
