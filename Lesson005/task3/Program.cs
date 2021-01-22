using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        class MyMatrix
        {
            private double[,] matrix;

            double this[int a, int b]
            {
                get { 
                    return matrix[a, b]; 
                } 
                set 
                {
                    matrix[a, b] = value;
                }
            }

            public MyMatrix()
            {
                matrix = new double[3, 3];
                Random random = new Random();
                for(int i = 0; i < matrix.GetLongLength(0);i++ )
                    for(int j = 0; j < matrix.GetLongLength(1); j++)
                    matrix[i,j] = random.Next(1, 50);
                Console.WriteLine("created matrix 3x3");
                ShowMatrix();
            }
            public MyMatrix(int a, int b)
            {
                matrix = new double[a, b];
                Random random = new Random();
                for (int i = 0; i < a; i++)
                    for (int j = 0; j < b; j++)
                        matrix[i, j] = random.Next(1, 50);
                Console.WriteLine("created matrix {0}x{1}", a, b);
            }
            public void ShowMatrix()
            {
                for (int i = 0; i < matrix.GetLongLength(0); i++) 
                {
                    for (int j = 0; j < matrix.GetLongLength(1); j++)
                        Console.Write($"{matrix[i, j], 3}  ");
                    Console.WriteLine();
                }
            }
            public void ReSize(int row, int col)
            {
                double[,] newmx = new double[row, col];
                Random rand = new Random();
                for (int i = 0; i < Math.Max(matrix.GetLongLength(0), row); i++)
                    for (int j = 0; j < Math.Max(matrix.GetLongLength(1), col); j++)
                        if (i < matrix.GetLongLength(0) && j < matrix.GetLongLength(1))
                            newmx[i, j] = matrix[i, j];
                        else
                            newmx[i, j] = rand.Next(1, 50);
                matrix = newmx;
            }
            // public void DeriveMatrix(int rowS, int colS, int rowE, int colE){}
        }
        static void Main(string[] args)
        {
            MyMatrix mmx = new MyMatrix();
            mmx.ReSize(10, 10);
            mmx.ShowMatrix();
            Console.ReadKey();
        }
    }
}
