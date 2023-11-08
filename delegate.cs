using System;
namespace delegateApp
{
    public delegate void calculator(int x, int y);
    class program
    {
        public static void Addition(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("Addition Result is {0}.", result);
        }
        public static void Subtraction(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("Subtraction Result is {0}.", result);
        }
        public static void Multiplication(int x, int y)
        {
            int result = x * y;
            Console.WriteLine("Mulitplication Result is {0}.", result);
        }
        public static void Division(int x, int y)
        {
            if (y != 0)
            {
                int result = x / y;
                Console.WriteLine("Division Result is {0}.", result);
            }
            else
            {
                Console.WriteLine("Division by zero is not valid.");
            }
        }
        public static void Main()
        {
            calculator obj = new calculator(Addition);
            obj(10, 20);
            obj = Subtraction;
            obj(20, 10);
            obj = Multiplication;
            obj(20, 10);
            obj = Division;
            obj(20, 10);
            Console.ReadLine();
        }
    }
}

