using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
//    Создайте класс House c двумя полями и свойствами.
//Создайте два метода Clone() и DeepClone(), которые выполняют поверхностное и глубокое
//копирование соответственно.Реализуйте простой способ проверки. 
    class House : ICloneable
    {
        int x, y;
        public House z;
        public int X { get; set; }
        public int Y { get; set; }
        public House()
        {
            x = 10;
            y = x + 10;
            X = 20;
            Y = 30;
            z = new House(60, 70, 80, 90);
        }
        public House(int a, int b, int c, int d)
        {
            x = a;
            y = b;
            X = c;
            Y = d;
        }
        public object Clone()
        {
            House house = new House(x, y, X, Y);
            house.z = this.z;
            return house;
        }
        public object DeepClone()
        {
            House house = new House(x, y, X, Y);
            house.z = new House(this.z.x, this.z.y, this.z.X, this.z.Y);
            return house;
        }
        public void Show()
        {
            Console.WriteLine("{0} : {1} : {2} : {3}", x, y, X, Y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.Show();
            house.z.Show();
            House houseclone = (House)house.Clone();
            houseclone.X = 50;
            houseclone.Y = 100;
            houseclone.z.X = 200;

            Console.WriteLine("пiсля звiчайного клонування: ");

            house.Show();
            house.z.Show();
            Console.WriteLine(new string('-', 50));
            houseclone.Show();
            houseclone.z.Show();

            Console.WriteLine("пiсля глiбокогy клонування: " );

            houseclone = (House)house.DeepClone();
            houseclone.X = 15000;
            houseclone.Y = 23000;
            houseclone.z.X = 50000;
            house.Show();
            house.z.Show();
            Console.WriteLine(new string('-', 50));
            houseclone.Show();
            houseclone.z.Show();


            Console.ReadKey();
        }
    }
}
