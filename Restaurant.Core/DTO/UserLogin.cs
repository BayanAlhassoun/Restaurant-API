using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.DTO
{
    public class UserLogin
    {
        public decimal Userid { get; set; }

        public string Fullname { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string ImageName { get; set; }

        public DateTime? Createdat { get; set; }

        public decimal? Genderid { get; set; }

        public decimal? Positionid { get; set; }

        public decimal Loginid { get; set; }

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

    }
}
