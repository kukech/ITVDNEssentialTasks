using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Vechile
    {
        protected readonly double x, y, cost, speed;
        protected readonly int year;
        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get;
        }
        public double Cost
        {
            get;
        }
        public double Speed
        {
            get;
        }
        public int Year
        {
            get;
        }
        public Vechile(double x, double y, double cost, double speed, int year)
        {
            this.x = x;
            this.y = y;
            this.cost = cost;
            this.speed = speed;
            this.year = year;
        }
    }
    class Plane : Vechile
    {
        double height;
        int passengerCount;
        public double Height
        {
            get;set;
        }
        public int PassengerCount
        {
            get;set;
        }
        public Plane(double x, double y, double cost, double speed, int year)
            : base(x, y, cost, speed, year)
        {

        }
    }
    class Car : Vechile
    {
        public Car(double x, double y, double cost, double speed, int year)
            : base(x, y, cost, speed, year)
        {

        }

    }
    class Ship : Vechile
    {
        int passengerCount;
        string mainPort;
        public int PassengerCount
        {
            get; set;
        }
        public string MainPort
        {
            get; set;
        }
        public Ship(double x, double y, double cost, double speed, int year)
            : base(x, y, cost, speed, year)
        {

        }
    }
}
