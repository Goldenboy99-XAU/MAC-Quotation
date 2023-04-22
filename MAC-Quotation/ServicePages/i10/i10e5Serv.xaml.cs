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

namespace MAC_Quotation.ServicePages.i10
{
    /// <summary>
    /// Interaction logic for i10e5Serv.xaml
    /// </summary>
    public partial class i10e5Serv : Window
    {
        public i10e5Serv()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engine.i10.i10e5 i10E5 = new Engine.i10.i10e5();
            i10E5.Show();
            Close();
        }
    }
}
