using System.Diagnostics;

namespace Overview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Изберете метод за търсене: ");
                Console.WriteLine("1. Linear Search");
                Console.WriteLine("2. Binary Search");
                Console.WriteLine("3. Linear Search Sorted");
                Console.WriteLine("9. End");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 9)
                {
                    break;
                }
                Console.WriteLine($"Your choice: {choice}");

                Console.Write("Въведете големината на масива: ");
                int size = int.Parse(Console.ReadLine());

                Console.Write("Въведете числото за търсене: ");
                int target = int.Parse(Console.ReadLine());


                bool sorted = choice == 2 || choice == 3; // Binary search requires a sorted array
                int[] array = ArrayCreator.CreateArray(size, sorted);

                SearchAlgorithm searchAlgorithm = choice == 1 ? new LinearSearch() : new BinarySearch();

                Stopwatch stopwatch = Stopwatch.StartNew();
                int result = searchAlgorithm.Search(array, target);
                stopwatch.Stop();

                Console.WriteLine(result != -1 ? $"Числото {target} е намерено на индекс {result}." : "Числото не е намерено.");
                Console.WriteLine($"Време за търсене: {stopwatch.ElapsedTicks * 1_000_000_000 / Stopwatch.Frequency:N} ns");
            }
        }
    }
}
