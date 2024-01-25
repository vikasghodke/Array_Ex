using System;

namespace Array_Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 23, 45, 43, 65, 67, 45, 67 };

            Class1 c1 = new Class1();

            c1.SortDesc(numbers);
            c1.SortedArray(numbers);
        }
    }
}
