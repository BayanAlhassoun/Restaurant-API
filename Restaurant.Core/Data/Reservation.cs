using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Reservation
{
    public decimal Reservation_Id { get; set; }

    public DateTime Reservation_Date { get; set; }

    public string Reservation_Time { get; set; } = null!;

    public decimal Guests { get; set; }

    public decimal? Customer_Id { get; set; }

    public decimal? Branch_Id { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Customer? Customer { get; set; }
}
