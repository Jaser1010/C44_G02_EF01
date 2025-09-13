using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping
{
    [Table("Aircraft_Routes")]
    [PrimaryKey("AC_Id", "Route_Id")]

    internal class Aircraft_Route_DA
    {
        public int AC_Id { get; set; }
        public int Route_Id { get; set; }
        public DateTime? Departure { get; set; }
        public int? Num_Of_Pass { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Arrival { get; set; }
    }
}
