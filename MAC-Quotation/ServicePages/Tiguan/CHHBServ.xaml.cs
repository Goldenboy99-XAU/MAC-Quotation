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

namespace MAC_Quotation.ServicePages.Tiguan
{
    /// <summary>
    /// Interaction logic for CHHBServ.xaml
    /// </summary>
    public partial class CHHBServ : Window
    {
        public CHHBServ()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engine.Tiguan.CHHB cHHB = new Engine.Tiguan.CHHB();
            cHHB.Show();
            Close();
        }
    }
}
