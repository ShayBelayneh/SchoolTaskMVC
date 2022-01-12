using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Student
    {
        public Student(int id, string firstName, string lastName, int grade, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
            Age = age;
        }

        public int Id { get; set; }
        public string FirstName { get ; set ; }
        public string LastName { get; set ; }
        public int Grade { get; set ; }
        public int Age { get ; set ; }
    }
}