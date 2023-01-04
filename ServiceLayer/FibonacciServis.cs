using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class FibonacciServis : IFibonacciServis
    {
        public int[] GetFibonacciNumbers(long number)
        {
            int a = 0;
            int b = 1;
            int result = 0;
            int count = 0;
            int[]fibnumbers= new int[number];
            for(int i=0;i<fibnumbers.Length;i++)
            {
                fibnumbers[i] = a;
                result = a + b;
                a= b;
                b= result;
                count++;
            }
            return fibnumbers;
        }
    }
}
