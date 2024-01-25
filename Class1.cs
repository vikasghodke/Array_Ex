using System;
using System.Collections.Generic;
using System.Text;

namespace Array_EX_1
{
    internal class Class1
    {
        public void RotateLeft(int[] numbers, int a, int b)
        {
            int[] temp = new int[a];

           
            var k = 0;
            for(int i=b; i < a; i++)
            {
                temp[k] = numbers[i];
                k++;
            }
            
            for(int i = 0; i < a; i++)
            {
                temp[k] = numbers[i];
                k++;
            }

            for(int i=0;i<a;i++)
            {
                numbers[i] = temp[i];
            }
           
        }
        public void PrintArray(int[] numbers, int a)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                {
                    Console.WriteLine(numbers[i].ToString());

                }
            }
        }
    }
}
