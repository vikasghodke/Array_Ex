using System;

namespace Array_EX_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 34, 5, 6, 7, 8, 654, 35 };
            var b = numbers.Length;
            var a = 5;

            Class1 c1 = new Class1();
            c1.RotateLeft(numbers, a,b);
            c1.PrintArray(numbers, a);
        }
    }
}
