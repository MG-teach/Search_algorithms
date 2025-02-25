using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class ArrayCreator
    {
        public static int[] CreateArray(int size, bool sorted)
        {
            Random random = new Random(Environment.TickCount);
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, size / 3);
            }
            if (sorted)
            {
                Array.Sort(array);
            }
            return array;
        }
    }
}
