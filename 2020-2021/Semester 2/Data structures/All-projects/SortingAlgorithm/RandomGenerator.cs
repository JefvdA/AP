using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithm
{
    public class RandomGenerator
    {
        private Random random = new Random();

        public int[] Generate(int amount, int min, int max, bool unique)
        {
            int[] array = new int[amount];
            for (int j = 0; j < amount; j++)
            {
                array[j] = int.MinValue;
            }

            // Generate "Amount" numbers
            for (int i = 0; i < amount; i++)
            {
                int x = random.Next(min, max + 1);

                if (unique) // If "Unique" , make sure new number is unique
                {
                    bool isUnique = false;
                    while (!isUnique)
                    {
                        bool exists = false;
                        for (int j = 0; j < amount; j++)
                        {
                            if (x == array[j])
                            {
                                x = random.Next(min, max + 1);
                                exists = true;
                            }
                        }

                        if (!exists)
                            isUnique = true;
                    }
                }
                array[i] = x;
            }

            return array;
        }
    }
}
