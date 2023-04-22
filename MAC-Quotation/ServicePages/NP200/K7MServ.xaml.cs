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
    /// Interaction logic for K7MServ.xaml
    /// </summary>
    public partial class K7MServ : Window
    {
        public K7MServ()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engine.NP200.K7M k7M = new Engine.NP200.K7M();
            k7M.Show();
            Close();
        }
    }
}
