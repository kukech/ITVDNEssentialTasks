using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Point
    {
        int x, y;
        string pointName;

        public Point()
        {
            x = 1;
            y = 1;
            pointName = "(1,1)";
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            pointName = $"{x},{y}";
        }
        public Point(int x, int y, string pointName)
        {
            this.x = x;
            this.y = y;
            this.pointName = pointName;
        }

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }
        public string PointName
        {
            get
            {
                return pointName;
            }
        }
    }
    class Figure
    {
        Point[] points;

        public Figure(params Point[] points)
        {
            this.points = new Point[points.Length];
            if (points.Length < 3)
                Console.WriteLine("Invalid count of points");
            else
                for (int i = 0; i < points.Length; i++)
                    this.points[i] = points[i];
        }

        public double LengthSide(Point A, Point B)
        {
            double length = Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
            return length;
        }

        public void PerimeterCalculator()
        {
            if (this.points.Length < 3) Console.WriteLine("For begin to initialyze polygon");
            else
            {
                double perimeter = LengthSide(points[0], points[points.Length - 1]);
                for (int i = 0; i < points.Length - 1; i++)
                {
                    perimeter += LengthSide(points[i], points[i + 1]);
                }
                Console.WriteLine($"Perimeter equals {perimeter}");
            }
        }
    }
}
