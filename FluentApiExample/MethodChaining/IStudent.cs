using FluentApiExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentApiExample.MethodChaining
{
    public interface IStudent
    {
        ICourses Courses { get; }
        List<StudentModel> Fetch { get; }
    }
}
