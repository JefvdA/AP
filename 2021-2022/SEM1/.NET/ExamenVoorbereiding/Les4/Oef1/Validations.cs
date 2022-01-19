using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef1
{
    public static class Validations
    {
        public static bool IsEAN13Valid(this string barcode)
        {
            int evenNumber = 0;
            int onEvenNumber = 0;
            for (int i = 0; i < barcode.Length; i++)
            {
                if (i % 2 != 0)
                    evenNumber += int.Parse(barcode.Substring(i, 1));
                else if (i != barcode.Length - 1)
                    onEvenNumber += int.Parse(barcode.Substring(i, 1));
            }

            return (10 - (((evenNumber * 3) + onEvenNumber) % 10) == int.Parse(barcode.Substring(12, 1)) && barcode.Length == 13);
        }
    }
}
