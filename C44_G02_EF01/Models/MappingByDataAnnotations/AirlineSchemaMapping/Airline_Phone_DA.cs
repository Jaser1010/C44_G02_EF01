using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping
{
    [Table("Airline_Phones")]
    internal class Airline_Phone_DA
    {
        [Key]
        public int AL_Id { get; set; }
        public string? Phones { get; set; }
    }
}
