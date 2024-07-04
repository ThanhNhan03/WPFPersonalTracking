using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFPersonalTracking.DB;
using WPFPersonalTracking.ViewModels;

namespace WPFPersonalTracking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (PersonalTrackingContext dbContext = new PersonalTrackingContext())
            {
                
            }
        }

        private void btnDepartment_Click(object sender, RoutedEventArgs e)
        {
            lblWindowsName.Content = "Department";
            DataContext = new DepartmentViewmodel();
        }

        private void btnPosition_Click(object sender, RoutedEventArgs e)
        {
            lblWindowsName.Content = "Position";
            DataContext = new PositionViewModel();
        }
    }
}