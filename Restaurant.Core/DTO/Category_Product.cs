using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.DTO
{
    public class Category_Product
    {
        public decimal Category_Id { get; set; }

        public string Category_Name { get; set; } = null!;
        public decimal Item_Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public decimal Price { get; set; }


        public decimal? Status_Id { get; set; }

        public DateTime? Date_Added { get; set; }

        public DateTime? Date_Removed { get; set; }
    }
}
