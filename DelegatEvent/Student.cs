using System.Collections.Generic;
using System.Linq.Expressions;

namespace DelegateEvent
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; }
        public event Program.MyDel MarkChange;

        public Student(string name, List<int> marks )
        {
            Name = name;
            Marks = marks;
        }
        public void AddMark(int newMark)
        {
            Marks.Add(newMark);
            MarkChange?.Invoke(newMark);
        }
    }
}