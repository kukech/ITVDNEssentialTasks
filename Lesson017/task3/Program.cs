using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
//    Используя Visual Studio, создайте проект по шаблону Console Application
//Используя динамические и анонимные типы данных, создайте Англо-Русский словарь на 10 слов и
//выведите на экран его содержание.
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<dynamic, dynamic>
            {
                { "dsfasdf" ,  "sdfsdfsdf" },
                { "yhygsddfasdf", "dggvvvv"},
                { " sdfsdfsdfsdfsdfdsf", "jvjvjvjvjv" }
            };

            foreach(var i in dict)
                Console.WriteLine($"{i.Key,30}, {i.Value}");

            dynamic dtemp = "kui tati";
            var temp = new { item = "kal",item2 = dtemp };
            Console.WriteLine(temp.item2);
            Console.ReadKey();
        }
    }
}
