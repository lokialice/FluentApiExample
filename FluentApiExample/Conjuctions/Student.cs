using FluentApiExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentApiExample.Conjuctions
{
    public class Student : IStudent
    {
        public Student()
        {
        }

        private IEnumerable<StudentModel> vals;
        public Student(IEnumerable<StudentModel> values)
        {
            vals = values;
        }

        public List<StudentModel> Fetch => vals.ToList();
        public ICourses Courses =>  new Courses();

        public ICourses And => new Courses(vals);
        
    }
}
