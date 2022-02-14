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

namespace Harjoitus17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int lampötiläCount = 21;
        private string valot = "pois päältä";
        private string valot2 = "päälle";
        private string ovi = "lukossa";
        private string ovi2 = "auki";

        public MainWindow()
        {
            InitializeComponent();
            tbLampötila.Text = lampötiläCount.ToString() + " astetta";

        }

        private void btnLampötila_Click(object sender, RoutedEventArgs e)
        {
            lampötiläCount++;
            tbLampötila.Text = lampötiläCount.ToString() + " astetta";
        }

        private void btnKettiövalot_Click(object sender, RoutedEventArgs e)
        {
            if (tbKeittiövalot.Text == "päälle")
            {
                tbKeittiövalot.Text = valot;
            }else
            {
                tbKeittiövalot.Text = valot2;
            }
        }

        private void btnOlohuonevalot_Click(object sender, RoutedEventArgs e)
        {
            if (tbOlohuonevalot.Text == "päälle")
            {
                tbOlohuonevalot.Text = valot;
            }
            else
            {
                tbOlohuonevalot.Text = valot2;
            }
        }

        private void btnOvi_Click(object sender, RoutedEventArgs e)
        {
            if (tbOvi.Text == "auki")
            {
                tbOvi.Text = ovi;
            }
            else
            {
                tbOvi.Text = ovi2;
            }
        }
    }
}
