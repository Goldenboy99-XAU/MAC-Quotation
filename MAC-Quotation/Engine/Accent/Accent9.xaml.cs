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

namespace MAC_Quotation.Engine.Accent
{
    /// <summary>
    /// Interaction logic for Accent9.xaml
    /// </summary>
    public partial class Accent9 : Window
    {
        public Accent9()
        {
            InitializeComponent();
        }

        private void Accent9_ServiceBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            ServicePages.Accent.Accent9Serv accent9Serv = new ServicePages.Accent.Accent9Serv();
            accent9Serv.Show();
            // Close the current window
            Close();
        }

        // Image Navigate to the new window
        private void Accent9_RepairBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            var dashboard = new Dashboard();
            dashboard.Show();
            // Close the current window
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manufacture.Hyundai.Accent accent = new Manufacture.Hyundai.Accent();
            accent.Show();
            Close();
        }
    }
}
