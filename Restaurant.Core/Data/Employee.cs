using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Employee
{
    public decimal EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Phone { get; set; }

    public DateTime? HireDate { get; set; }

    public decimal? Salary { get; set; }

    public decimal? BranchId { get; set; }

    public decimal? PositionId { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Position? Position { get; set; }
}
