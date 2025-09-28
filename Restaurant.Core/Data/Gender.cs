using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Gender
{
    public decimal Gender_Id { get; set; }

    public string Gender_Name { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
