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
    /// Interaction logic for CAXAServ.xaml
    /// </summary>
    public partial class CAXAServ : Window
    {
        public CAXAServ()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engine.Tiguan.CAXA cAXA = new Engine.Tiguan.CAXA();
            cAXA.Show();
            Close();
        }
    }
}
