using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Order
{
    public decimal OrderId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? BranchId { get; set; }

    public decimal? CustomerId { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
