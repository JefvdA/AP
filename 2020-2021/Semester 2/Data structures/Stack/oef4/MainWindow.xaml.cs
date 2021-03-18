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

namespace oef4
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

        StackString stack = new StackString();

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            string input = tbInput.Text;
            int openParentheses = 0;
            int closedParentheses = 0;

            foreach(char character in input)
            {
                stack.Push(character.ToString());
            }

            for (int i = 0; i < input.Length; i++)
            {
                string character = stack.Pop();

                if (character == "(")
                    openParentheses++;
                else if (character == ")")
                    closedParentheses++;
            }

            if (openParentheses == closedParentheses)
                MessageBox.Show("De expressie is correct!");
            else
                MessageBox.Show("De expressie is niet correct!");

            tbInput.Text = "";
        }
    }
}
