﻿using System;
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

namespace MAC_Quotation.Engine.Accent
{
    /// <summary>
    /// Interaction logic for Accent5.xaml
    /// </summary>
    public partial class Accent5 : Window
    {
        public Accent5()
        {
            InitializeComponent();
        }

        private void Accent5_ServiceBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            ServicePages.Accent.Accent5Serv accent5Serv = new ServicePages.Accent.Accent5Serv();
            accent5Serv.Show();
            // Close the current window
            Close();
        }

        // Image Navigate to the new window
        private void Accent5_RepairBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            var dashboard = new Dashboard();
            dashboard.Show();
            // Close the current window
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manufacture.Hyundai.Accent accent = new Manufacture.Hyundai.Accent();
            accent.Show();
            Close();
        }
    }
}
