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

namespace MAC_Quotation.Engine.Tiguan
{
    /// <summary>
    /// Interaction logic for CFFD.xaml
    /// </summary>
    public partial class CFFD : Window
    {
        public CFFD()
        {
            InitializeComponent();
        }

        private void CFFD_ServiceBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            var dashboard = new Dashboard();
            dashboard.Show();
            // Close the current window
            Close();
        }

        // Image Navigate to the new window
        private void CFFD_RepairBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            var dashboard = new Dashboard();
            dashboard.Show();
            // Close the current window
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manufacture.VW.VW_Brand.Tiguan tiguan = new Manufacture.VW.VW_Brand.Tiguan();
            tiguan.Show();
            Close();
        }
    }
}
