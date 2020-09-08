using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_Generic_3
{

    class MyClass
    {
        public void Method<T>(T arg)
        {
            T var = arg;
            Console.WriteLine(var);

        }
    }
    class Program
    {
        static void Main(string[] args)
        { // проинстансировали класс myclass 
            MyClass my = new MyClass();
            my.Method<string>("Привет мир");

            my.Method("Привет мир! ");



            Console.ReadKey();
        }
    }
}
