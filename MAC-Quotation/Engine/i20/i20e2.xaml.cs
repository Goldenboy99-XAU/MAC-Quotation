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

namespace MAC_Quotation.Engine.i20
{
    /// <summary>
    /// Interaction logic for i20e2.xaml
    /// </summary>
    public partial class i20e2 : Window
    {
        public i20e2()
        {
            InitializeComponent();
        }

        private void i20e2_ServiceBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            ServicePages.i20.i20e2Serv i20E2Serv = new ServicePages.i20.i20e2Serv();
            i20E2Serv.Show();
            // Close the current window
            Close();
        }

        // Image Navigate to the new window
        private void i20e2_RepairBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            var dashboard = new Dashboard();
            dashboard.Show();
            // Close the current window
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manufacture.Hyundai.i20 i20 = new Manufacture.Hyundai.i20();
            i20.Show();
            Close();
        }
    }
}
