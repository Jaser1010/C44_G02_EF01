using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping
{
    [Table("Route")]
    internal class Route_DA
    {
        [Key]
        public int Id { get; set; }
        public decimal? Distance { get; set; }
        public string? Destination { get; set; }
        public string? Origin { get; set; }
        public string? Classification { get; set; }
    }
}
