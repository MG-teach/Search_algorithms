using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class BinarySearchMultiple
    {
        public static List<int>? MultipleSearch(int[] array, int target)
        {
            List<int> indexes = new List<int>();
            
            int left = 0;
            int right = array.Length - 1;
            
            while (left < right) 
            {
                int mid = left + (right - left) / 2;
                if(array[mid] == target)
                {
                    indexes.Add(mid);
                    break;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            if (indexes.Count != 0)
            {

                int i = indexes[0];
                indexes.Clear();
                while (i >= 0 && array[i] == target)
                {
                    --i;
                }

                i++;

                while (i < array.Length && array[i] == target)
                {
                    indexes.Add(i);
                    i++;
                }
            }

            return indexes.Count != 0 ? indexes : null;
        }
    }
}
