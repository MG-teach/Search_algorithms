namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете големината на масива: ");
            int size = int.Parse(Console.ReadLine());

            Console.Write("Въведете числото за търсене: ");
            int target = int.Parse(Console.ReadLine());

            bool sorted = false;
            int[] array = ArrayCreator.CreateArray(size, sorted);

            Console.WriteLine(string.Join(' ', array));

            int result = LinearSearchTrasposition.Search(array, target);

            if (result != -1)
            {
                Console.WriteLine($"Числото е намерено на индекс {result}.");
            }
            else
            {
                Console.WriteLine("Числото не е намерено.");
            }
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
