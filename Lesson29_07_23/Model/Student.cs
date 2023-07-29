using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29_07_23
{
    public class Student : Person
    {
        public string University = "";
        public string Faculty = "";
        public int MarkBookNumber = -1;

        public Student(string name, string surName, DateTime birthDate, string university, string faculty, int markBookNumber) : base(name, surName, birthDate)
        {
            University = university;
            Faculty = faculty;
            MarkBookNumber = markBookNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nУниверситет - {University}\nФакультет - {Faculty}\nЗачетная книжка - {MarkBookNumber}\n";
        }
    }
}
