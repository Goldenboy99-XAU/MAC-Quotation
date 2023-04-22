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
    /// Interaction logic for Accent9Serv.xaml
    /// </summary>
    public partial class Accent9Serv : Window
    {
        public Accent9Serv()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engine.Accent.Accent9 accent9 = new Engine.Accent.Accent9();
            accent9.Show();
            Close();
        }
    }
}
