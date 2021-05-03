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
        public Sum Sum { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Sum = new Sum { Num1 = "0", Num2 = "0" };
            this.DataContext = Sum;
        }
    }
}
