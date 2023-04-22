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

namespace MAC_Quotation.Manufacture.Hyundai
{
    /// <summary>
    /// Interaction logic for Accent.xaml
    /// </summary>
    public partial class Accent : Window
    {
        public Accent()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }
                
        private void Accent_YearComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = Accent_YearComboBox.SelectedItem as ComboBoxItem;

            if (selectedItem != null)
            {
                if (selectedItem.Content.ToString() == "-- Select Year Model --")
                {
                    myAccentEngineNumber.Visibility = Visibility.Collapsed;
                    myAccentEngineComboBox.Visibility = Visibility.Collapsed;
                }
                else
                {
                    myAccentEngineNumber.Visibility = Visibility.Visible;
                    myAccentEngineComboBox.Visibility = Visibility.Visible;

                    myAccentEngineComboBox.Items.Clear();

                    if (selectedItem.Content.ToString() == "1994 - 2000")
                    {
                        myAccentEngineComboBox.Items.Add("G4EK @ 1.3L");//
                    }
                    else if (selectedItem.Content.ToString() == "1996 - 1997")
                    {
                        myAccentEngineComboBox.Items.Add("D413 @ 1.3L");//
                    }
                    else if (selectedItem.Content.ToString() == "1999 - 2002")
                    {
                        myAccentEngineComboBox.Items.Add("G4EH @ 1.3L");//
                    }
                    else if (selectedItem.Content.ToString() == "1999 - 2006")
                    {
                        myAccentEngineComboBox.Items.Add("G4EB @ 1.5L");//
                    }
                    else if (selectedItem.Content.ToString() == "2000 - 2002")
                    {
                        myAccentEngineComboBox.Items.Add("G4EA @ 1.3L");//
                    }
                    else if (selectedItem.Content.ToString() == "2000 - 2003")
                    {
                        myAccentEngineComboBox.Items.Add("G4EC-G @ 1.5L");//
                    }
                    else if (selectedItem.Content.ToString() == "2002 - 2006")
                    {
                        myAccentEngineComboBox.Items.Add("G4ED @ 1.6L");//
                    }
                    else if (selectedItem.Content.ToString() == "2005 - 2010")
                    {
                        myAccentEngineComboBox.Items.Add("G4EE @ 1.4L");//
                    }
                    else if (selectedItem.Content.ToString() == "2006 - 2011")
                    {
                        myAccentEngineComboBox.Items.Add("G4ED @ 1.6L");//
                    }
                    else if (selectedItem.Content.ToString() == "2011 - 2018")
                    {
                        myAccentEngineComboBox.Items.Add("G4FC @ 1.6L");//
                    }
                }
            }
        }

        private void myAccentEngineComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedModel = myAccentEngineComboBox.SelectedItem as string;

            if (selectedModel != null)
            {
                switch (selectedModel)
                {
                    case "G4EK @ 1.3L":
                        // Navigate to the e1 Window***********************************************************
                        Engine.Accent.Accent1 accent1 = new Engine.Accent.Accent1();
                        accent1.Show();
                        Close();
                        break;
                    case "D413 @ 1.3L":
                        // Navigate to the E2 Window **********************************************************
                        Engine.Accent.Accent2 accent2 = new Engine.Accent.Accent2();
                        accent2.Show();
                        Close();
                        break;
                    case "G4EH @ 1.3L":
                        // Navigate to the E3 Window ***********************************************************
                        Engine.Accent.Accent3 accent3 = new Engine.Accent.Accent3();
                        accent3.Show();
                        Close();
                        break;
                    case "G4EB @ 1.5L":
                        // Navigate to the E4 Window ***********************************************************
                        Engine.Accent.Accent4 accent4 = new Engine.Accent.Accent4();
                        accent4.Show();
                        Close();
                        break;
                    case "G4EA @ 1.3L":
                        // Navigate to the E5 Window **********************************************************
                        Engine.Accent.Accent5 accent5 = new Engine.Accent.Accent5();
                        accent5.Show();
                        Close();
                        break;
                    case "G4EC-G @ 1.5L":
                        // Navigate to the E6 Window **********************************************************
                        Engine.Accent.Accent6 accent6 = new Engine.Accent.Accent6();
                        accent6.Show();
                        Close();
                        break;
                    case "G4ED @ 1.6L":
                        // Navigate to the E7 Window **********************************************************
                        Engine.Accent.Accent7 accent7 = new Engine.Accent.Accent7();
                        accent7.Show();
                        Close();
                        break;
                    case "G4EE @ 1.4L":
                        // Navigate to the E8 Window **********************************************************
                        Engine.Accent.Accent8 accent8 = new Engine.Accent.Accent8();
                        accent8.Show();
                        Close();
                        break;
                    case "G4FC @ 1.6L":
                        // Navigate to the E9 Window **********************************************************
                        Engine.Accent.Accent9 accent9 = new Engine.Accent.Accent9();
                        accent9.Show();
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
