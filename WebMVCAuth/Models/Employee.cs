using System;
using System.Collections.Generic;

namespace WebMVCAuth.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? HireDate { get; set; }

    public double? Salary { get; set; }
}
