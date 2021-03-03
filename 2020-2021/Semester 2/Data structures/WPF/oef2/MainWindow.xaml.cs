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

namespace oef2
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

        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            string input = tboInput.Text;
            int key = Convert.ToInt32(slKey.Value);

            char[] inputCharArray = stringToCharArray(input);
            char[] inputEncrypted = Encrypt(inputCharArray, key);

            string output = new string(inputEncrypted);

            tbloOutput.Text = output;
        }

        private void btnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            string input = tboInput.Text;
            int key = Convert.ToInt32(slKey.Value);

            char[] inputCharArray = stringToCharArray(input);
            char[] inputEncrypted = Decrypt(inputCharArray, key);

            string output = new string(inputEncrypted);

            tbloOutput.Text = output;
        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            string output = tbloOutput.Text;
            tboInput.Text = output;
        }

        private char[] Encrypt(char[] charArray, int key)
        {
            char[] result = new char[charArray.Length];
            //werkt enkel voor kleine letters
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ' ')
                    result[i] = ' ';
                else
                {
                    int newchar = (int)charArray[i] + key;
                    if (newchar > 122) //nodig voor encrypt
                        newchar -= 26;
                    else if (newchar < 97) //nodig voor decrypt
                        newchar += 26;

                    result[i] = (char)newchar;
                }
            }
            return result;
        }

        private char[] Decrypt(char[] charArray, int key)
        {
            return Encrypt(charArray, -key);
        }

        private char[] stringToCharArray(string text)
        {
            int length = text.Length;
            char[] output = new char[length];

            for (int i = 0; i < length; i++)
            {
                output[i] = text[i];
            }

            return output;
        }
    }
}
