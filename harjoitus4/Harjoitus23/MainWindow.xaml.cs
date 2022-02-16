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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Harjoitus23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        public MainWindow()
        {
            InitializeComponent();

            
            int arvo = int.Parse(tbLämpötila.Text);
            int arvo2 = int.Parse(tbKosteus.Text);

            if (arvo > 120)
            {
                tbLämpötila.Text = "Error";
            }
            if (arvo < 0)
            {
                tbLämpötila.Text = "Error";
            }
            if (arvo2 > 120)
            {
                tbLämpötila.Text = "Error";
            }
            if (arvo2 < 0)
            {
                tbLämpötila.Text = "Error";
            }
        }
        
        
        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            tbArvo.Text = tbArvo.Text + 1;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            tbArvo.Text = tbArvo.Text + 2;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            tbArvo.Text = tbArvo.Text + 3;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            tbArvo.Text = tbArvo.Text + 4;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            tbArvo.Text = tbArvo.Text + 5;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            tbArvo.Text = tbArvo.Text + 6;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            tbArvo.Text = tbArvo.Text + 7;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            tbArvo.Text = tbArvo.Text + 8;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            tbArvo.Text = tbArvo.Text + 9;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            tbArvo.Text = tbArvo.Text + 0;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if(cbLämpötila.IsChecked == true)
            { 
            tbLämpötila.Text = tbArvo.Text;
            }
            if(cbKosteus.IsChecked == true)
            {
                tbKosteus.Text = tbArvo.Text;
            }

            tbArvo.Text = string.Empty;
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            tbArvo.Text = string.Empty;
        }

        private void cbLämpötila_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cbKosteus_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
