using FluentApiExample.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FluentApiExample.Conjuctions
{
    public class Courses : ICourses
    {
        private List<CourseModel> courses = new List<CourseModel>();
        private List<StudentModel> students = new List<StudentModel>();

        public Courses() {
            PrepareData();
        }

        public Courses(IEnumerable<StudentModel> students)
        {
            this.students = students.ToList();
        }

        public IStudent Include(string studentName)
        {
            return new Student(students.Where(x => x.Name.Equals(studentName)).ToList());
        }

        public IStudent Exclude(string studentName)
        {
            return new Student(students.Where(x => !x.Name.Equals(studentName)).ToList());
        }

        public void PrepareData()
        {
            var course1 = new CourseModel()
            {
                CourseName = "Course 1",
                Weightage = "5"
            };

            var course2 = new CourseModel()
            {
                CourseName = "Course 2",
                Weightage = "4"
            };

            var course3 = new CourseModel()
            {
                CourseName = "Course 3",
                Weightage = "3"
            };
            courses.Add(course1);
            courses.Add(course2);
            courses.Add(course3);


            students.Add(new StudentModel() { Name = "student 1", Courses = course1 });
            students.Add(new StudentModel() { Name = "student 2", Courses = course1 });
            students.Add(new StudentModel() { Name = "student 3", Courses = course1 });
            students.Add(new StudentModel() { Name = "student 4", Courses = course2 });
            students.Add(new StudentModel() { Name = "student 5", Courses = course1 });
            students.Add(new StudentModel() { Name = "student 6", Courses = course3 });
        }
      
        public IStudent WithCourse(string courseName)
        {
            return new Student( students.Where(x => x.Courses.CourseName.Equals(courseName)) );
        }
    }
}
