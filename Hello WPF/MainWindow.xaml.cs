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

namespace Hello_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Naciai", Team2 = "Duchai", Score1 = 4, Score2 = 2, Progress = 77 });
            matches.Add(new Match() { Team1 = "Bybiai", Team2 = "Pizdukai", Score1 = 1, Score2 = 1, Progress = 23 });
            matches.Add(new Match() { Team1 = "Daunai", Team2 = "Autistai", Score1 = 0, Score2 = 0, Progress = 98 });
            matches.Add(new Match() { Team1 = "Ožiai", Team2 = "Avinai", Score1 = 2, Score2 = 1, Progress = 50 });

            Matches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Matches.SelectedItem != null)
            {
                MessageBox.Show("Ojojoi kokios rungtinės, pizė.");
            }
            else
            {
                MessageBox.Show("Pasirink rungtinės kokias nors, pidare.");
            }
        }
    }
}
