namespace WS20
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public double Cost { get; set; }

        public double ServiceCode { get; set; }

        public DateTime Period { get; set; }

        [Column("Mean deviation")]
        [Required]
        [StringLength(255)]
        public string Mean_deviation { get; set; }

        public int SetServiceId { get; set; }
    }
}
