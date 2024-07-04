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
using System.Windows.Shapes;
using WPFPersonalTracking.DB;

namespace WPFPersonalTracking
{
    /// <summary>
    /// Interaction logic for DepartmentPage.xaml
    /// </summary>
    public partial class DepartmentPage : Window
    {
        public DepartmentPage()
        {
            InitializeComponent();
        }
        public Department department = new Department(); // Initialize department as a non-null value

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtDepartmentName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the department name");
                return;
            }
            else
            {
                using (PersonalTrackingContext db = new PersonalTrackingContext())
                {
                    if (department != null && department.Id != 0)
                    {
                        Department update = new Department();
                        update.DepartmentName = txtDepartmentName.Text;
                        update.Id = department.Id;
                        db.Departments.Update(update);
                        db.SaveChanges();
                        MessageBox.Show("Department updated successfully");
                    }
                    else
                    {
                        Department department = new Department();
                        department.DepartmentName = txtDepartmentName.Text;
                        db.Departments.Add(department);
                        db.SaveChanges();
                        txtDepartmentName.Clear();
                        MessageBox.Show("Department added successfully");
                        txtDepartmentName.Text = "";
                    }
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (department != null && department.Id != 0)
            {
                txtDepartmentName.Text = department.DepartmentName;
            }
            //using (PersonalTrackingContext db = new PersonalTrackingContext())
            //{
            //    gridDepartment.ItemsSource = db.Departments.OrderBy(x => x.DepartmentName).ToList();

            //}
        }
    }
}
