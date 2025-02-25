using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class LinearSearchMultiple
    {
        public static List<int>? MultipleSearch(int[] array, int target)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    indexes.Add(i);
                }
            }
            return indexes.Count != 0 ? indexes : null;
        }
    }
}
