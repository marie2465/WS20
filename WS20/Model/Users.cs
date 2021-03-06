namespace WS20
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        public string Login { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [StringLength(255)]
        public string IP { get; set; }

        public DateTime Lastenter { get; set; }

        public int IdService { get; set; }

        [StringLength(255)]
        public string Type { get; set; }

        public int RoleID { get; set; }

        [Required]
        [StringLength(255)]
        public string Photo { get; set; }

        [Required]
        [StringLength(255)]
        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
