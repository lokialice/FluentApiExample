using FluentApiExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentApiExample.MethodChaining
{
    public interface ICourses
    {
        IStudent WithCourse(string courseName);
    }
}
