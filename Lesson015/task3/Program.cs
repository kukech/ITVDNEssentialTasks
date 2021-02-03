using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
//    Требуется: Описать структуру с именем Price, содержащую следующие поля:  
//•  название товара;  
//•  название магазина, в котором продается товар;  
//•  стоимость товара в гривнах.
//Написать программу, выполняющую следующие действия:  
//•  ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price (записи должны
//быть упорядочены в алфавитном порядке по названиям магазинов);  
//•  вывод на экран информации о товарах, продающихся в магазине, название которого введено с
//клавиатуры(если такого магазина нет, вывести исключение).  
    struct Price
    {
        public string itemname;
        public string shopname;
        public double costgrn;
        public Price(string name, string shop, double cost)
        {
            itemname = name;
            shopname = shop;
            costgrn = cost;
        }
    }
    static class PriceExt
    {
        static public void Sort(this Price[] prices)
        {
            for(int i = 0; i<prices.Length -1; i++)
                for( int j = i+1; j< prices.Length; j++)
                    if(prices[i].shopname[0] > prices[j].shopname[0])
                    {
                        Price tmp = prices[i];
                        prices[i] = prices[j];
                        prices[j] = tmp;
                    }
        }
        static public void Show(this Price[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
                Console.WriteLine("{0, 10} | {1, 10} | {2}", prices[i].itemname, prices[i].shopname, prices[i].costgrn);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Price[] pricearr = new Price[2];
            for (int i = 0; i < pricearr.Length; i++)
                pricearr[i] = new Price(Console.ReadLine(), Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));

            pricearr.Show();
            pricearr.Sort();
            Console.WriteLine(new string('-', 30));
            pricearr.Show();

            try {
                Console.WriteLine("input shop");
                string s = Console.ReadLine();
                bool isFound = false;
                for (int i = 0; i < pricearr.Length; i++)
                    if (pricearr[i].shopname == s) {
                        isFound = true;
                        Console.WriteLine("{0, 10} | {1, 10} | {2}", pricearr[i].itemname, pricearr[i].shopname, pricearr[i].costgrn);
                    }
                if (!isFound) throw new Exception("this shop is not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
