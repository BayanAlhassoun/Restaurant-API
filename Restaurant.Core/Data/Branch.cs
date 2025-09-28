using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Branch
{
    public decimal Branch_Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Phone { get; set; }

    public decimal? Location_Id { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Location? Location { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
