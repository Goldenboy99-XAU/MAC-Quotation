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

namespace MAC_Quotation.ServicePages.Accent
{
    /// <summary>
    /// Interaction logic for Accent1Serv.xaml
    /// </summary>
    public partial class Accent1Serv : Window
    {
        public Accent1Serv()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engine.Accent.Accent1 accent1 = new Engine.Accent.Accent1();
            accent1.Show();
            Close();
        }
    }
}
