using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task1
{
    class Matrix
    {
        object blocker = new object();
        int secondThreadsCount, maxThreadsCount;

        public int MaxThreadsCount
        {
            get
            {
                return maxThreadsCount;
            }
        }
        public int SecondThreadsCount
        {
            get
            {
                return secondThreadsCount;
            }
        }
        public Matrix()
        {
            this.maxThreadsCount = 20;
            this.secondThreadsCount = 0;
        }
        public ThreadStart GetThread()
        {
            secondThreadsCount++;
            return new ThreadStart(CreateChain);
        }
        private void CreateChain()
        {
            int headX = new Random().Next(0, 80);
            int headY = 0;
            int lengthChain = new Random().Next(3, 7);
            int speedChain = new Random().Next(50,500);
            while (true)
            {
                lock (blocker)
                {
                    Console.CursorLeft = headX;
                    if (headY < 39)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.CursorTop = headY;
                        Console.Write(Convert.ToChar(new Random().Next(1, 2)));
                    }
                    else
                    {
                        for(int i = 0; i <= lengthChain; i++)
                        {
                            Console.CursorTop = headY - i;
                            Console.CursorLeft = headX;
                            Console.Write(' ');
                        }
                        break;
                    }
                    if (headY > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.CursorTop = headY - 1;
                        Console.CursorLeft = headX;
                        Console.Write(Convert.ToChar(new Random().Next(2, 3)));
                    }
                    if (headY > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int i = 2; i < lengthChain; i++)
                        {
                            if (headY - i < 0) break;
                            Console.CursorTop = headY - i;
                            Console.CursorLeft = headX;
                            Console.Write(Convert.ToChar(new Random().Next(10 + i, 20 + i)));
                        }
                    }
                    if (headY - lengthChain >= 0)
                    {
                        Console.CursorTop = headY - lengthChain;
                        Console.CursorLeft = headX;
                        Console.Write(' ');
                    }

                    headY++;
                }
                Thread.Sleep(speedChain);
            }
            secondThreadsCount--;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            Console.CursorVisible = false;

            Matrix mx = new Matrix();
            while (true)
            {
                if(mx.SecondThreadsCount < mx.MaxThreadsCount)
                    new Thread(mx.GetThread()).Start();
                Thread.Sleep(500);
            }
        }
    }
}
