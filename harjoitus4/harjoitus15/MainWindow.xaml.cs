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

namespace harjoitus15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int henkiloAutot = 0;
        private int kuormaAutot = 0;
        public MainWindow()
        {
            InitializeComponent();

            tbHenkiloauto.Text = henkiloAutot.ToString();
            tbKuormaauto.Text = kuormaAutot.ToString();
        }

        private void btnHenkilöauto_Click(object sender, RoutedEventArgs e)
        {
            henkiloAutot++;
            tbHenkiloauto.Text = henkiloAutot.ToString();
        }

        private void btnKuormaauto_Click(object sender, RoutedEventArgs e)
        {
            kuormaAutot++;
            tbKuormaauto.Text = kuormaAutot.ToString();
        }
    }
}
