using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping
{
    [Table("Transaction")]
    internal class Transaction_DA
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Date { get; set; }
        public int? AL_id { get; set; }
    }
}
