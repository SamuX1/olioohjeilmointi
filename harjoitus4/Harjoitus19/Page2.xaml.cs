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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Harjoitus19
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();


        }

        private void btnKerros1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }

        private void btnKerros3_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }

        private void btnKerros4_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page4());
        }

        private void btnKerros5_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page5());
        }

        private void btnKerros6_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page6());
        }
    }
}