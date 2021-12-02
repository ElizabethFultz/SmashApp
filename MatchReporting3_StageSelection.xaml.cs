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

namespace SmashApp
{
    /// <summary>
    /// Interaction logic for MatchReporting3_StageSelection.xaml
    /// </summary>
    public partial class MatchReporting3_StageSelection : Window
    {
        int banNumber = 0;
        MatchReporting4_ScoreReport scoreReport = new MatchReporting4_ScoreReport();

        public MatchReporting3_StageSelection()
        {
            InitializeComponent();
        }

        private void Battlefield_Button_Click(object sender, RoutedEventArgs e)
        {
            banNumber += 1;
            Battlefield_Img.Source = new BitmapImage(new Uri("Images/Battlefield_Gray.jpg", UriKind.Relative));
            Continue();
        }

        private void FinalDestination_Button_Click(object sender, RoutedEventArgs e)
        {
            banNumber += 1;
            FinalDestination_Img.Source = new BitmapImage(new Uri("Images/FinalDestination_Gray.jpg", UriKind.Relative));
            Continue();
        }

        private void KalosPokemonLeague_Button_Click(object sender, RoutedEventArgs e)
        {
            banNumber += 1;
            KalosPokemonLeague_Img.Source = new BitmapImage(new Uri("Images/KalosPokemonLeague_Gray.jpg", UriKind.Relative));
            Continue();
        }

        private void PokemonStadium_Button_Click(object sender, RoutedEventArgs e)
        {
            banNumber += 1;
            PokemonStadium_Img.Source = new BitmapImage(new Uri("Images/PokemonStadium_Gray.jpg", UriKind.Relative));
            Continue();
        }

        private void SmallBattlefield_Button_Click(object sender, RoutedEventArgs e)
        {
            banNumber += 1;
            SmallBattlefield_Img.Source = new BitmapImage(new Uri("Images/SmallBattlefield_Gray.jpg", UriKind.Relative));
            Continue();
        }

        private void Smashville_Button_Click(object sender, RoutedEventArgs e)
        {
            banNumber += 1;
            Smashville_Img.Source = new BitmapImage(new Uri("Images/Smashville_Gray.jpg", UriKind.Relative));
            Continue();
        }

        private void TownAndCity_Button_Click(object sender, RoutedEventArgs e)
        {
            banNumber += 1;
            TownAndCity_Img.Source = new BitmapImage(new Uri("Images/TownAndCity_Gray.jpg", UriKind.Relative));
            Continue();
        }

        private void YoshisStory_Button_Click(object sender, RoutedEventArgs e)
        {
            banNumber += 1;
            YoshisStory_Img.Source = new BitmapImage(new Uri("/Images/YoshisStory_Gray.jpg", UriKind.Relative));
            Continue();
        }

        public void Continue()
        {
            if (banNumber == 7)
            {
                this.Visibility = Visibility.Hidden;
                scoreReport.Show();
            }  
        }
    }
}
