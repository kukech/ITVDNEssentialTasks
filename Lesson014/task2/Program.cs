using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
//    Создайте коллекцию MyList<T>.Реализуйте в простейшем приближении возможность использования
//ее экземпляра аналогично экземпляру класса List<T>.Минимально требуемый интерфейс
//взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
//получения значения элемента по указанному индексу и свойство только для чтения для получения
//общего количества элементов. Реализуйте возможность перебора элементов коллекции в цикле
//foreach
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[3] { "safdsdf", "sdfsdfsdf", "sdfsdfsdf" };
            MyList<string> list = new MyList<string>(s);
            foreach(string i in list)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
