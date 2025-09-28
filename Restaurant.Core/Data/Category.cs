using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Category
{
    public decimal Category_Id { get; set; }

    public string Category_Name { get; set; } = null!;

    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
}
