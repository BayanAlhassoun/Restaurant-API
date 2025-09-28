using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Order
{
    public decimal Order_Id { get; set; }

    public DateTime? Order_Date { get; set; }

    public decimal? Total_Amount { get; set; }

    public decimal? Branch_Id { get; set; }

    public decimal? Customer_Id { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
