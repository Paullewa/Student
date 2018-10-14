
using System;
using System.Runtime.Remoting.Messaging;

namespace StudentSystem
{

    public class Student
    {
        public string Name { get; set; }
        public string Geburtstag { get; set; }


        private double Note { get; set; }

       
        public Student(string Name, string Geburtstag, double Note)
        {
            this.Name = Name;
            this.Geburtstag = Geburtstag;
            this.Note = Note;


        }



        public bool Studierenden(Student student)

        {
            return this.Geburtstag.Equals(student.Geburtstag);
        }

    }
}