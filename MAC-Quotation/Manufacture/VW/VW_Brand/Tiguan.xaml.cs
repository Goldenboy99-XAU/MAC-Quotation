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

namespace MAC_Quotation.Manufacture.VW.VW_Brand
{
    /// <summary>
    /// Interaction logic for Tiguan.xaml
    /// </summary>
    public partial class Tiguan : Window
    {
        public Tiguan()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }

        private void Tiguan_YearComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = Tiguan_YearComboBox.SelectedItem as ComboBoxItem;

            if (selectedItem != null)
            {
                if (selectedItem.Content.ToString() == "-- Select Year Model --")
                {
                    myTiguanEngineNumber.Visibility = Visibility.Collapsed;
                    myTiguanEngineComboBox.Visibility = Visibility.Collapsed;
                }
                else
                {
                    myTiguanEngineNumber.Visibility = Visibility.Visible;
                    myTiguanEngineComboBox.Visibility = Visibility.Visible;

                    myTiguanEngineComboBox.Items.Clear();

                    if (selectedItem.Content.ToString() == "2008 - 2012")
                    {
                        myTiguanEngineComboBox.Items.Add("BWK");
                    }
                    else if (selectedItem.Content.ToString() == "2008 - 2016")
                    {
                        myTiguanEngineComboBox.Items.Add("CBAB");
                    }
                    else if (selectedItem.Content.ToString() == "2009 - 2011")
                    {
                        myTiguanEngineComboBox.Items.Add("CAWB");
                    }
                    else if (selectedItem.Content.ToString() == "2011 - 2016")
                    {
                        myTiguanEngineComboBox.Items.Add("CAXA");
                        myTiguanEngineComboBox.Items.Add("CAVD");
                        myTiguanEngineComboBox.Items.Add("CFFD");
                    }
                    else if (selectedItem.Content.ToString() == "2016 - Current")
                    {
                        myTiguanEngineComboBox.Items.Add("CZCA");
                        myTiguanEngineComboBox.Items.Add("CZEA");
                        myTiguanEngineComboBox.Items.Add("CHHB");
                    }
                }
            }
        }


        private void Tiguan_EngineComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedModel = myTiguanEngineComboBox.SelectedItem as string;

            if (selectedModel != null)
            {
                switch (selectedModel)
                {
                    case "BWK":
                        // Navigate to the BWK Window
                        Engine.Tiguan.BWK bWK = new Engine.Tiguan.BWK();
                        bWK.Show();
                        Close();
                        break;
                    case "CBAB":
                        // Navigate to the CBAB Window
                        Engine.Tiguan.CBAB cBAB = new Engine.Tiguan.CBAB();
                        cBAB.Show();
                        Close();
                        break;
                    case "CAWB":
                        // Navigate to the CAWB Window
                        Engine.Tiguan.CAWB cAWB = new Engine.Tiguan.CAWB();
                        cAWB.Show();
                        Close();
                        break;
                    case "CAXA":
                        // Navigate to the CAXA Window
                        Engine.Tiguan.CAXA cAXA = new Engine.Tiguan.CAXA();
                        cAXA.Show();
                        Close();
                        break;
                    case "CAVD":
                        // Navigate to the CAVD Window
                        Engine.Tiguan.CAVD cAVD = new Engine.Tiguan.CAVD();
                        cAVD.Show();
                        Close();
                        break;
                    case "CFFD":
                        // Navigate to the CFFD Window
                        Engine.Tiguan.CFFD cFFD = new Engine.Tiguan.CFFD();
                        cFFD.Show();
                        Close();
                        break;
                    case "CZCA":
                        // Navigate to the CZCA Window
                        Engine.Tiguan.CZCA cZCA = new Engine.Tiguan.CZCA();
                        cZCA.Show();
                        Close();
                        break;
                    case "CZEA":
                        // Navigate to the CZEA Window
                        Engine.Tiguan.CZEA cZEA = new Engine.Tiguan.CZEA();
                        cZEA.Show();
                        Close();
                        break;
                    case "CHHB":
                        // Navigate to the CHHB Window
                        Engine.Tiguan.CHHB cHHB = new Engine.Tiguan.CHHB();
                        cHHB.Show();
                        Close();
                        break;
                        // Add cases here for more Engine MODELS
                    default:
                        // Do nothing
                        break;
                }
            }
        }
    }
}
