using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        StackInt stack = new StackInt();

        #region UI
        private void btnPush_Click(object sender, RoutedEventArgs e)
        {
            // Read input value and push it to the stack
            int input = int.Parse(tbInput.Text);
            stack.Push(input);
            tbInput.Text = "";

            // Enable Pop button is it's disabled
            if (!btnPop.IsEnabled)
                btnPop.IsEnabled = true;
        }

        private void btnPop_Click(object sender, RoutedEventArgs e)
        {
            // Pop from stack and put value in output
            int value = stack.Pop();
            lbOutput.Items.Add(value.ToString());
            stack.ShowStack();

            // Check if stack is empty
            if (stack.Top < 0)
                btnPop.IsEnabled = false;
        }
        
        // Check for valid input
        private void tbInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            int x;
            if(!int.TryParse(tbInput.Text, out x) && btnPush.IsEnabled)
            {
                btnPush.IsEnabled = false;
            }
            else if(int.TryParse(tbInput.Text, out x) && !btnPush.IsEnabled)
            {
                btnPush.IsEnabled = true;
            }
        }
        #endregion
    }
}
