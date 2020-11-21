using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Task11;

namespace StudentTestProject
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> students = new List<string> { "A", "B" };
            List<int> marks = new List<int> { 3, 4 };
            string expected = "B";

            string actual = Student.BestStudent(students, marks);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<string> students = new List<string> { "A", "B" };
            List<int> marks = new List<int> { 3, 4 };
            string expected = "A";

            string actual = Student.WorseStudent(students, marks);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<int> marks = new List<int> { 3, 4, 5, 6 };
            double expected = 4.5;

            double actual = Student.AverageMarks(marks);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<string> students = new List<string> { "B", "C", "D", "A" };
            List<int> marks = new List<int> { 4, 5, 6, 3 };
            List<string> expected1 = new List<string> { "A", "B", "C", "D" };
            List<int> expected2 = new List<int> { 3, 4, 5, 6 };

            Student.SortByNameAscend(students, marks);

            if (students != expected1 || marks != expected2)
            {
                Assert.Fail();
            }
        }
    }
}
