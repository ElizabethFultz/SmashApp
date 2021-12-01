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
    /// Interaction logic for MatchReporting5_FinalScores.xaml
    /// </summary>
    public partial class MatchReporting5_FinalScores : Window
    {
        public MatchReporting5_FinalScores()
        {
            InitializeComponent();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Visibility = Visibility.Hidden;
            window.Show();
        }

        public static implicit operator MatchReporting5_FinalScores(MatchReporting3_StageSelection v)
        {
            throw new NotImplementedException();
        }
    }
}
