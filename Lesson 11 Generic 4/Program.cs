using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_Generic_4
{  //  создаем параметризированный делегат 
    delegate R Mydelegate<T, R>(T t);
    //  метод, который будет собщен с экземпляром данного делегата прнимает один аргумент типа указатель места
    


    class Program
    {
        public static int Add(int i)
        {
            return ++i;
        }

        public static string Concat(string s)
        {
            return "Hello" + s + "!";
        }

        static void Main(string[] args)
        {
            Mydelegate<int, int> mydelegate1 = new Mydelegate<int, int>(Add);
            int i = mydelegate1.Invoke(1);
            Console.WriteLine(i);

            Mydelegate<string, string> mydelegate2 = new Mydelegate<string, string>(Concat);
            string s = mydelegate2.Invoke("Привет");
            Console.WriteLine(s);

        }
    }
}
