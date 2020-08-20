using System;

namespace references
{
    class TimePeriod
    {
        private int days;
        public int Days
        {
            get
            {
                return days;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod time = new TimePeriod();
            Console.WriteLine(time.Days);
        }
    }
}
