using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Customer
{
    public decimal CustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public decimal? GenderId { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
