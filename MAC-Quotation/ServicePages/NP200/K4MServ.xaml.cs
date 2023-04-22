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

namespace MAC_Quotation.ServicePages.NP200
{
    /// <summary>
    /// Interaction logic for K4MServ.xaml
    /// </summary>
    public partial class K4MServ : Window
    {
        public K4MServ()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engine.NP200.K4M k4M = new Engine.NP200.K4M();
            k4M.Show();
            Close();
        }
    }
}
