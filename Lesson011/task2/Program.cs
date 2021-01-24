using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
//    Создайте класс  CarCollection<T>.Реализуйте в простейшем приближении возможность
//использования его экземпляра  для создания  парка машин.Минимально требуемый интерфейс
//взаимодействия с экземпляром, должен включать метод добавления  машин с названием машины и
//года ее выпуска, индексатор для получения значения элемента по указанному индексу  и свойство
//только для чтения для получения общего количества элементов.  
//Создайте метод удаления всех машин автопарка. 
    struct Car
    {
        string name;
        int year;
        public string CarInfo
        {
            get
            {
                return name + " - " + Convert.ToString(year);
            }
        }
        public Car(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
    }
    class CarCollection<T> where T:struct
    {
        T[] carList;
        public int Count
        {
            get
            {
                return carList.Length;
            }
        }
        public T this[int index]
        {
            get
            {
                return carList[index];
            }
        }
        public CarCollection()
        {
            carList = new T[0];
        }
        public CarCollection(T[] cars)
        {
            carList = cars;
        }
        public void AddCar(T car)
        {
            carList = carList ?? new T[1];
            Array.Resize<T>(ref carList, carList.Length + 1);
            carList[carList.Length - 1] = car;
        }
        public void Clear()
        {
            this.carList = new T[0];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> cars = new CarCollection<Car>();
            Console.WriteLine("input car count");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                Console.WriteLine("{0} input car, year:", i);
                string stmp = Console.ReadLine();
                int yeartmp = Convert.ToInt32(Console.ReadLine());
                cars.AddCar(new Car(stmp, yeartmp));
            }
            Console.WriteLine(cars[2].CarInfo);
            Console.ReadKey();
        }
    }
}
