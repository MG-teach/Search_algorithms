namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете големината на масива: ");
            int size = int.Parse(Console.ReadLine());

            Console.Write("Въведете числото за търсене: ");
            int target = int.Parse(Console.ReadLine());

            bool sorted = true;
            int[] array = ArrayCreator.CreateArray(size, sorted);

            Console.WriteLine(string.Join(' ', array));

            List<int>? result = BinarySearchMultiple.MultipleSearch(array, target);

            if (result != null)
            {
                Console.WriteLine($"Числото е намерено {result.Count} пъти");
                Console.WriteLine("Индексите на числото са: ");

                foreach (int index in result)
                {
                    Console.WriteLine(index);
                }
            }
            else
            {
                Console.WriteLine("Числото не е намерено.");
            }
        }
    }
}
