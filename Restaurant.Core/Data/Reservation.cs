using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Reservation
{
    public decimal ReservationId { get; set; }

    public DateTime ReservationDate { get; set; }

    public string ReservationTime { get; set; } = null!;

    public decimal Guests { get; set; }

    public decimal? CustomerId { get; set; }

    public decimal? BranchId { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Customer? Customer { get; set; }
}
