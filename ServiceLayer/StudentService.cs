using DomainLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class StudentService : IStudentService
    {
        
        public int GetCountStudent()
        {
            var result = GetStudents();
            int count = 0;  
            for (int i = 0; i < result.Length; i++)
            {
                count++;
            }
            return count;
        }
        public int GetAvarageOfStudents()
        {
            var result=GetStudents();
            int sum = 0;
            for (int i = 0; i < result.Length; i++)
            {
                sum += result[i].Age;
            }
            return sum/result.Length;
        }

        public Student[] GetEmailStartsWith(char c)
        {
            var result = GetStudents();
            Student[] students= new Student[result.Length];
            int count = 0;
            for(int i=0;i<students.Length;i++)
            {
                if (result[i].Email.StartsWith(c))
                {
                    students[count]= result[i];
                    count++;
                }
            }

            return students;
        } 

        public Student[] GetAddressIsAhmedli(string address)
        {
            var result=GetStudents();
            Student[]students= new Student[result.Length];
            int count = 0;
            for(int i = 0; i < students.Length; i++)
            {
                if (result[i].Address == address)
                {
                    students[count]= result[i];
                    count++;
                }
            }
            return students;
        }

        public Student[] Search(string name,string surname)
        {
            var result = GetStudents();
            Student[]students= new Student[result.Length];
            int count = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (result[i].Name == name && result[i].Surname == surname)
                {
                    students[count] = result[i];
                    count++;
                }
            }
            return students;
        }

        public int GetStudentsWithSimilarName()
        {
            var result=GetStudents();
            int count = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for(int j = i; j < result.Length-1; j++)
                {
                    if (result[i].Name == result[j+1].Name)
                    {
                        count++;
                    }
             
                }
            }
            return count;
        }
        private Student[] GetStudents()
        {
            Student student1 = new Student(1, "Mubariz", "Agayev", "mubarizra@code.edu.az", 18, "Code Academy", "Nesimi");
            Student student2 = new Student(2, "Roya", "Meherremova", "royaam@code.edu.az", 26, "Code Academy", "Sumqayit");
            Student student3 = new Student(3, "Shaiq", "Kazimov", "shaigak@code.edu.az", 25, "Code Academy", "Ehmedli");
            Student student4 = new Student(4, "Konul", "Ibrahimova", "konulsi", 26, "Code Academy", "Neftciler");
            Student student5 = new Student(5, "Aksin", "Hummetov", "aksin@code.edu.az", 27, "Code Academy", "Sumqayit");
            Student student6 = new Student(6, "Cavid", "Ismayilzade", "cavidis@code.edu.az", 24, "Code Academy", "28may");
            Student student7 = new Student(7, "Aksin", "Babayev", "aksinds@gmail.com", 25, "University", "Genclik");
            Student[] students = { student1, student2, student3, student4, student5,student6,student7};
            return students;
        }
    }
}
