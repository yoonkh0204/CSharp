using System;

namespace IfStApp
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.Write("Enter a number = ");
            n = Console.Read() - '0';
            if (n % 2 == 0)
                Console.WriteLine(n + " is an even number.");
            if (n % 2 != 0)
                Console.WriteLine(n + " is an odd number.");

        }

    }
 }
