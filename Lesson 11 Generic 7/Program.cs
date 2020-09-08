using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_Generic_7
{
    public abstract class Shape { }
    public class Circle : Shape { }

    // создаем параметризированный интерфейс
    public interface IContainer< in T>// контрвариантность
    {
        T Figure { set; }

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
          set { figure = value; }
        }

        public override string ToString()
        {
            return figure.GetType().ToString();
        }

    }

    //Контравариантностью называется обращение иерархии исходных типов на противоположную в производных типах.
    //Так, если класс String наследуется от класса Object, а делегат Action<T> определён как метод, принимающий
    //объект типа T, то Action<Object> наследуется от делегата Action<String>, а не наоборот.
    //Действительно, если «все строки — объекты», то «всякий метод, оперирующий произвольными объектами, 
    //может выполнить операцию над строкой», но не наоборот.В таком случае говорят, что тип (в данном случае обобщённый делегат)
    //Action<T> контравариантен своему параметру-типу T.


    class Program
    {
        static void Main(string[] args)
        {
            // создали Circle и привели к базовому типу  shape
            Shape shape = new Circle();
            // даункаст невозможен без предварительного пакаста 
            IContainer<Circle> container = new Container<Shape>(shape); // контрвариантность это даункаст параметра типа .
            Console.WriteLine(container.ToString());

            Console.ReadKey();

        }
    }
}
