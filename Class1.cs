using System;
using System.Collections.Generic;
using System.Text;

namespace Arrray_Ex_2
{
    internal class Class1
    {
        public void SumArray(int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                
                sum += numbers[i];
            }
            Console.WriteLine("Sum of the Array=" + sum);
        }
    }
}
