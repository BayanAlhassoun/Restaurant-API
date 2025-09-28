using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class MenuItem
{
    public decimal Item_Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public decimal? Category_Id { get; set; }

    public decimal? Status_Id { get; set; }

    public DateTime? Date_Added { get; set; }

    public DateTime? Date_Removed { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Status? Status { get; set; }
}
