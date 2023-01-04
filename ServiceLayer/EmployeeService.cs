using DomainLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class EmployeeService : IEmployeeService
    {
        public Employee[] GetFilteredEmployees(DateTime startDate,DateTime endDate,long startSalary)
        {
            var result = GetEmployee();
            Employee[] employees = new Employee[result.Length];
            int count = 0;
            for(int i=0;i<employees.Length;i++)
            {
                if (result[i].Birthday > startDate && result[i].Birthday < endDate)
                {
                    if (result[i].Salary> startSalary)
                    {
                        employees[count] = result[i];
                        count++;
                    }
                }
            }
            return employees;
        }

        public Employee[] GetEmployee()
        {
            Employee employee1 = new Employee("Mubariz", "Agayev",new DateTime(2004,12,02), 7000);
            Employee employee2 = new Employee("Konul", "Ibrahimova", new DateTime(1996,05, 20), 4500);
            Employee employee3 = new Employee("Roya", "Meherremova", new DateTime(1996, 04, 15), 5000);
            Employee employee4 = new Employee("Shaiq", "Kazimov", new DateTime(1997, 11, 25), 5500);
            Employee employee5 = new Employee("Ismauil", "Esedov", new DateTime(2004, 05, 20), 5100);
            Employee[] employees = {employee1, employee2, employee3,employee4,employee5};
            return employees;
        }
    }
}
