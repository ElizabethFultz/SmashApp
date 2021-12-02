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
    /// Interaction logic for MatchReporting4_ScoreReport.xaml
    /// </summary>
    public partial class MatchReporting4_ScoreReport : Window
    {
        public MatchReporting4_ScoreReport()
        {
            InitializeComponent();
        }

        private void Player1Victory_Button1_Click(object sender, RoutedEventArgs e)
        {
            MatchReporting1_UserValidation.s1.p1Win++;
            if(MatchReporting1_UserValidation.s1.p1Win==(MatchReporting1_UserValidation.s1.gameTotal)) 
            {
                string tempW = MatchReporting1_UserValidation.s1.p1;
                MatchReporting5_FinalScores finalScores = new MatchReporting5_FinalScores(tempW);
                this.Visibility = Visibility.Hidden;
                finalScores.Show();
               
            }//p1 majority
            else
            {
                MatchReporting3_StageSelection stageSelection = new MatchReporting3_StageSelection();
                this.Visibility = Visibility.Hidden;
                stageSelection.Show();
            }
            //s1.p1 wins
        }

        private void Player2Victory_Button_Click(object sender, RoutedEventArgs e)
        {
            MatchReporting1_UserValidation.s1.p2Win++;
            if (MatchReporting1_UserValidation.s1.p2Win == (MatchReporting1_UserValidation.s1.gameTotal))
            {
                string tempW = MatchReporting1_UserValidation.s1.p2;
                MatchReporting5_FinalScores finalScores = new MatchReporting5_FinalScores(tempW);
                this.Visibility = Visibility.Hidden;
                finalScores.Show();
            }//p2 majority win
            else
            {
                MatchReporting3_StageSelection stageSelection = new MatchReporting3_StageSelection();
                this.Visibility = Visibility.Hidden;
                stageSelection.Show();
            }
            //s1.p2 wins
        }
    }
}
