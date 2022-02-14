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

namespace Harjoitus16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int KilometersCount = 0;
        private int MilesCount = 0;

        public MainWindow()
        {
            InitializeComponent();
            tbKilometers.Text = KilometersCount.ToString();
            tbMiles.Text = MilesCount.ToString();
        }

        

        private void btnKilometers_Click(object sender, RoutedEventArgs e)
        {
            KilometersCount++;
            tbKilometers.Text = KilometersCount.ToString();
        }

        private void btnMiles_Click(object sender, RoutedEventArgs e)
        {
            MilesCount++;
            tbMiles.Text = MilesCount.ToString();
        }

        //Tämä muuntaa kilometrit mailiksi
        private void btnKmToMiles_Click(object sender, RoutedEventArgs e)
        {
            double kilometers = Convert.ToDouble(KilometersCount);
            double miles = kilometers / 1.6;
            tbKmToMiles.Text = miles.ToString();


        }
        //Tämä muuntaa mailit kilometreiksi
        private void btnMilesToKm_Click(object sender, RoutedEventArgs e)
        {
            double miles2 = Convert.ToDouble(MilesCount);
            double kilometers2 = miles2 * 1.6;
            tbMilesToKm.Text = kilometers2.ToString();
        }
    }
}
