using System;

namespace NewClassProgram3206 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private class Math { 
            static public int Abs(int a)
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(-10));
            ThirdClass abc;
            ABCClass abc2;
            InnerClass inn;
            Console.WriteLine("Hello World!");
        }

        private class InnerClass
        {
        }
    }

    internal class ABCClass
    {
    }
}