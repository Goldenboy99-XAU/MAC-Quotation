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

namespace MAC_Quotation.Engine.NP200
{
    /// <summary>
    /// Interaction logic for K7M.xaml
    /// </summary>
    public partial class K7M : Window
    {
        public K7M()
        {
            InitializeComponent();
        }

        private void K7M_ServiceBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            var dashboard = new Dashboard();
            dashboard.Show();
            // Close the current window
            Close();
        }

        // Image Navigate to the new window
        private void K7M_RepairBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            var dashboard = new Dashboard();
            dashboard.Show();
            // Close the current window
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manufacture.Nissan.Nissan_Brand.NP200 nP200 = new Manufacture.Nissan.Nissan_Brand.NP200();
            nP200.Show();
            Close();
        }
    }
}
