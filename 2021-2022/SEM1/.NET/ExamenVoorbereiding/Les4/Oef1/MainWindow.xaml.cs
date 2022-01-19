using System.Windows;

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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string barcode = tb_barcode.Text;
            if (barcode.IsEAN13Valid())
                MessageBox.Show("Your barcode is valid!");
            else
                MessageBox.Show("Your barcode is NOT valid!");
        }
    }
}
