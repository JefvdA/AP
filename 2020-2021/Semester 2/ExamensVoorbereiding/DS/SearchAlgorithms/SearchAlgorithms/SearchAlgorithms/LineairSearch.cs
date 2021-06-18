using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms.SearchAlgorithms
{
    class LineairSearch
    {
        public static int SearchIndex<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i].Equals(value))
                {
                    return i;
                }
            }
            return int.MinValue;
        }
    }
}
