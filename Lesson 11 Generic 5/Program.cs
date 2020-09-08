using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_Generic_5
{
    public abstract class Shape { }
    public class Circle : Shape { }

    // создаем параметризированный интерфейс
    public interface IContainer<T>
    {
        T Figure { get; set; }

    }
    // создаем класс Container   параметризированный типом T и реалиизующий интерфейс
    //интерфейс Icontainner параметризованный типом T
    public class Container<T> : IContainer<T>
    {
        public T Figure { get; set; }
        
        public Container(T figure)
        {
            this.Figure = figure;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            IContainer<Circle> container = new Container<Circle>(circle);

          

            Console.WriteLine(container.Figure.ToString());

            Console.ReadKey();

        }
    }
}
