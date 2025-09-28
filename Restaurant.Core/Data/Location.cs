using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Location
{
    public decimal Location_Id { get; set; }

    public string City { get; set; } = null!;

    public string? Street { get; set; }

    public string? Building_No { get; set; }

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();
}
