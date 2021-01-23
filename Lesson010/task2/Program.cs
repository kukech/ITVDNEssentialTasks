using System;

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
        public MyList()
        {
            list = new T[0];
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
    static class ExtentionClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] temp = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
                temp[i] = (T)list[i];
            return temp;
        }
    }
    class Program
    {
//        Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 
//для данного урока.Выведите на экран значения элементов массива, который вернул расширяющий
//метод GetArray()
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>(1, 5, 10);
            myList.Add(20);
            for(int i = 0; i < myList.Count; i++)
                Console.WriteLine(myList[i]);

            int[] array2 = myList.GetArray<int>();
            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine(array2[i]);
            Console.ReadKey();
        }
    }
}
