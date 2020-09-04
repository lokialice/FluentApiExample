using FluentApiExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentApiExample.Conjuctions
{
    public interface IStudent
    {
        ICourses Courses { get; }
        ICourses And { get; }
        List<StudentModel> Fetch { get; }
    }
}
