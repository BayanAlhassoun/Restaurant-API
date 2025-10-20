using System;
using System.Collections.Generic;

namespace Restaurant.Core.Data;

public partial class User
{
    public decimal Userid { get; set; }

    public string Fullname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;
    public string ImageName { get; set; }

    public DateTime? Createdat { get; set; }

    public decimal? Genderid { get; set; }

    public decimal? Positionid { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual ICollection<Login> Logins { get; set; } = new List<Login>();

    public virtual Position? Position { get; set; }
}
