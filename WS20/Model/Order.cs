namespace WS20
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int ID { get; set; }

        public int IdPacient { get; set; }

        public int IdSetService { get; set; }

        [Required]
        [StringLength(255)]
        public string Status { get; set; }

        public double Bacode { get; set; }

        public int? IdService { get; set; }

        public int? BiomaterialId { get; set; }

        public DateTime? DataOrder { get; set; }
    }
}
