using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29_07_23
{
    public class Aspirant : Student
    {
        string GraduateWorkTheme = "";

        public Aspirant(string name, string surName, DateTime birthDate, string university, string faculty, int markBookNumber, string graduateWorkTheme) : base(name, surName, birthDate, university, faculty, markBookNumber)
        {
            GraduateWorkTheme = graduateWorkTheme;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nТема кандидатской работы - {GraduateWorkTheme}";
        }
    }
}
