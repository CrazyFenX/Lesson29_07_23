using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29_07_23
{
    public class Employe : Person
    {
        public string PlaceOfWork;
        public string Post;

        public Employe(string name, string surName, DateTime birthDate, string placeOfWork, string post) : base(name, surName, birthDate)
        {
            PlaceOfWork = placeOfWork;
            Post = post;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nМесто работы - {PlaceOfWork}\n Должность - {Post}\n";
        }
    }
}
