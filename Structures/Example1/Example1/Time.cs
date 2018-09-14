using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public struct Time
    {
        private int _hours, _minutes, _seconds;
        
        public Time(int hours, int minutes, int seconds)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
        }

        public void PrintTime()
        {
            Console.WriteLine($"Hours: {_hours}, Minutes: {_minutes}, Seconds: {_seconds}");
        }
    }
}
