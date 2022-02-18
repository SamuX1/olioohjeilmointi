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
using System.IO;
namespace Harjoitus26
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            
            if(cbShooter.IsChecked == true)
            {
                tbGames.Text = tbGames.Text + tbGamename.Text + " (Shooter)  ";
            }
            if (cbIndie.IsChecked == true)
            {
                tbGames.Text = tbGames.Text + tbGamename.Text + " (Indie)  ";
            }
            if (cbMOBA.IsChecked == true)
            {
                tbGames.Text = tbGames.Text + tbGamename.Text + " (MOBA)  ";
            }
            if (cbRPG.IsChecked == true)
            {
                tbGames.Text = tbGames.Text + tbGamename.Text + " (RPG)  ";
            }
            
        }

        private void btnTotext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbSuccessful.Text = string.Empty;
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter file = new StreamWriter(System.IO.Path.Combine(docPath, "GameList.txt")))
                {
                    file.WriteLine(tbGames.Text);
                }
                tbSuccessful.Text = "Action Completed Successfully";
                tbGames.Text = string.Empty;
            }
            //jos tule virhe siita ilmoitetaan
            catch
            {
                tbSuccessful.Text = string.Empty;
                tbSuccessful.Text = "Error";
                tbGames.Text = string.Empty;

            }
            
            
        }

        private void cbShooter_Checked(object sender, RoutedEventArgs e)
        {
            tbGenreinfo.Text = "Shooter video games or shooters are a subgenre of action video games where the focus is almost entirely on the defeat of the character's enemies using the weapons given to the player.";
        }

        private void cbIndie_Checked(object sender, RoutedEventArgs e)
        {
            tbGenreinfo.Text = "An indie game, short for independent video game, is a video game typically created by individuals or smaller development teams without the financial and technical support of a large game publisher, in contrast to most AAA (triple-A) games.";
        }

        private void cbRPG_Checked(object sender, RoutedEventArgs e)
        {
            tbGenreinfo.Text = "Role-playing game (sometimes spelled roleplaying game; abbreviated RPG) is a game in which players assume the roles of characters in a fictional setting.";
        }

        private void cbMOBA_Checked(object sender, RoutedEventArgs e)
        {
            tbGenreinfo.Text = "Multiplayer online battle arena (MOBA) is a subgenre of strategy video games in which two teams of players compete against each other on a predefined battlefield.";
        }
    }
}
