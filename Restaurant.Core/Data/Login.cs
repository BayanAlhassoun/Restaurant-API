using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class Login
{
    public decimal Loginid { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public decimal Userid { get; set; }

    public virtual User? User { get; set; }
}
