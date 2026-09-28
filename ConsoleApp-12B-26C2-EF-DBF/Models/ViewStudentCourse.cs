using System;
using System.Collections.Generic;

namespace ConsoleApp_12B_26C2_EF_DBF.Models;

public partial class ViewStudentCourse
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public int CourseId { get; set; }

    public string? CourseName { get; set; }
}
