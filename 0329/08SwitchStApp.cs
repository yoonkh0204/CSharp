﻿using System;

namespace SwitchStApp
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the day number 1 ~ 7 : ");
            int day = Console.Read() - '0';
            switch (day)
            {
                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday"); break;
                case 3: Console.WriteLine("Tuesday"); break;
                case 4: Console.WriteLine("Wednesday"); break;
                case 5: Console.WriteLine("Thursday"); break;
                case 6: Console.WriteLine("Friday"); break;
                case 7: Console.WriteLine("Saturday"); break;
                default: Console.WriteLine("Illegal day"); break;
            }
        }

    }
 }
