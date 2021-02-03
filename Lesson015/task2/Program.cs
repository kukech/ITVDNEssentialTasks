using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    struct Worker
    {
        public string name;
        public string position;
        public int startworkyear;
        public Worker(string name, string pos, int year)
        {
            if(year > 2201 || year < 0)
            {
                Exception ex = new Exception("не правильно введена дата," +
                    " правильный формат: четырехзначное число в пределах 0 - 2200");
                throw ex;
            }
            this.name = name;
            this.position = pos;
            this.startworkyear = year;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];
            try
            {
                Console.WriteLine("input name, position and year start of work");
                for (int i = 0; i < workers.Length; i++)
                    workers[i] = new Worker(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 0; i < workers.Length; i++)
                Console.WriteLine("{0,10}:{1,10}:{2}", workers[i].name, workers[i].position, workers[i].startworkyear);
            Console.ReadLine();
        }
    }
}
