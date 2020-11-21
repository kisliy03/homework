using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task11
{
    public static class Student
    {
        public static string BestStudent(List<string> st, List<int> marks)
        {
            int Max = 0;
            int QuantityStudents = st.Count;

            for (int i = 1; i < QuantityStudents; i++)
            {
                if (marks[i] > marks[Max])
                {
                    Max = i;
                }
            }

            return st[Max];
        }

        public static string WorseStudent(List<string> st, List<int> marks)
        {
            int Min = 0;
            int QuantityStudents = st.Count;

            for (int i = 1; i < QuantityStudents; i++)
            {
                if (marks[i] < marks[Min])
                {
                    Min = i;
                }
            }

            return st[Min];
        }

        public static double AverageMarks(List<int> Marks)
        {
            double Average = 0;

            foreach (int i in Marks)
            {
                Average += i;
            }

            Average = Average / Marks.Count;

            return Average;
        }

        public static void PrintStudents(List<string> st, List<int> Marks)
        {
            int QuantityStudents = st.Count;

            for (int i = 0; i < QuantityStudents; i++)
            {
                Console.WriteLine(st[i] + " " + Marks[i]);
            }
        }

        public static void SortByNameAscend(List<string> st, List<int> Marks)
        {
            int QuantityStudents = st.Count;
            int tempMark;
            string tempSt;

            // Sorting students and marks
            for (int i = 0; i < QuantityStudents; i++)
            {
                for (int j = i + 1; j < QuantityStudents; j++)
                {
                    if (String.Compare(st[i], st[j]) > 0)
                    {
                        // Sort by student name
                        tempSt = st[i];
                        st[i] = st[j];
                        st[j] = tempSt;

                        // Sort by mark
                        tempMark = Marks[i];
                        Marks[i] = Marks[j];
                        Marks[j] = tempMark;
                    }
                }
            }
        }

        public static void SortByNameDescend(List<string> st, List<int> Marks)
        {
            int QuantityStudents = st.Count;
            int tempMark;
            string tempSt;

            // Sorting students and marks
            for (int i = 0; i < QuantityStudents; i++)
            {
                for (int j = i + 1; j < QuantityStudents; j++)
                {
                    if (String.Compare(st[i], st[j]) < 0)
                    {
                        // Sort by student name
                        tempSt = st[i];
                        st[i] = st[j];
                        st[j] = tempSt;

                        // Sort by mark
                        tempMark = Marks[i];
                        Marks[i] = Marks[j];
                        Marks[j] = tempMark;
                    }
                }
            }
        }

        public static void SortByMarksAscend(List<string> st, List<int> Marks)
        {
            int QuantityStudents = st.Count;
            int tempMark;
            string tempSt;

            // Sorting students and marks
            for (int i = 0; i < QuantityStudents; i++)
            {
                for (int j = i + 1; j < QuantityStudents; j++)
                {
                    if (Marks[i] > Marks[j])
                    {
                        // Sort by student name
                        tempSt = st[i];
                        st[i] = st[j];
                        st[j] = tempSt;

                        // Sort by mark
                        tempMark = Marks[i];
                        Marks[i] = Marks[j];
                        Marks[j] = tempMark;
                    }
                }
            }
        }

        public static void SortByMarksDescend(List<string> st, List<int> Marks)
        {
            int QuantityStudents = st.Count;
            int tempMark;
            string tempSt;

            // Sorting students and marks
            for (int i = 0; i < QuantityStudents; i++)
            {
                for (int j = i + 1; j < QuantityStudents; j++)
                {
                    if (Marks[i] < Marks[j])
                    {
                        // Sort by student name
                        tempSt = st[i];
                        st[i] = st[j];
                        st[j] = tempSt;

                        // Sort by mark
                        tempMark = Marks[i];
                        Marks[i] = Marks[j];
                        Marks[j] = tempMark;
                    }
                }
            }
        }
    }
}
