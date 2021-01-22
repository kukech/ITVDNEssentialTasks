using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
//    Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать класс Vehicle.
//В теле класса создайте поля:   координаты и параметры средств передвижения (цена, скорость, год
//выпуска).  
//Создайте 3 производных класса Plane, Саг и Ship.
//Для класса Plane должна быть определена высота и количество пассажиров.  
//Для класса Ship — количество пассажиров и порт приписки.
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

    class Program
    {
        static void Main(string[] args)
        {
            Plane temp = new Plane(10, 20, 15000, 300, 1998) { Height = 3000, PassengerCount = 20 };
            Console.WriteLine($"x = {temp.X}, y = {temp.Y}, cost = {temp.Cost}$, speed = {temp.Speed}, " + 
                $" year = {temp.Year}, height = {temp.Height}");

            Console.ReadKey();
        }
    }
}
