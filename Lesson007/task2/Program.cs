using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    struct Train
    {
        string point;
        int number;
        string time;
        public Train(int num, string pnt, string time)
        {
            this.number = num;
            this.point = pnt;
            this.time = time;
        }
        public string Point
        {
            get
            {
                return point;
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
        }
        public string Time
        {
            get
            {
                return time;
            }
        }
    }
    static class WorkWithTrain
    {
        public static void PutTrains(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine("input number train: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("name point of coming: ");
                string pnt = Console.ReadLine();
                Console.WriteLine("coming time: ");
                string tm = Console.ReadLine();
                train[i] = new Train(num, pnt, tm);
            }
        }
        public static void Sort(Train[] train)
        {
            for (int i = 0; i< train.Length-1; i++)
                for(int j = i+1; j< train.Length;j++)
                    if(train[i].Number > train[j].Number)
                    {
                        Train temp = train[i];
                        train[i] = train[j];
                        train[j] = temp;
                    }
        }
        public static void Show(this Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
                Console.WriteLine($"train #{trains[i].Number} coming to {trains[i].Point} in {trains[i].Time}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train[] train = new Train[4];
            WorkWithTrain.PutTrains(train);
            WorkWithTrain.Sort(train);
            train.Show();
            //дальше делать задание не вижу смысла
            Console.ReadKey();
        }
    }
}
