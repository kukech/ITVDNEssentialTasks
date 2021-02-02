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
    static class ExtentionList
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] t = new T[list.Count()];
            int i = 0;
            foreach(T secondvar in list)
            {
                t[i] = secondvar;
                i++;
            }
            return t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[3] { "safdsdf", "sdfsdfsdf", "sdfsdfsdf" };
            MyList<string> list = new MyList<string>(s);
            foreach(string i in list)
                Console.WriteLine(i);
            Console.WriteLine(new string('-', 20));

            string[] stwo = list.GetArray<string>();
            foreach(string i in stwo)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
