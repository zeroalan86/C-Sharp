namespace Hackathon007.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReadtestTable")]
    public partial class ReadtestTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TickNumber { get; set; }

        [Column("Flying Day")]
        public DateTime Flying_Day { get; set; }

        public DateTime Birthday { get; set; }
    }
}
