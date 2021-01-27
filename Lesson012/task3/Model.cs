using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task3
{
    static class Model
    {
        static public bool isRun = false;
        static TimeSpan tick = new TimeSpan(10000);
        static TimeSpan secondTime = new TimeSpan(100);
        static public TimeSpan SecondTime
        {
            get
            {
                return secondTime;
            }
        }
        static public string Run()
        {
            secondTime += tick;
            return secondTime.ToString();
        }
        static public string Clear()
        {
            secondTime = new TimeSpan(2000);
            return secondTime.ToString();
        }
    }
}
