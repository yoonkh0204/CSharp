﻿using System;

namespace SwitchStWithString
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the weekday (Sunday-Saturday) : ");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Sunday": Console.WriteLine(1); break;
                case "Monday": Console.WriteLine(2); break;
                case "Tuesday": Console.WriteLine(3); break;
                case "Wednesday": Console.WriteLine(4); break;
                case "Thursday": Console.WriteLine(5); break;
                case "Friday": Console.WriteLine(6); break;
                case "Saturday": Console.WriteLine(7); break;
                default: Console.WriteLine("Illegal day"); break;
            }
        }

    }
 }
