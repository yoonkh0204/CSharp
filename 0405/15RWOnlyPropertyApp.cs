﻿using System;

namespace RWOnlyPropertyApp
{
    class RWOnlyProperty
    {
        private int readOnlyField = 100;
        private int writeOnlyField;
        public int ReadOnlyProperty
        {
            get
            {
                Console.WriteLine("In the ReadOnlyProperty ..");
                return readOnlyField;
            }
        }
        public int WriteOnlyProperty
        {
            set
            {
                Console.WriteLine("In the WriteOnlyProperty...");
                writeOnlyField = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RWOnlyProperty obj = new RWOnlyProperty();
            obj.WriteOnlyProperty = obj.ReadOnlyProperty;
            Console.WriteLine("value = " + obj.WriteOnlyField); // Compile Error
        }
    }
}
