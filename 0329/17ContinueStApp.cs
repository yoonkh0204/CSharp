using System;

namespace ContinueStApp
{
    class Program
    {   // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
        public static void Main()
        {
            int n, s, i;
            Console.Write("Enter a number = ");
            for (; ; )
            {
                n = Console.Read() - '0';
                if (n == 0) break;
                else if (n < 0) continue;
                for (s = 0, i = 1; i <= n; ++i)
                    s += i;
                Console.WriteLine("n = " + n + ", sum = " + s);
            }
            Console.WriteLine("End of Main");
        }

    }
 }
