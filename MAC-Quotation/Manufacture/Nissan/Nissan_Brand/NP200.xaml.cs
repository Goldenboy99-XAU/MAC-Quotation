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

namespace MAC_Quotation.Manufacture.Nissan.Nissan_Brand
{
    /// <summary>
    /// Interaction logic for NP200.xaml
    /// </summary>
    public partial class NP200 : Window
    {
        public NP200()
        {
            InitializeComponent();
        }

        // Image Navigate to the new window
        private void NP200_ServiceBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            var dashboard = new Dashboard();
            dashboard.Show();
            // Close the current window
            Close();
        }

        // Image Navigate to the new window
        private void NP200_RepairBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            var dashboard = new Dashboard();
            dashboard.Show();
            // Close the current window
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }



        private void NP200_YearComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = NP200_YearComboBox.SelectedItem as ComboBoxItem;

            if (selectedItem != null)
            {
                if (selectedItem.Content.ToString() == "2008 - 2012")
                {
                    myNP200EngineNumber.Visibility = Visibility.Visible;
                    myNP200EngineComboBox.Visibility = Visibility.Visible;

                    myNP200EngineComboBox.Items.Clear();
                    myNP200EngineComboBox.Items.Add("K7M");
                    myNP200EngineComboBox.Items.Add("K4M");
                }
                else if (selectedItem.Content.ToString() == "2009 - 2013")
                {
                    myNP200EngineNumber.Visibility = Visibility.Visible;
                    myNP200EngineComboBox.Visibility = Visibility.Visible;

                    myNP200EngineComboBox.Items.Clear();
                    myNP200EngineComboBox.Items.Add("K9K");
                }
                else
                {
                    myNP200EngineNumber.Visibility = Visibility.Collapsed;
                    myNP200EngineComboBox.Visibility = Visibility.Collapsed;
                    
                }
            }
        }

        private void NP200_EngineComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedModel = myNP200EngineComboBox.SelectedItem as string;

            if (selectedModel != null)
            {
                switch (selectedModel)
                {
                    case "K4M":
                        // Navigate to the K4M Window
                        Engine.NP200.K4M k4M = new Engine.NP200.K4M();
                        k4M.Show();
                        Close();
                        break;
                    case "K7M":
                        // Navigate to the K7M Window
                        Engine.NP200.K7M k7M = new Engine.NP200.K7M();
                        k7M.Show();
                        Close();
                        break;
                    case "K9K":
                        // Navigate to the K9K Window
                        Engine.NP200.K9K k9K = new Engine.NP200.K9K();
                        k9K.Show();
                        Close();
                        break;
                    default:
                        // Do nothing
                        break;
                }
            }
        }



    }
}
