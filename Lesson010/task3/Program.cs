using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
//    Создайте класс MyDictionary<TKey, TValue>.Реализуйте в простейшем приближении возможность
//использования его экземпляра аналогично экземпляру  класса Dictionary(Урок 6 пример 5). 
//Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод
//добавления пар элементов, индексатор для получения значения элемента по указанному индексу и
//свойство только для чтения для получения общего количества пар элементов.
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public string this[int index]
        {
            get
            {
                return keys[index] + " " + values[index];
            }
        }
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempkey = new TKey[keys.Length + 1];
            Array.Copy(keys, tempkey, keys.Length);
            tempkey[tempkey.Length - 1] = key;
            keys = tempkey;

            TValue[] tempvalues = new TValue[values.Length + 1];
            Array.Copy(values, tempvalues, values.Length);
            tempvalues[tempvalues.Length - 1] = value;
            values = tempvalues;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
