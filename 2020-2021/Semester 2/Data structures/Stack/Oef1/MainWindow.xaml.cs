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

namespace Oef1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack<int> stack = new Stack<int>;

        private void btnPush_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(tbInput.Text);
            stack.Push(input);

            UpdateTbOutput();
        }

        private void btnPop_Click(object sender, RoutedEventArgs e)
        {
            if(stack.Count > 0)
                stack.Pop();

            UpdateTbOutput();
        }

        private void UpdateTbOutput()
        {
            tbOutput.Text = "";

            foreach (int item in stack)
            {
                tbOutput.Text += item + " \n";
            }
        }
    }
}
