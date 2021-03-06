namespace WS20
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Biomaterial")]
    public partial class Biomaterial
    {
        [Key]
        public int IdBiomaterial { get; set; }

        public double CodeBiomaterial { get; set; }

        [Required]
        [StringLength(255)]
        public string NameBiomaterial { get; set; }

        [Column("Biomaterial")]
        [Required]
        [StringLength(255)]
        public string Biomaterial1 { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public int IdSetService { get; set; }
    }
}
