using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2  ///////!!!!!!!!!!!!!!!!!!!!ПРИМЕР ХУЙОВОГО СТИЛЯ ПРОГРАМИРОВАИНИЯ!!!!!!!

{
    //    Создайте статический класс с методом void Print(string stroka, int color), который выводит на
    //экран строку заданным цветом.Используя перечисление, создайте набор цветов, доступных
    //пользователю.Ввод строки и выбор цвета предоставьте пользователю.
    enum ColorsString
    {
        Red = 12,
        Green = 10,
        Black = 15,
        White = 0
    }
    static class PrintString
    {
        public static void Print (string stroka, int color)
        {
            ConsoleColor consoleColor = (ConsoleColor) color;
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("change color from list:");
            foreach (ColorsString colors in Enum.GetValues(typeof(ColorsString)))
            Console.WriteLine("{0, 5} - {1}", colors, (int)colors);
            ColorsString color;
            do
            {
                color = (ColorsString)Enum.Parse(typeof(ColorsString), Console.ReadLine());
            }
            while (Enum.IsDefined(typeof(ColorsString), color));

            Console.WriteLine("write text: ");
            string text = Console.ReadLine();

            PrintString.Print(text, (int)color);
            Console.ReadKey();
        }
    }
}
