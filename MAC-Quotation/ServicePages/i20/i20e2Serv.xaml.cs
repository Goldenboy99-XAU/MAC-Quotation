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

namespace MAC_Quotation.ServicePages.i20
{
    /// <summary>
    /// Interaction logic for i20e2Serv.xaml
    /// </summary>
    public partial class i20e2Serv : Window
    {
        public i20e2Serv()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engine.i20.i20e2 i20E2 = new Engine.i20.i20e2();
            i20E2.Show();
            Close();
        }
    }
}
