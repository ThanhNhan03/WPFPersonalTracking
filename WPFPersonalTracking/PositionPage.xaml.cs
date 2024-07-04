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
using WPFPersonalTracking.ViewModels;

namespace WPFPersonalTracking
{
    /// <summary>
    /// Interaction logic for PositionPage.xaml
    /// </summary>
    public partial class PositionPage : Window
    {
        public PositionPage()
        {
            InitializeComponent();
        }
        PersonalTrackingContext db = new PersonalTrackingContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var list = db.Departments.OrderBy(x => x.DepartmentName).ToList();
            cmbDepartment.ItemsSource = list;
            cmbDepartment.DisplayMemberPath = "DepartmentName";
            cmbDepartment.SelectedValuePath = "Id";
            cmbDepartment.SelectedIndex = -1;
            if (model != null && model.Id !=0)
            {
                txtPositionName.Text = model.PositionName;
                cmbDepartment.SelectedValue = model.DepartmentId;
            }
        }
        public PositionModel model;
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cmbDepartment == null || cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a department");
                return;
            }
            else
            {
                if (model != null && model.Id != 0)
                {
                    Position pst = new Position();
                    pst.DepartmentId = (int)cmbDepartment.SelectedValue;
                    pst.Id = model.Id;
                    pst.PositionName = txtPositionName.Text;
                    db.Positions.Update(pst);
                    db.SaveChanges();
                    MessageBox.Show("Position updated successfully");
                } 
                else
                {
                    Position position = new Position();
                    position.PositionName = txtPositionName.Text;
                    position.DepartmentId = (int)cmbDepartment.SelectedValue;
                    db.Positions.Add(position);
                    db.SaveChanges();
                    MessageBox.Show("Position added successfully");
                }
                
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
