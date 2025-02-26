namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University();

            Console.Write("How many students do you need: ");
            int count = int.Parse(Console.ReadLine());

            List<Student> students = StudentCreator.CreateStudents(count);
            university.AddStudents(students);

            Console.WriteLine("Students created:");
            Console.WriteLine("{0, 10}{1, 10}","Name", "Score");
            Console.WriteLine("-------------------------");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Enter a student score to find: ");
            int score = int.Parse(Console.ReadLine());

            int found = university.FindStudentByScore(score);

            if (found != -1)
            {
                Console.WriteLine($"Student found at index {found}:");
                Console.WriteLine("{0, 10}{1, 10}", "Name", "Score");
                Console.WriteLine("-------------------------");
                Console.WriteLine(university.Students[found]);
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }
    }
}
