using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
//    Создайте класс, который будет содержать информацию о дате(день, месяц, год). С помощью
//механизма перегрузки операторов, определите операцию разности двух дат(результат в виде
//количества дней между датами), а также операцию увеличения даты на определенное количество дней.
    class MyDate 
    {
        public int day { get; }
        public int month { get; }
        public int year { get; }
        readonly static int MAX_DAY = 30, MAX_MONTH = 12; // обусловимся, что дней максимум 30
        public MyDate()
        {
            day = 1;
            month = 1;
            year = 2000;
        }
        public MyDate(int days, int months, int years)
        {
            day = days;
            month = months;
            year = years;
        }
        static public int operator - (MyDate a, MyDate b)
        {
            int dayA = a.year * MyDate.MAX_MONTH * MyDate.MAX_DAY + a.month * MAX_DAY + a.day;
            int dayB = b.year * MyDate.MAX_MONTH * MyDate.MAX_DAY + b.month * MAX_DAY + b.day;
            return Math.Abs(dayA - dayB);
        }

        static public MyDate operator +(MyDate a, int b)
        {
            MyDate tmp = a;
            int year = b / (MAX_DAY * MAX_MONTH) + a.year;
            b -= b / (MAX_DAY * MAX_MONTH) * MAX_DAY * MAX_MONTH;

            int month = b / MAX_DAY;
            if (month + a.month > MAX_MONTH)
            {
                year++;
                month = month + a.month - MAX_MONTH;
            }
            else month += a.month;
            b -= b/MAX_DAY * MAX_DAY;

            if (b + a.day > MAX_DAY)
            {
                if (month++ > MAX_MONTH)
                {
                    year++;
                    month = 1;
                }
                b = b + a.day - MAX_DAY;
            }
            
            return new MyDate(b, month, year);
        }
        public override string ToString()
        {
            return day.ToString() + '.' + month.ToString() + '.' + year.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDate myDate = new MyDate();
            MyDate myDate1 = new MyDate(27, 7, 2021);
            Console.WriteLine(myDate.ToString());
            Console.WriteLine(myDate1.ToString());
            Console.WriteLine(myDate - myDate1);

            MyDate myDate2 = myDate1 + 415;
            Console.WriteLine(myDate2.ToString());
            Console.ReadKey();
        }
    }
}
