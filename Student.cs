using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{

    public class Student
    {
        public string Name { get; set; }
        public string Geburtstag { get; set; }
        private float Note { get; set; }

        public Student(string Name, string Geburtstag, float Note)
        {
            this.Name = Name;
            this.Geburtstag = Geburtstag;
            this.Note = Note;


        }
    }
}
