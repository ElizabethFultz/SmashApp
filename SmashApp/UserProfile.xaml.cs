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
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Window
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Visibility = Visibility.Hidden;
            window.Show();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string tempName = UserNameTextbox.Text;
            string tempChar = Player1Character_ComboBox.Text;
            string tempSt = StateTextBox.Text;
            string tempC = CityTextbox.Text;

            Player tempPlayer = new Player(tempName, tempChar, tempSt, tempC);
            Player[] playerList = new Player[63];
            int indexer = 0;
            playerList[indexer] = tempPlayer;
            indexer += 1;

            string box_msg = "You've been added to the Database!";

            string box_title = "Message Box Demo";

            MessageBox.Show(box_msg, box_title);
/*
            if (playerList[indexer] == tempPlayer)
            {
                
            }//end 
*/
        }
    }
}
