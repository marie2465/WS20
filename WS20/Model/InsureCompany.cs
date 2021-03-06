namespace WS20
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InsureCompany")]
    public partial class InsureCompany
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        public double INN { get; set; }

        [Column("r/s")]
        public double r_s { get; set; }

        public double BIK { get; set; }
    }
}
