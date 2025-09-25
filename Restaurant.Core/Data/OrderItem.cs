using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class OrderItem
{
    public decimal OrderItemId { get; set; }

    public decimal OrderId { get; set; }

    public decimal ItemId { get; set; }

    public decimal Quantity { get; set; }

    public decimal? Subtotal { get; set; }

    public virtual MenuItem Item { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
