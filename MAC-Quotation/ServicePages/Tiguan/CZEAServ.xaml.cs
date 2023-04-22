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
    /// Interaction logic for CZEAServ.xaml
    /// </summary>
    public partial class CZEAServ : Window
    {
        public CZEAServ()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engine.Tiguan.CZEA cZEA = new Engine.Tiguan.CZEA();
            cZEA.Show();
            Close();
        }
    }
}
