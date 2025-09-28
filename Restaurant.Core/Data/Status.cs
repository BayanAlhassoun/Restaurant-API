using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Status
{
    public decimal Status_Id { get; set; }

    public string Status_Name { get; set; } = null!;

    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
}
