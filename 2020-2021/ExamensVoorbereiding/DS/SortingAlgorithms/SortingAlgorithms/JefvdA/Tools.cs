using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.JefvdA
{
    class Tools
    {
        public static void SwitchElements(int[] array, int index1, int index2)
        {
            int temp = array[index2];
            array[index2] = array[index1];
            array[index1] = temp;
        }
    }
}
