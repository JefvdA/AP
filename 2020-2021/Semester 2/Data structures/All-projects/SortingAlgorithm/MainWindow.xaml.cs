using SortingAlgorithm.SortingMethods;
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


namespace SortingAlgorithm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RandomGenerator generator = new RandomGenerator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, RoutedEventArgs e)
        {
            lbUnsorted.Items.Clear();

            int amount = int.Parse(tbAmount.Text);
            int min = int.Parse(tbMin.Text);
            int max = int.Parse(tbMax.Text);
            bool unique = (bool)cbUnique.IsChecked;

            int[] array = generator.Generate(amount, min, max, unique);
            for (int i = 0; i < array.Length; i++)
            {
                lbUnsorted.Items.Add(array[i]);
            }
        }

        private void btSort_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            lbSorted.Items.Clear();
            List<int> list = GetList(lbUnsorted);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            switch (b.Tag)
            {
                case "BS":
                    BubbleSort bs = new BubbleSort();
                    bs.SortList(list);
                    for (int i = 0; i < list.Count; i++)
                    {
                        lbSorted.Items.Add(list[i]);
                    }
                    break;
                case "SS":
                    SelectionSort ss = new SelectionSort();
                    ss.SortList(list);
                    for (int i = 0; i < list.Count; i++)
                    {
                        lbSorted.Items.Add(list[i]);
                    }
                    break;
                case "IS":
                    InsertionSort ins = new InsertionSort();
                    ins.SortList(list);
                    for (int i = 0; i < list.Count; i++)
                    {
                        lbSorted.Items.Add(list[i]);
                    }
                    break;
                case "QS":
                    QuickSort qs = new QuickSort();
                    qs.SortList(list);
                    for (int i = 0; i < list.Count; i++)
                    {
                        lbSorted.Items.Add(list[i]);
                    }
                    break;
            }
            sw.Stop();
            lbTime.Text = $"Tijd: {sw.Elapsed.ToString(@"mm\:ss\.fff")}";
        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            lbUnsorted.Items.Clear();
            lbSorted.Items.Clear();
        }

        private void tbManual_KeyDown(object sender, KeyEventArgs e)
        {
            int nr = 0;
            if(e.Key == Key.Enter && int.TryParse(tbManual.Text, out nr))
            {
                lbUnsorted.Items.Add(nr);
                tbManual.Text = "";
            }
        }

        private List<int> GetList(ListBox box)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < box.Items.Count; i++)
            {
                list.Add((int)box.Items[i]);
            }
            return list;
        }
    }
}
