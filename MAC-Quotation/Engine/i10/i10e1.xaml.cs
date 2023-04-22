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

namespace MAC_Quotation.Engine.i10
{
    /// <summary>
    /// Interaction logic for i10e1.xaml
    /// </summary>
    public partial class i10e1 : Window
    {
        public i10e1()
        {
            InitializeComponent();
        }

        private void i10e1_ServiceBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            ServicePages.i10.i10e1Serv i10E1Serv = new ServicePages.i10.i10e1Serv();
            i10E1Serv.Show();
            // Close the current window
            Close();
        }

        // Image Navigate to the new window
        private void i10e1_RepairBtn_Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Navigate to the new window
            var dashboard = new Dashboard();
            dashboard.Show();
            // Close the current window
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manufacture.Hyundai.i10 i10 = new Manufacture.Hyundai.i10();
            i10.Show();
            Close();
        }
    }
}