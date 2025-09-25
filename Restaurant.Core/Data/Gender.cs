using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Gender
{
    public decimal GenderId { get; set; }

    public string GenderName { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
