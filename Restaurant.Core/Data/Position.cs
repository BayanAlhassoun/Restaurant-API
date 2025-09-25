using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Position
{
    public decimal PositionId { get; set; }

    public string PositionName { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
