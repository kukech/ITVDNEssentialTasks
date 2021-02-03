using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dict = new MyDictionary<string, string>();
            dict.Add("украинец", "хохол");
            dict.Add("россиянин", "москаль");
            dict.Add("американец", "пиндос");
            foreach(KeyValueExample<string, string> keyValue in dict)
                Console.WriteLine(keyValue.key + ":" + keyValue.value);

            Console.WriteLine( new string('-', 30));
            Console.WriteLine(dict[1]);
            Console.ReadKey();

        }
    }
}
