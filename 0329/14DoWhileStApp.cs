﻿using System;

namespace DoWhileStApp
{
    class Program
    {   // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
        public static void Main()
        {
            int n, i;
            double h = 0.0;
            Console.Write("Enter a number = ");
            n = Console.Read() - '0';
            i = 1;
            do
            {
                h = h + 1 / (double)i;
                i++;
            } while (i <= n);
            Console.WriteLine("n = " + n + ", h = " + h);

        }

    }
 }
