using System;

namespace IndexOutOfRangeApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] vector = { 1, 2, 3 };
            vector[4] = 4;
        }
    }
}

