using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    enum Prof
    {
        Master = 100,
        Director = 20,
        Worker = 500,
        Manager = 250
    }
    static class Accauntant
    {
        static public bool AskForBonus(Prof worker, int hours)
        {
            return (int)worker > hours;
        }
    }
    class Program
    {
//        Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
//Присвойте каждой константе значение, задающее количество часов, которые должен отработать
//сотрудник за месяц.  
//Создайте класс  Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее
//давать или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему
//положена премия.
        
        static void Main(string[] args)
        {
            Console.WriteLine("input hour");
            if (Accauntant.AskForBonus(Prof.Director, Convert.ToInt32(Console.ReadLine())))
                Console.WriteLine("he can giving premium");
            else Console.WriteLine("he can't giving premium");
        }
    }
}
