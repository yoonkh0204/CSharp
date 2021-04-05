using System;

namespace PropertyApp
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
        public override string ToString()
        {
            return (numerator + "/" + denominator);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(); int i;
            f.Numerator = 1; // invoke set-accessor in Numerator
            i = f.Numerator + 1; // invoke get-accessor in Numerator
            f.Denominator = i;  // invoke set-accessor in Denominator
            Console.WriteLine(f.ToString());
        }
    }
}
