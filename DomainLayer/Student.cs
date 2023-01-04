using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Education { get; set; }
        public string Address { get; set; }


        public Student(int id, string name, string surname, string email, int age, string education, string address)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Age = age;
            Education = education;
            Address = address;
        }
    }
}
