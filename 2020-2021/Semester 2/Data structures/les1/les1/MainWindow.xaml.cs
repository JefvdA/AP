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

namespace les1
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

        private void btnSomBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = Convert.ToInt32(tbGetal1.Text);
            int getal2 = Convert.ToInt32(tbGetal2.Text);

            int som = getal1 + getal2;

            textBlockAntwoord.Text = $"{getal1} + {getal2} = {som}";
        }

        private void btnVerschilBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = Convert.ToInt32(tbGetal1.Text);
            int getal2 = Convert.ToInt32(tbGetal2.Text);

            int verschil = getal1 - getal2;

            textBlockAntwoord.Text = $"{getal1} - {getal2} = {verschil}";
        }
    }
}
