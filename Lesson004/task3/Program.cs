using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void 
Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 
Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
Написать программу, которая выполняет проигрывание и запись. 
*/
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("play");
        }
        public void Record()
        {
            Console.WriteLine("record");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("pause playing");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("pause recording");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("stop playing");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("stop recording");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player plyer = new Player();
            (plyer as IPlayable).Pause();
            (plyer as IRecordable).Pause();
            
            Console.ReadKey();
        }
    }
}
