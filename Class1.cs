using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Ex_3
{
    internal class Class1
    {
        public void SortDesc(int[] numbers)
        {
            int temp;
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = i; j < numbers.Length - 1; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;

                    }
                }
                
            }
        }
        public void SortedArray(int[] numbers)
        {
            for(int i=0;i<numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
