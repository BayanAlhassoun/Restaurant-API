using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Employee
{
    public decimal Employee_Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Phone { get; set; }

    public DateTime? Hire_Date { get; set; }

    public decimal? Salary { get; set; }

    public decimal? Branch_Id { get; set; }

    public decimal? Position_Id { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Position? Position { get; set; }
}
