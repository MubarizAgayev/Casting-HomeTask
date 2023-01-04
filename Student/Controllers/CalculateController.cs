using ServiceLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Controllers
{
    internal class CalculateController
    {
        public void Calculate()
        {
            ICalculateService calculater = new CalculateService();
            Console.WriteLine("Add first number :");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Add operation :");
            string operation=Console.ReadLine();
            Console.WriteLine("Add second number :");
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine("Result :");
            var result = calculater.Calculate(n,m,operation);
            Console.WriteLine(result);

            
        }
    }
}
