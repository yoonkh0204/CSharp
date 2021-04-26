using System;

namespace DivByZeroExceptionApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 1, j = 0, k;
            k = i / j;
        }
    }
}

