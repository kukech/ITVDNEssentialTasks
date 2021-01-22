using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
//    Создайте класс MyList<T>.Реализуйте в простейшем приближении возможность использования его
//экземпляра аналогично экземпляру класса List<T>.Минимально требуемый интерфейс
//взаимодействия с  экземпляром, должен включать метод добавления элемента, индексатор для
//получения значения элемента по указанному индексу  и свойство только для чтения для получения
//общего количества элементов.
    interface IMyList<T>
    {
        void Add(T varbl);
        T this[int index] { get; }
        int Count { get; }
    }
    class MyList<T> : IMyList<T>
    {
        T[] list;
        public T this[int index] 
        {
            get { return list[index]; }
        }
        public int Count
        {
            get
            {
                return list.Length;
            }
        }
        public MyList(params T[] arr)
        {
            list = arr;
        }
        public void Add(T varbl)
        {
            list = list ?? new T[1] {varbl };
            T[] templist = new T[list.Length + 1];
            Array.Copy(list, templist, list.Length);
            templist[templist.Length - 1] = varbl;
            list = templist;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>(1, 5, 10);
            myList.Add(20);
            for(int i = 0; i < myList.Count; i++)
                Console.WriteLine(myList[i]);
            Console.ReadKey();
        }
    }
}
