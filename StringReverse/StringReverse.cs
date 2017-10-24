namespace _StringReverse
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] reverse = input.ToCharArray();
            Array.Reverse(reverse);
            Console.WriteLine(reverse);
        }
    }
}