using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Student
    {
        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
        public string Name { get; }
        public int Score { get; }

        public override string ToString() => $"{Name, 10}  : {Score, 5}";
    }
}
