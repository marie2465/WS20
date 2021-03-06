namespace WS20
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pacients
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Login { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [Required]
        [StringLength(255)]
        public string FIO { get; set; }

        [Column("Date of birth")]
        public DateTime Date_of_birth { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Column("Passport data")]
        [Required]
        [StringLength(255)]
        public string Passport_data { get; set; }

        public double Phone { get; set; }

        [Column("Insurance policy")]
        public int Insurance_policy { get; set; }

        [Column("Type of policy")]
        [Required]
        [StringLength(255)]
        public string Type_of_policy { get; set; }

        public int IdCompany { get; set; }
    }
}
