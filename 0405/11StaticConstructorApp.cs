using System;

namespace StaticConstructorApp
{
    class StaticConstructor
    {
        static int staticWithinitializer = 100;
        static int staticWithNoInitializer;
        StaticConstructor()
        { // 매개변수와 접근 수정자를 가질 수 없다.
            staticWithNoInitializer = staticWithinitializer + 100;
        }
        public static void PrintStaticVariable()
        {
            Console.WriteLine("field 1 = {0}, field 2 = {1}", staticWithinitializer, staticWithNoInitializer);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StaticConstructor.PrintStaticVariable();
        }
    }
}
