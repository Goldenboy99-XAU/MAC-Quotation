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

namespace MAC_Quotation.Engine.i10
{
    /// <summary>
    /// Interaction logic for i10e3.xaml
    /// </summary>
    public partial class i10e3 : Window
    {
        public i10e3()
        {
            InitializeComponent();
        }
        private void i10e3_ServiceBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            ServicePages.i10.i10e3Serv i10E3Serv = new ServicePages.i10.i10e3Serv();
            i10E3Serv.Show();
            // Close the current window
            Close();
        }

        // Image Navigate to the new window
        private void i10e3_RepairBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            var dashboard = new Dashboard();
            dashboard.Show();
            // Close the current window
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manufacture.Hyundai.i10 i10 = new Manufacture.Hyundai.i10();
            i10.Show();
            Close();
        }
    }
}
