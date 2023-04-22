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
    /// Interaction logic for i20.xaml
    /// </summary>
    public partial class i20 : Window
    {
        public i20()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }

        private void i20_YearComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = i20_YearComboBox.SelectedItem as ComboBoxItem;

            if (selectedItem != null)
            {
                if (selectedItem.Content.ToString() == "-- Select Year Model --")
                {
                    myi20EngineNumber.Visibility = Visibility.Collapsed;
                    myi20EngineComboBox.Visibility = Visibility.Collapsed;
                }
                else
                {
                    myi20EngineNumber.Visibility = Visibility.Visible;
                    myi20EngineComboBox.Visibility = Visibility.Visible;

                    myi20EngineComboBox.Items.Clear();

                    if (selectedItem.Content.ToString() == "2010 - 2015")
                    {
                        myi20EngineComboBox.Items.Add("G4FA @ 1.4L");//
                        myi20EngineComboBox.Items.Add("G4FC @ 1.6L");//

                    }
                    else if (selectedItem.Content.ToString() == "2012 - 2021")
                    {
                        myi20EngineComboBox.Items.Add("G4LA @ 1.2L");//
                        myi20EngineComboBox.Items.Add("D4FC @ 1.4L");//

                    }
                    else if (selectedItem.Content.ToString() == "2015 - Current")
                    {
                        myi20EngineComboBox.Items.Add("G4LC @ 1.4L");//
                    }
                    else if (selectedItem.Content.ToString() == "2021 - Current")
                    {
                        myi20EngineComboBox.Items.Add("G3LC @ 1.0L");//

                    }
                }
            }
        }
         private void i20_EngineComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedModel = myi20EngineComboBox.SelectedItem as string;

            if (selectedModel != null)
            {
                switch (selectedModel)
                {
                    case "G4FA @ 1.4L":
                        // Navigate to the E1 Window***********************************************************
                        Engine.i20.i20e1 i20E1 = new Engine.i20.i20e1();
                        i20E1.Show();
                        Close();
                        break;
                    case "G4FC @ 1.6L":
                        // Navigate to the E2 Window **********************************************************
                        Engine.i20.i20e2 i20E2 = new Engine.i20.i20e2();
                        i20E2.Show();
                        Close();
                        break;
                    case "G4LA @ 1.2L":
                        // Navigate to the E3 Window ***********************************************************
                        Engine.i20.i20e3 i20E3 = new Engine.i20.i20e3();
                        i20E3.Show();
                        Close();
                        break;
                    case "D4FC @ 1.4L":
                        // Navigate to the E4 Window ***********************************************************
                        Engine.i20.i20e4 i20E4 = new Engine.i20.i20e4();
                        i20E4.Show();
                        Close();
                        break;
                    case "G4LC @ 1.4L":
                        // Navigate to the E5 Window **********************************************************
                        Engine.i10.i10e5 i10E5 = new Engine.i10.i10e5();
                        i10E5.Show();
                        Close();
                        break;
                    case "G3LC @ 1.0L":
                        // Navigate to the E6 Window **********************************************************
                        Engine.i20.i20e5 i20E5 = new Engine.i20.i20e5();
                        i20E5.Show();
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
