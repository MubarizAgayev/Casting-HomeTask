using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface IStudentService
    {
        int GetCountStudent();
        int GetAvarageOfStudents();
        Student[] GetEmailStartsWith(char c);
        Student[] GetAddressIsAhmedli(string address);
        Student[] Search(string name,string surname);
        int GetStudentsWithSimilarName();
    }
}
