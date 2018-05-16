namespace Homework002.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PerformanceTable")]
    public partial class PerformanceTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Salesman { get; set; }

        [Required]
        [StringLength(50)]
        public string Productitem { get; set; }

        public int Quantity { get; set; }
    }
}
