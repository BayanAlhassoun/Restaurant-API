using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Status
{
    public decimal StatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
}
