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
    /// Interaction logic for MatchReporting1_UserValidation.xaml
    /// </summary>
    public partial class MatchReporting1_UserValidation : Window
    {
        Set s1 = new Set();
        public MatchReporting1_UserValidation()
        {
            InitializeComponent();
            InitializedSavedValues();
        }

        private void InitializedSavedValues()
        {
            player1Name_TextBox.Text = (string)Properties.Settings.Default["TextBoxValue1"];
            player2Name_TextBox.Text = (string)Properties.Settings.Default["TextBoxValue2"];
        }

        private void Bestof3_Button_Click(object sender, RoutedEventArgs e)
        {
            MatchReporting2_CharacterSelection characterSelection = new MatchReporting2_CharacterSelection();
            this.Visibility = Visibility.Hidden;
            characterSelection.Show();
            s1.p1 = player1Name_TextBox.Text;
            s1.p2 = player2Name_TextBox.Text;
            s1.gameTotal = 2;
        }

        private void Bestof5_Button_Click(object sender, RoutedEventArgs e)
        {
            MatchReporting2_CharacterSelection characterSelection = new MatchReporting2_CharacterSelection();
            this.Visibility = Visibility.Hidden;
            characterSelection.Show();
            s1.p1 = player1Name_TextBox.Text;
            s1.p2 = player2Name_TextBox.Text;
            s1.gameTotal = 4;
        }

        private void player1Name_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Properties.Settings.Default["TextBoxValue1"] = ((TextBox)sender).Text;

        }//player 1 textbox

        private void player2Name_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Properties.Settings.Default["TextBoxValue2"] = ((TextBox)sender).Text;

        }//player 2 textbox
    }
}
