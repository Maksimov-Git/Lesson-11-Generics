using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_Generic_2
{
    class MyClass<TYPE1, TYPE2>
    {
        private TYPE1 v1;
        private TYPE2 v2;

        public MyClass(TYPE1 tYPE1, TYPE2 tYPE2)
        {
            this.v1 = tYPE1;
            this.v2 = tYPE2;
        }

        public TYPE1 V1
        {
            get { return this.v1; }
            set { this.v1 = value; }
        }

        public TYPE2 V2
        {
            get { return this.v2; }
            set { this.v2 = value; }

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //  создаем эклепмляр класса и в качестве параметра передаем тип int 
            // передаем числа 1 и 2 в конструктор
            MyClass<int, int> my1 = new MyClass<int, int>(1, 2);
            Console.WriteLine(my1.V1 + my1.V2);

            MyClass<string, int> my2 = new MyClass<string, int>("Привет", 2);
            Console.WriteLine(my2.V1 + my2.V2);

            MyClass<string, string> my3 = new MyClass<string, string>("Привет", "Мир");
            Console.WriteLine(my3.V1 + my3.V2);

            Console.ReadKey();

        }
    }
}
