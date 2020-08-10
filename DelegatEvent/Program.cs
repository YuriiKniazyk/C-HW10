using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public class Program
    {
        public delegate void MyDel(int m);
        static void Main(string[] args)
        {
            List<int> marks = new List<int>();
            
            Student student = new Student("Yurii", marks);
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy(student);

            student.MarkChange += parent.OnMarkChange;
            student.MarkChange += accountancy.PayingFellowship;
            
            student.AddMark(88);
            student.AddMark(95);
            student.AddMark(63);
            
            Console.ReadLine();
        }
    }
}
