using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Category
{
    public decimal CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
}
