using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Ex_4
{
    internal class Class1
    {
        public void ReverseArray(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Array.Reverse(numbers);
            foreach(int value in  numbers){
                Console.WriteLine("Reversed Array" +value);

            }
            Console.ReadLine();
        }
    }
}
