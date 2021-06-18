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

namespace Stack
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

        Stack<int> stack = new Stack<int>();

        private void btPush_Click(object sender, RoutedEventArgs e)
        {
            int value = Convert.ToInt32(tbInputStack.Text);
            stack.Push(value);

            tbInputStack.Text = "";
            if (!btPop.IsEnabled)
                btPop.IsEnabled = true;
        }

        private void btPop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value = stack.Pop();
                lbOutputStack.Items.Add(value);

                if (stack.IsEmpty())
                    btPop.IsEnabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, can't pop");
            }

        }

        private void tbInputStack_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value;
            if (int.TryParse(tbInputStack.Text, out value) && !btPush.IsEnabled)
                btPush.IsEnabled = true;
            else if (!int.TryParse(tbInputStack.Text, out value) && btPush.IsEnabled)
                btPush.IsEnabled = false;
        }
    }
}
