
using FluentApiExample.MethodChaining;
using FluentApiExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentApiExample
{
    public class StudentDetailsUsingMethodChaining
    {
        public static FluentApiExample.MethodChaining.ICourses Select()
        {
            return new FluentApiExample.MethodChaining.Student().Courses;
        }
    }

    public class StudentDetailsUsingConjuction
    {
        public static FluentApiExample.Conjuctions.ICourses Select()
        {
            return new FluentApiExample.Conjuctions.Student().Courses;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========Method Chaining Output==============");
            //Method Chaining
            var students = StudentDetailsUsingMethodChaining
                                .Select()
                                .WithCourse("Course 1")
                                .Fetch;
            foreach (var student in students)
            {
                Console.WriteLine($@"Students of Course 1 : {student.Name}");
            }

            //Conjunctions
            var conjectionStudents = StudentDetailsUsingConjuction
                .Select()
                .WithCourse("Course 1")
                .And
                .Exclude("student 1")
                .Fetch;

            Console.WriteLine("=========Conjunctions Output==============");

            foreach (var student in conjectionStudents)
            {
                Console.WriteLine($@"Students of Course 1 : {student.Name}");
            }
            Console.ReadLine();
        }
    }
}
