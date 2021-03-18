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

namespace Oef3
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

        StackInt stack = new StackInt();

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            string input = tbInput.Text;
            string[] inputSplitted = input.Split(",");

            foreach(string item in inputSplitted)
            {
                int value = int.Parse(item);
                stack.Push(value);
            }

            tBlOutput.Text = "";
            for (int i = 0; i < inputSplitted.Length; i++)
            {
                tBlOutput.Text += $"{stack.Pop()} ";
            }
        }
    }
}
