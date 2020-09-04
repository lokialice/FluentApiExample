using System;
using System.Collections.Generic;
using System.Text;

namespace FluentApiExample.Models
{
    public class StudentModel
    {
        public string Name { get; set; }
        public CourseModel Courses { get; set; }
    }
}
