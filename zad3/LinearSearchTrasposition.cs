using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class LinearSearchTrasposition
    {
        public static int Search(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (i > 0)
                    {
                        (array[i], array[i - 1]) = (array[i - 1], array[i]);
                    }
                    return i - 1;
                }
            }
            return -1;
        }
    }
}
