using System;

namespace MultiCasApp
{
    delegate void MultiCastDelegate();
    class Schedule
    {
        public void Now()
        {
            Console.WriteLine("Time : " + DateTime.Now.ToString());
        }
        public static void Today()
        {
            Console.WriteLine("Date : " + DateTime.Today.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Schedule obj = new Schedule();
            MultiCastDelegate mcd = new MultiCastDelegate(obj.Now);
            mcd += new MultiCastDelegate(Schedule.Today);
            mcd();
        }
    }
}

