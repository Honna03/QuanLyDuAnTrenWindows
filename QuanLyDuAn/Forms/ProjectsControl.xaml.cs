using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace QuanLyDuAn.Controls
{
    public partial class ProjectsControl : UserControl
    {
        private List<Project> projects;
        private List<Project> allProjects;
        private bool isEditMode;

        public class Project
        {
            public string Name { get; set; }
            public string CreatedBy { get; set; }
            public int MemberCount { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Status { get; set; }
            public double Progress { get; set; }
        }

        public ProjectsControl()
        {
            InitializeComponent();
            LoadProjects();
        }

        private void LoadProjects()
        {
            allProjects = new List<Project>
            {
                new Project { Name = "Dự án A", CreatedBy = "Nguyen Van A", MemberCount = 5, StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3), Status = "Đang thực hiện", Progress = 40 },
                new Project { Name = "Dự án B", CreatedBy = "Tran Thi B", MemberCount = 3, StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddMonths(1), Status = "Đang thực hiện", Progress = 75 }
            };
            projects = new List<Project>(allProjects);
            projectsGrid.ItemsSource = projects;
        }

        private void BtnAddProject_Click(object sender, RoutedEventArgs e)
        {
            isEditMode = false;
            popupTitle.Text = "Thêm dự án mới";
            txtProjectName.Text = "";
            txtCreatedBy.Text = "Current User";
            dpStartDate.SelectedDate = DateTime.Today;
            dpEndDate.SelectedDate = null;
            txtMemberCount.Text = "0";
            txtProgress.Text = "0";
            projectPopup.IsOpen = true;
        }

        private void BtnEditProject_Click(object sender, RoutedEventArgs e)
        {
            if (projectsGrid.SelectedItem is Project selectedProject)
            {
                isEditMode = true;
                popupTitle.Text = "Sửa dự án";
                txtProjectName.Text = selectedProject.Name;
                txtCreatedBy.Text = selectedProject.CreatedBy;
                dpStartDate.SelectedDate = selectedProject.StartDate;
                dpEndDate.SelectedDate = selectedProject.EndDate;
                txtMemberCount.Text = selectedProject.MemberCount.ToString();
                txtProgress.Text = selectedProject.Progress.ToString();
                projectPopup.IsOpen = true;
            }
        }

        private void BtnDeleteProject_Click(object sender, RoutedEventArgs e)
        {
            if (projectsGrid.SelectedItem is Project selectedProject)
            {
                var result = MessageBox.Show($"Xác nhận xóa dự án '{selectedProject.Name}'?",
                                          "Xác nhận",
                                          MessageBoxButton.YesNo,
                                          MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    projects.Remove(selectedProject);
                    allProjects.Remove(selectedProject);
                    projectsGrid.Items.Refresh();
                    UpdateButtonStates();
                }
            }
        }

        private void BtnSavePopup_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInput()) return;

            Project project = isEditMode ? projectsGrid.SelectedItem as Project : new Project();
            project.Name = txtProjectName.Text;
            project.CreatedBy = txtCreatedBy.Text;
            project.StartDate = dpStartDate.SelectedDate.Value;
            project.EndDate = dpEndDate.SelectedDate.Value;
            project.MemberCount = int.Parse(txtMemberCount.Text);
            project.Progress = double.Parse(txtProgress.Text);
            project.Status = project.Progress == 100 ? "Hoàn thành" : "Đang thực hiện";

            if (!isEditMode)
            {
                projects.Add(project);
                allProjects.Add(project);
            }

            projectsGrid.Items.Refresh();
            projectPopup.IsOpen = false;
        }

        private void BtnCancelPopup_Click(object sender, RoutedEventArgs e)
        {
            projectPopup.IsOpen = false;
        }

        private void ProjectsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateButtonStates();
        }

        private void TxtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filterText = txtFilter.Text.ToLower();
            projects = allProjects.Where(p =>
                p.Name.ToLower().Contains(filterText) ||
                p.CreatedBy.ToLower().Contains(filterText) ||
                p.Status.ToLower().Contains(filterText)).ToList();
            projectsGrid.ItemsSource = projects;
            projectsGrid.Items.Refresh();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtProjectName.Text))
            {
                ShowError("Vui lòng nhập tên dự án!");
                return false;
            }
            if (!dpStartDate.SelectedDate.HasValue)
            {
                ShowError("Vui lòng chọn ngày bắt đầu!");
                return false;
            }
            if (!dpEndDate.SelectedDate.HasValue)
            {
                ShowError("Vui lòng chọn ngày kết thúc!");
                return false;
            }
            if (dpEndDate.SelectedDate < dpStartDate.SelectedDate)
            {
                ShowError("Ngày kết thúc phải sau ngày bắt đầu!");
                return false;
            }
            if (!int.TryParse(txtMemberCount.Text, out int memberCount) || memberCount < 0)
            {
                ShowError("Số thành viên phải là số không âm!");
                return false;
            }
            if (!double.TryParse(txtProgress.Text, out double progress) || progress < 0 || progress > 100)
            {
                ShowError("Tiến độ phải là số từ 0 đến 100!");
                return false;
            }
            return true;
        }

        private void UpdateButtonStates()
        {
            bool hasSelection = projectsGrid.SelectedItem != null;
            btnEditProject.IsEnabled = hasSelection;
            btnDeleteProject.IsEnabled = hasSelection;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    public class IndexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (int)value + 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}