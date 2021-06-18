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

namespace Queue
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

        #region lineairQueue
        LineairQueue<int> lineairQueue = new LineairQueue<int>();

        private void btEnqueue_Click(object sender, RoutedEventArgs e)
        {
            int value = Convert.ToInt32(tbIn.Text);
            lineairQueue.EnQueue(value);

            tbIn.Text = "";
        }

        private void btDequeue_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value = lineairQueue.DeQueue();
                lbOut.Items.Add(value);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, can't dequeue");
            }
        }
        #endregion

        #region circularQueue
        CircularQueue<int> circularQueue = new CircularQueue<int>();

        private void btEnqueue2_Click(object sender, RoutedEventArgs e)
        {
            int value = Convert.ToInt32(tbIn2.Text);
            circularQueue.EnQueue(value);

            tbIn2.Text = "";
        }

        private void btDequeue2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value = circularQueue.DeQueue();
                lbOut2.Items.Add(value);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, can't dequeue");
            }
        }
        #endregion
    }
}
