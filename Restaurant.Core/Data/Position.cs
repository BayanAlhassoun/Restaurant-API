using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Position
{
    public decimal Position_Id { get; set; }

    public string Position_Name { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
