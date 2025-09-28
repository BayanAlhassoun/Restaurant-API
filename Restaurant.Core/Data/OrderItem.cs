using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class OrderItem
{
    public decimal Order_Item_Id { get; set; }

    public decimal Order_Id { get; set; }

    public decimal Item_Id { get; set; }

    public decimal Quantity { get; set; }

    public decimal? Subtotal { get; set; }

    public virtual MenuItem Item { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
