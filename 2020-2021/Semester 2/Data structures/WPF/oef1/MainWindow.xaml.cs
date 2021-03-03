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

namespace oef1
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string input = tboInput.Text;

            bool isArmstrong = IsArmstrong(input);

            if (isArmstrong)
                tblOutput.Text = $"{input} is een armstrong nummer!";
            else
                tblOutput.Text = $"{input} is geen armstrong nummer!";
        }

        private bool IsArmstrong(string input)
        {
            int lengte = input.Length;

            int nummer = int.Parse(input);
            int som = 0;
            for (int i = lengte; i > 0; i--)
            {
                int exponent = Convert.ToInt32(Math.Pow(10, i - 1));
                int getal = nummer / exponent;
                nummer -= getal * exponent;
                som += Convert.ToInt32(Math.Pow(getal, lengte));
            }

            if (som == int.Parse(input))
                return true;
            else
                return false;
        }
    }
}
