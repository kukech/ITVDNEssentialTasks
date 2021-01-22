using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:  
Создать классы Point и Figure.
Класс Point должен содержать два целочисленных поля и одно строковое поле.
Создать три свойства с одним методом доступа get.  
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
аргументов.
    
    Класс Figure  должен содержать конструкторы, которые принимают от 3-х до 5-ти
аргументов типа Point. 

Создать два  метода:  
    double LengthSide(Point A, Point B), который рассчитывает длину
стороны многоугольника; 
    void PerimeterCalculator(),  который рассчитывает периметр
многоугольника.

Написать программу, которая выводит на экран название и периметр многоугольника. */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many corners does your polygon have? :");
            int cornersCount = int.Parse(Console.ReadLine());
            Point[] polygonPoints = new Point[cornersCount];

            Console.WriteLine("Input coordinates point: ");
            for (int i = 0; i < polygonPoints.Length; i++)
            {
                int tempX, tempY;

                Console.Write($"x{i} = ");
                tempX = int.Parse(Console.ReadLine());

                Console.Write($"y{i} = ");
                tempY = int.Parse(Console.ReadLine());

                polygonPoints[i] = new Point(tempX, tempY);
            }

            Figure polygon = new Figure(polygonPoints);
            polygon.PerimeterCalculator();

            Console.Read();

        }
    }
}
