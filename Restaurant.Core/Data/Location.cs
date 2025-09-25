using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Location
{
    public decimal LocationId { get; set; }

    public string City { get; set; } = null!;

    public string? Street { get; set; }

    public string? BuildingNo { get; set; }

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();
}
