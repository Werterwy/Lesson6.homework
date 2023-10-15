using C.P;
using Lesson6.homework.file;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.homework
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(100, "Audar", "Merke");
            string v = Person.info(person);

            Constants constants = new Constants();
            int a = Constants.a;
            int b = Constants.b;
            int c = Constants.c;
            string d=Constants.d;
            string f=Constants.f;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d+" "+f);
        }  
    }
}
