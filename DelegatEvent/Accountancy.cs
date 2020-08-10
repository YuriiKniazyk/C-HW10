using System;
using System.Linq;

namespace DelegateEvent
{
    public class Accountancy
    {
        public Student Student;
        public Accountancy(Student student)
        {
            Student = student;
        }
        public void PayingFellowship(int avgMarks)
        {
            if (avgMarks <= 0) throw new ArgumentOutOfRangeException(nameof(avgMarks));
            avgMarks = Student.Marks.Sum()/Student.Marks.Count;
            Console.WriteLine(avgMarks > 71 ? $"Student has a scholarship {avgMarks}" : $"Student doesn't have a scholarship {avgMarks}");
        }
    }
}