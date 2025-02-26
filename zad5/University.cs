using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class University
    {
        private readonly List<Student> students;

        public University()
        {
            students = new List<Student>();
        }

        public ReadOnlyCollection<Student> Students => students.AsReadOnly();

        public void AddStudent(Student student)
        {
            students.Add(student);

            SortStudents(students, 0, students.Count - 1);
        }

        public void AddStudents(List<Student> studentsList)
        {
            students.AddRange(studentsList);

            SortStudents(students, 0, students.Count - 1);
        }

        public int FindStudentByScore(int score)
        {
            // Setting the left and right pointers
            int left = 0;
            int right = students.Count - 1;

            // Binary search
            while (left <= right)
            {
                // Calculating the middle index
                int mid = left + (right - left) / 2;
                
                // If the score is found, return the index
                if (students[mid].Score == score)
                {
                    return mid;
                }
                // If the score is smaller than the middle element, search in the left half
                else if (students[mid].Score < score)
                {
                    left = mid + 1;
                }
                // If the score is greater than the middle element, search in the right half
                else
                {
                    right = mid - 1;
                }
            }

            // If the score is not found, return -1
            return -1;
        }

        private static void SortStudents(List<Student> studentsList, int low, int high)
        {
            if(low < high)
            {
                int pivot = Partition(studentsList, low, high);
                SortStudents(studentsList, low, pivot - 1);
                SortStudents(studentsList, pivot + 1, high);
            }
        }

        private static int Partition(List<Student> studentsList, int low, int high)
        {
            // Choosing the last element as the pivot
            // Here we can have another strategy for choosing the pivot
            // For example, we can choose the middle element
            // Or we can choose a random element
            // Or we can choose the median of the first, middle and last element
            Student pivot = studentsList[high];
            
            // Index of the smaller element
            int i = low - 1;
            
            // Iterate over the array
            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than the pivot
                if (studentsList[j].Score < pivot.Score)
                {
                    // Switch with the element next to the last smaller element
                    (studentsList[++i], studentsList[j]) = (studentsList[j], studentsList[i]);
                }
            }

            // Switch the pivot with the element next to the last smaller element
            (studentsList[i + 1], studentsList[high]) = (studentsList[high], studentsList[i + 1]);

            // Return the index of the pivot
            return i + 1;
        }
    }
}
