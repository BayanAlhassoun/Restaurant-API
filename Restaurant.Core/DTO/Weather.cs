using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.DTO
{
    public class Weather
    {
        public string Name { get; set; }
        public int TimeZone { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public SYS SYS { get; set; }
        public Coord coord { get; set; }
    }

    public class Main
    {
        public string temp { get; set; }
        public string pressure { get; set; }
        public string humidity { get; set; }
    }

    public class Wind
    {
        public string speed { get; set; }
    }

    public class SYS
    {
        public string Country { get; set; }
    }

    public class Coord
    {
        public string lon { get; set; }
        public string lat { get; set; }
    }
}
