using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
//    Создайте класс Block с 4-мя полями сторон, переопределите в нем методы:  
//Equals – способный сравнивать блоки между собой,  
//ToString – возвращающий информацию о полях блока.

    class Block
    {
        public int a_1, a_2, a_3, a_4;
        public Block()
        {

        }
        public Block(int a, int b, int c, int d)
        {
            a_1 = a;
            a_2 = b;
            a_3 = c;
            a_4 = d;
        }
        public override bool Equals(object obj)
        {
            Block bl = (Block)obj;
            return this.a_1 == bl.a_1 && this.a_2 == bl.a_2 && this.a_3 == bl.a_3 && this.a_4 == bl.a_4;
        }
        public override string ToString()
        {
            return $"a:{a_1} b:{a_2} c:{a_3} d:{a_4}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Block[] blocks = new Block[2] { new Block(1, 202, 3, 4), new Block(1, 2, 3, 4) };
            Console.WriteLine(blocks[0].ToString());
            Console.WriteLine(blocks[1].ToString());
            Console.WriteLine(blocks[0].Equals(blocks[1]));
            Console.ReadKey();
        }
    }
}
