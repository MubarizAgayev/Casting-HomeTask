using ServiceLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Controllers
{
    internal class StudentController
    {
        public void GetCountStudents()
        {
            IStudentService student=new StudentService();
            var result = student.GetCountStudent();
            Console.WriteLine(result);
        }
        public void GetAvarageOfStudents()
        {
            IStudentService student=new StudentService();
            var result=student.GetAvarageOfStudents();
            Console.WriteLine(result);
        }
        public void GetEmailStartsWith()
        {
            IStudentService student = new StudentService();
            Console.WriteLine("Add the letter :");
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine("List :");
            var result=student.GetEmailStartsWith(c);
            foreach(var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id}{item.Name}{item.Surname}{item.Email}{item.Age}{item.Education}{item.Address}");
                }
            }
        }
        public void GetAddressIsAhmedli()
        {
            IStudentService student=new StudentService();
            Console.WriteLine("Add the address");
            string address=Console.ReadLine();
            Console.WriteLine("The students in this address");
            var result= student.GetAddressIsAhmedli(address);
            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id}{item.Name}{item.Surname}{item.Email}{item.Age}{item.Education}{item.Address}");
                }
            }
        } 
        
        public void Search()
        {
            string name = "Mubariz";
            string surname = "Agayev";
            IStudentService student = new StudentService();
            var result=student.Search(name,surname);
                       
            foreach (var item in result)
            {
                if(item != null)
                {
                    Console.WriteLine($"{item.Id}{item.Name}{item.Surname}{item.Email}{item.Age}{item.Education}{item.Address}");
                }
            }
        }

        public void GetStudentsWithSimilarName()
        {
            IStudentService student = new StudentService();
            var result=student.GetStudentsWithSimilarName();
            Console.WriteLine(result);
        }
    }
}
