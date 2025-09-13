using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping
{
    internal class Airline_Phone
    {
        // Convention cannot determine a key here without Fluent API.
        public int AL_Id { get; set; }
        public string? Phones { get; set; }
    }
}
