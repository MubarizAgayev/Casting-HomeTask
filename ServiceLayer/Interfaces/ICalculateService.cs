using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface ICalculateService
    {
        double Calculate(int n, int m, string operation);
    }
}
