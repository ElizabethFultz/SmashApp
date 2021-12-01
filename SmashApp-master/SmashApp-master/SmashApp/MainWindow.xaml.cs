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

namespace SmashApp
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

        private void MatchReporting_Click(object sender, RoutedEventArgs e)
        {
            MatchReporting1_UserValidation userValidation = new MatchReporting1_UserValidation();
            this.Visibility = Visibility.Hidden;
            userValidation.Show();
       
        }

        private void User_Profile_Click(object sender, RoutedEventArgs e)
        {
            UserProfile profile = new UserProfile();
            this.Visibility = Visibility.Hidden;
            profile.Show();
        }
    }
}
