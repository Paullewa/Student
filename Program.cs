using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Student st = new Student("Paul", "16.04.1234.", 1.0);
            Student tz = new Student(" Benir", "16.04.1234.", 2.4);
            Console.WriteLine(st.Studierenden(tz));
            Console.ReadKey();

        }
    }
}
