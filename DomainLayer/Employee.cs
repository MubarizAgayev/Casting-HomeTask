using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string surname, DateTime birthday, int salary)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Salary = salary;
        }
    }
}
