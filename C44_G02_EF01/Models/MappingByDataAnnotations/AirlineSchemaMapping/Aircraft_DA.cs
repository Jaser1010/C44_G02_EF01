using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping
{
    [Table("Aircraft")]
    internal class Aircraft_DA
    {
        [Key]
        public int Id { get; set; }
        public int? capacity { get; set; }
        public string? Model { get; set; }
        public string? Maj_pilot { get; set; }
        public string? Assistant { get; set; }
        public string? Host1 { get; set; }
        public string? Host2 { get; set; }
        public int? AL_id { get; set; }
    }
}
