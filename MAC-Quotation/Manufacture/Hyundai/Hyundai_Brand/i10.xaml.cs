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
    /// Interaction logic for i10.xaml
    /// </summary>
    public partial class i10 : Window
    {
        public i10()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }

        private void i10_YearComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = i10_YearComboBox.SelectedItem as ComboBoxItem;

            if (selectedItem != null)
            {
                if (selectedItem.Content.ToString() == "-- Select Year Model --")
                {
                    myi10EngineNumber.Visibility = Visibility.Collapsed;
                    myi10EngineComboBox.Visibility = Visibility.Collapsed;
                }
                else
                {
                    myi10EngineNumber.Visibility = Visibility.Visible;
                    myi10EngineComboBox.Visibility = Visibility.Visible;

                    myi10EngineComboBox.Items.Clear();

                    if (selectedItem.Content.ToString() == "2008 - 2017")
                    {
                        myi10EngineComboBox.Items.Add("G4HG @ 1.1L");
                        myi10EngineComboBox.Items.Add("G4LA @ 1.2L");
                    }
                    else if (selectedItem.Content.ToString() == "2013 - 2018")
                    {
                        myi10EngineComboBox.Items.Add("G3LA @ 1.0L");
                    }
                    else if (selectedItem.Content.ToString() == "2014 - 2019")
                    {
                        myi10EngineComboBox.Items.Add("G4LA @ 1.25L");
                    }
                    else if (selectedItem.Content.ToString() == "2018 - Current")
                    {
                        myi10EngineComboBox.Items.Add("G3LA @ 1.0grand");
                    }
                }
            }
        }

        private void i10_EngineComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedModel = myi10EngineComboBox.SelectedItem as string;

            if (selectedModel != null)
            {
                switch (selectedModel)
                {
                    case "G4HG @ 1.1L":
                        // Navigate to the E1 Window***********************************************************
                        Engine.i10.i10e1 i10E1 = new Engine.i10.i10e1();
                        i10E1.Show();
                        Close();
                        break;
                    case "G4LA @ 1.2L":
                        // Navigate to the E2 Window **********************************************************
                        Engine.i10.i10e2 i10E2 = new Engine.i10.i10e2();
                        i10E2.Show();
                        Close();
                        break;
                    case "G3LA @ 1.0L":
                        // Navigate to the E3 Window ***********************************************************
                        Engine.i10.i10e3 i10E3 = new Engine.i10.i10e3();
                        i10E3.Show();
                        Close();
                        break;
                    case "G4LA @ 1.25L":
                        // Navigate to the E4 Window ***********************************************************
                        Engine.i10.i10e4 i10E4 = new Engine.i10.i10e4();
                        i10E4.Show();
                        Close();
                        break;
                    case "G3LA @ 1.0grand":
                        // Navigate to the E5 Window **********************************************************
                        Engine.i10.i10e5 i10E5 = new Engine.i10.i10e5();
                        i10E5.Show();
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
