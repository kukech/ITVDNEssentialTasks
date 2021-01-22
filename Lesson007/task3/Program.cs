using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }
    class Program
    {
        static void ClassTaker(MyClass myclass)
        {
            myclass.change = "edited";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "edited";
        }
        static void Main(string[] args)
        {
            MyClass mycl = new MyClass();
            mycl.change = "not edited";
            MyStruct mystr;
            mystr.change = "not edited";
            Console.WriteLine($"{mycl.change} ||||| {mystr.change}");

            ClassTaker(mycl);
            StructTaker(mystr);
            Console.WriteLine($"{mycl.change} ||||| {mystr.change}");
            //здесь было продемонстрировано что экземпляр распологается на куче и переданная в метод ссылка
            //позволяет работать непосредственно  классом, а структура распологается в стеке
            //поэтому при передаче труктуры методу создается на стеке временный дубликат работая с который, мы не
            //касаемся оригинальной структуры
            Console.ReadLine();
        }
    }
}
