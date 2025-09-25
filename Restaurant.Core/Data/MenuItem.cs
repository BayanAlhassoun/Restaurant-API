using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class MenuItem
{
    public decimal ItemId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public decimal? CategoryId { get; set; }

    public decimal? StatusId { get; set; }

    public DateTime? DateAdded { get; set; }

    public DateTime? DateRemoved { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Status? Status { get; set; }
}
