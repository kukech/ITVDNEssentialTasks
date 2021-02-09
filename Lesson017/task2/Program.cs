using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    //    Используя Visual Studio, создайте проект по шаблону Console Application
    //Представьте, что вы пишите приложение для Автостанции и вам необходимо создать простую
    //коллекцию автомобилей со следующими данными: Марка автомобиля, модель, год выпуска, цвет.А
    //также вторую коллекцию с моделью автомобиля, именем покупателя и его номером телефона.
    //Используя простейший LINQ запрос, выведите на экран информацию о покупателе одного из
    //автомобилей и полную характеристику приобретенной ними модели.
    struct AutoPark
    {
        public string Name { get; }
        public string Model { get; }
        public int Year { get; }
        public string Color { get; }
        public AutoPark(string name, string model, int year, string color)
        {
            Name = name;
            Model = model;
            Year = year;
            Color = color;
        }
        public override string ToString()
        {
            return $"Name: { Name}, Model: {Model}, Year: {Year}, Color{Color}";
        }
    }
    struct Customer
    {
        public string Name { get; }
        public string CustomerName { get; }
        public string Phone { get; }
        public Customer(string model, string name, string phone)
        {
            Name = model;
            CustomerName = name;
            Phone = phone;
        }
        public override string ToString()
        {
            return $"Name: {Name}, CustomerName: {CustomerName}, Phone Number: {Phone}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var listAuto = new List<AutoPark>
            {
                new AutoPark("audi", "100", 1985, "gold"),
            new AutoPark("vw", "passat", 1995, "blue"),
                new AutoPark("uaz", "buhanka", 1896, "gray")
            };
            var listCustomer = new List<Customer>
            {
                new Customer("uaz", "vasily", "8-800-555-3-555"),
                new Customer("vw", "mihail", "2-02-03-27")
            };

            Console.WriteLine("Auto`s list:");
            foreach (AutoPark i in listAuto)
                Console.WriteLine(i.ToString());
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Customers:");
            foreach (Customer i in listCustomer)
                Console.WriteLine(i.ToString());
            Console.WriteLine(new string('-', 50));

            var resultList = from customer in listCustomer
                             join auto in listAuto on customer.Name equals auto.Name
                             select new { 
                                 CustomerName = customer.CustomerName,
                                 PhoneNumber = customer.Phone,
                                 Auto = customer.Name,
                                 Model = auto.Model,
                                 YearAuto = auto.Year,
                                 Color = auto.Color
                             };

            foreach(var i in resultList)
                Console.WriteLine($"Customer: {i.CustomerName}, Phone Number: {i.PhoneNumber} buy Auto: {i.Auto}: {i.Model}" +
                    $" year : {i.YearAuto}, {i.Color}`s color");
            Console.ReadKey();
        }
    }
}
