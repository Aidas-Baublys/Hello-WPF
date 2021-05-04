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
        }

        private void Topings_Checked(object sender, RoutedEventArgs e)
        {
            bool allChecked = Topings.IsChecked == true;
            Salami.IsChecked = allChecked;
            Mushrooms.IsChecked = allChecked;
            Shit.IsChecked = allChecked;
        }

        private void SingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            Topings.IsChecked = null;

            if (Salami.IsChecked == true && Mushrooms.IsChecked == true && Shit.IsChecked == true)
                Topings.IsChecked = true;

            if (Salami.IsChecked == false && Mushrooms.IsChecked == false && Shit.IsChecked == false)
                Topings.IsChecked = false;
        }
    }
}
