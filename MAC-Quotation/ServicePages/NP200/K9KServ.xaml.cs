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
    /// Interaction logic for K9KServ.xaml
    /// </summary>
    public partial class K9KServ : Window
    {
        public K9KServ()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engine.NP200.K9K k9K = new Engine.NP200.K9K();
            k9K.Show();
            Close();
        }
    }
}
