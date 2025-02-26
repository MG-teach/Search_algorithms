using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class StudentCreator
    {
        private static readonly ImmutableList<string> Names = ImmutableList.Create(
        "Иван", "Георги", "Димитър", "Николай", "Петър",
        "Христо", "Александър", "Стефан", "Васил", "Тодор",
        "Мартин", "Борис", "Андрей", "Кирил", "Симеон",
        "Калоян", "Росен", "Златан", "Божидар", "Деян",
        "Мария", "Иванка", "Елена", "Надежда", "Виктория",
        "Гергана", "Радослава", "Петя", "Миглена", "Силвия",
        "Яна", "Веселина", "Калина", "Теодора", "Анелия",
        "Емилия", "Златина", "Лиляна", "Стела", "Росица"
    );

        private static readonly Random random = new Random();

        public static List<Student> CreateStudents(int count)
        {
            List<Student> students = new();

            for (int i = 0; i < count; i++)
            {
                string name = Names[random.Next(Names.Count)];
                int score = random.Next(20, 101); // Score between 20 and 100
                students.Add(new Student(name, score));
            }

            return students;
        }
    }
}
