using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping
{
    internal class Route
    {
        public int Id { get; set; }
        public decimal? Distance { get; set; }
        public string? Destination { get; set; }
        public string? Origin { get; set; }
        public string? Classification { get; set; }
    }
}
