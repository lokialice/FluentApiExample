using FluentApiExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentApiExample.Conjuctions
{
    public interface ICourses
    {
        IStudent WithCourse(string courseName);
        IStudent Include(string studentName);
        IStudent Exclude(string studentName);
    }
}
