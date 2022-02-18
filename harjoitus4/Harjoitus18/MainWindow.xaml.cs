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

namespace Harjoitus18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double nmro1;
        double nmro2;
        double vastaus;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSumma_Click(object sender, RoutedEventArgs e)
        {
            //käytetään muuntamaan textbox
            nmro1 = Convert.ToDouble(tbNumero1.Text);
            nmro2 = Convert.ToDouble(tbNumero2.Text);

            vastaus = nmro1 + nmro2;

            tbVastaus.Text = vastaus.ToString();


        }

        private void btnErotus_Click(object sender, RoutedEventArgs e)
        {
            nmro1 = Convert.ToDouble(tbNumero1.Text);
            nmro2 = Convert.ToDouble(tbNumero2.Text);

            vastaus = nmro1 - nmro2;

            tbVastaus.Text = vastaus.ToString();
        }

        private void btnKertaus_Click(object sender, RoutedEventArgs e)
        {
            nmro1 = Convert.ToDouble(tbNumero1.Text);
            nmro2 = Convert.ToDouble(tbNumero2.Text);

            vastaus = nmro1 * nmro2;

            tbVastaus.Text = vastaus.ToString();
        }

        private void btnJako_Click(object sender, RoutedEventArgs e)
        {
            nmro1 = Convert.ToDouble(tbNumero1.Text);
            nmro2 = Convert.ToDouble(tbNumero2.Text);

            vastaus = nmro1 / nmro2;

            tbVastaus.Text = vastaus.ToString();
        }
    }
}
