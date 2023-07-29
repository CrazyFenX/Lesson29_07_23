using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29_07_23
{
    public class Person
    {
        public string Name = "";
        public string SurName = "";
        public DateTime BirthDate = DateTime.MinValue;

        public Person(string name, string surName, DateTime birthDate)
        {
            Name = name;
            SurName = surName;  
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"\n-----------------\nИмя - {Name}\n Фамилия - {SurName} \n Дата рождения - {BirthDate.ToShortDateString()}\n";
        }
    }
}
