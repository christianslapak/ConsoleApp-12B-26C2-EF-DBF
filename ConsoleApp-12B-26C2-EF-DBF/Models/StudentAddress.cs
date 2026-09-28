using System;
using System.Collections.Generic;

namespace ConsoleApp_12B_26C2_EF_DBF.Models;

public partial class StudentAddress
{
    public int StudentId { get; set; }

    public string Address1 { get; set; } = null!;

    public string? Address2 { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
