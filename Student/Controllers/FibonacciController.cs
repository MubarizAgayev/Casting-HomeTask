using ServiceLayer.Interfaces;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Controllers
{
    internal class FibonacciController
    {
        public void GetFibonacciNumbers()
        {
            IFibonacciServis numbers = new FibonacciServis();
            Console.WriteLine("Ededi daxil edin :");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci numbers :");
            var result = numbers.GetFibonacciNumbers(number);
            foreach (var item in result)
            {
                if (item>0 && item <number)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
