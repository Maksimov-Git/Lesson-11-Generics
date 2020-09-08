using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.youtube.com/watch?v=BvmvcHroPRg&ab_channel=ExtremeCode

namespace Lesson_11_Generic_6
{
    public abstract class Shape { }
    public class Circle : Shape { }

    // создаем параметризированный интерфейс
    public interface IContainer< out T> // ковариантность 
    {
        T Figure { get; }

    }
    // создаем класс Container   параметризированный типом T и реалиизующий интерфейс
    //интерфейс Icontainner параметризованный типом T
    public class Container<T> : IContainer<T>
    {
        private T figure { get; set; }

        public Container(T figure)
        {
            this.figure = figure;
        }

        public T Figure
        {
            get { return figure; }
        }

    }

    //  Ковариантностью называется сохранение иерархии наследования исходных типов в производных типах в том же порядке.
    // Так, если класс Cat наследуется от класса Animal, то естественно полагать, что перечисление IEnumerable<Cat> 
    // будет потомком перечисления IEnumerable<Animal>.Действительно, «список из пяти кошек» — это частный случай 
    //«списка из пяти животных». В таком случае говорят, что тип (в данном случае обобщённый интерфейс)
    //  IEnumerable<T> ковариантен своему параметру-типу T.

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            IContainer<Shape> container = new Container<Circle>(circle); // ковариантность обощения
            // производится два апкаста , как container  так и поле figure
            // ковариантность позволяет приводить "конкретные типы данных к общим"
            Console.WriteLine(container.Figure.ToString());

            Console.ReadKey();

        }
    }
}
