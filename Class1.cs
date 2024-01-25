using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Ex_6
{
    internal class Class1
    {
        public void sortDesc(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("After sorting");
            int temp;
            for(int i=0;i<numbers.Length;i++)
            {
                for(int j = i; j < numbers.Length - 1; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;

                    }
                }

                Console.WriteLine("Elements=" + numbers[i]);
            }
        }
    }
}
