using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class LinearSearchMoveToFront
    {
        public static int Search(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (i > 0)
                    {
                        (array[i], array[0]) = (array[0], array[i]);
                    }
                    return 0;
                }
            }
            return -1;
        }
    }
}
