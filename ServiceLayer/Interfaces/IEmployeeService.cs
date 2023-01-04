using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetFilteredEmployees(DateTime startDate,DateTime endDate,long startSalary);
    }
}
