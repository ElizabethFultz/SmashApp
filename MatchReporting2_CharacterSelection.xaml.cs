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
    /// Interaction logic for MatchReporting2_CharacterSelection.xaml
    /// </summary>
    public partial class MatchReporting2_CharacterSelection : Window
    {

        public MatchReporting2_CharacterSelection()
        {
            InitializeComponent();
        }

        private void ContinueToStageSelection_Click(object sender, RoutedEventArgs e)
        {
            MatchReporting3_StageSelection stageSelection = new MatchReporting3_StageSelection();
            this.Visibility = Visibility.Hidden;
            stageSelection.Show();
        }
    }
}
