﻿using System;

namespace JumpStApp
{
    class Program
    {
        static int sum(int s, int i)
        {
            return s + i;
        }
        public static void Main()
        {
            int n, s, i;
            for (; ; )
            {
                Console.Write("Enter a number : ");
                n = Int32.Parse(Console.ReadLine());
                if (n == 0) break;
                else if (n < 0) continue;
                for (s = 0, i = 1; i <= n; ++i)
                    s = sum(s, i);
                Console.WriteLine("n = {0}, sum = {1}", n, s);
            }
            Console.WriteLine("End of Main");
        }

    }
 }
