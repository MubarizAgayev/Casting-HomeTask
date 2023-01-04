using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class CalculateService:ICalculateService
    {
        public double Calculate(int n, int m, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = n + m;
                    return result;
                case "-":
                    result = n - m;
                    return result;
                case "/":
                    result = n / m;
                    return result;
                case "*":
                    result = n * m;
                    return result;
                default:
                    Console.WriteLine("Please add correct operation");
                    return 0;
            }
        }
    }
}
