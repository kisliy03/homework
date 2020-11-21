using System;
using System.Collections.Generic;
using System.Numerics;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Students = new List<string> { "C", "R", "G", "Z", "E" };
            List<int> Marks = new List<int> { 5, 6, 7, 9, 8 };

            Console.WriteLine("Best student: " + Student.BestStudent(Students, Marks));
            Console.WriteLine("Worse student: " + Student.WorseStudent(Students, Marks));
            Console.WriteLine("Average marks: " + Student.AverageMarks(Marks));

            Console.WriteLine("Sort ascend by name:");
            Student.SortByNameAscend(Students, Marks);
            Student.PrintStudents(Students, Marks);

            Console.WriteLine("Sort descend by name:");
            Student.SortByNameDescend(Students, Marks);
            Student.PrintStudents(Students, Marks);

            Console.WriteLine("Sort ascend by marks:");
            Student.SortByMarksAscend(Students, Marks);
            Student.PrintStudents(Students, Marks);

            Console.WriteLine("Sort descend by marks:");
            Student.SortByMarksDescend(Students, Marks);
            Student.PrintStudents(Students, Marks);
        }

        public static void task1(Vector<double> vec)
        {

        }
    }
}
