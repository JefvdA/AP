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

        #region Queue
        LineaireQueue queue = new LineaireQueue();
        #endregion

        #region WPF
        private void btnEnqueue_Click(object sender, RoutedEventArgs e)
        {
            int input = int.Parse(tbInput.Text);
            queue.EnQueue(input);
        }

        private void btnDequeue_Click(object sender, RoutedEventArgs e)
        {
            int element = queue.DeQueue();
            lbOutput.Items.Add(element);
        }
        #endregion
    }
}
