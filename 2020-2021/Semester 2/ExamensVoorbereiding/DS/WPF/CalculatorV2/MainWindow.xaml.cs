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

namespace CalculatorV2
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

        double result = 0;
        List<double> inputs = new List<double>();
        List<char> operators = new List<char>();

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            if (addInput())
            {
                lblOutput.Content += "+";
                Calculate();
                operators.Add('+');
            }
        }

        private void btnSubstraction_Click(object sender, RoutedEventArgs e)
        {
            if (addInput())
            {
                lblOutput.Content += "-";
                Calculate();
                operators.Add('-');
            }
        }

        private void btnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            if (addInput())
            {
                lblOutput.Content += "*";
                Calculate();
                operators.Add('*');
            }
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            if (addInput())
            {
                lblOutput.Content += "/";
                Calculate();
                operators.Add('/');
            }
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            string output = lblOutput.Content.ToString();
            lblOutput.Content = output.Remove(output.Length - 1);
            lblOutput.Content += $"={result}";

            inputs.Clear();
            operators.Clear();
            result = 0;
        }

        public void Calculate()
        {
            double x = inputs[inputs.Count - 1];

            char currentOperator;
            if (operators.Count == 0)
                currentOperator = '0';
            else
                currentOperator = operators[operators.Count - 1];

            switch (currentOperator)
            {
                case '+':
                    result += x;
                    break;
                case '-':
                    result -= x;
                    break;
                case '*':
                    result *= x;
                    break;
                case '/':
                    result /= x;
                    break;
                default:
                    result = x;
                    break;
            }
        }

        public bool addInput()
        {
            double input;
            if(double.TryParse(tbInput.Text, out input))
            {
                inputs.Add(input);
                lblOutput.Content += input.ToString();
                return true;
            }
            return false;
        }
    }
}
