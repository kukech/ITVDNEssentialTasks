using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] orrey = new int[5,12];
            Console.WriteLine($"{orrey.GetLongLength(0)}  {orrey.GetLongLength(1)}");
            //изи задача, лень делать
            Console.ReadKey();
        }
    }
}
