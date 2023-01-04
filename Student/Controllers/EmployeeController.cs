using ServiceLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Controllers
{
    internal class EmployeeController
    {
       public void GetFilteredEmployees()
        {
            IEmployeeService employee =new EmployeeService();
            Console.WriteLine("Add start date :");
            DateTime startDate=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Add end date :");
            DateTime endDate=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Add start salary");
            long startSalary=long.Parse(Console.ReadLine());
            Console.WriteLine("Filtered Employees list :");
            var result = employee.GetFilteredEmployees(startDate,endDate,startSalary);
            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Name}{item.Surname}{item.Birthday}{item.Salary}");
                }
            }
            
            

        }

        
    }
}
