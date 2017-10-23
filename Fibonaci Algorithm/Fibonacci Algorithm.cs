namespace Fibonaci_Algorithm
{
    using System;
    public class Program
    {
        public static void Main()
        {

            int num = int.Parse(Console.ReadLine());
            for (int k = 0; k < num; k++)
            {
                Console.WriteLine(Fibonacci(k));
            }
        }
        public static int Fibonacci(int num)            //Method
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < num; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
