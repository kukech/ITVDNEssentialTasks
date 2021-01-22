using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Article
    {
        string name, shop;
        decimal cost;
        public Article(string nn, string sh, decimal cst)
        {
            name = nn;
            shop = sh;
            cost = cst;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"name: {name}, shop: {shop}, cost: {cost}");
        }
    }
    class Store
    {
        Article[] artcl;
        public Article this[int index]
        {
            get
            {
                if (index >= 0 && index < artcl.Length)
                    return artcl[index];
                else
                {
                    Console.WriteLine("invalid index");
                    return null;
                }
            }
            set
            {
                if(value is Article) artcl[index] = value;
            }
        }

        public Store()
        {
            artcl = new Article[5];
            for( int i = 0; i < 5; i++)
            {
                artcl[i] = new Article($"n{i}", $"sh{i}", i * 10000);
                artcl[i].ShowInfo();
            }
        }
        public void ShowAll()
        {
            foreach (Article i in artcl)
                i.ShowInfo();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Store str = new Store();
            Article art = new Article("kui", "tati", 123123);
            str[1] = art;
            str.ShowAll();
            str[1].ShowInfo();
            Console.ReadKey();
        }
    }
}
