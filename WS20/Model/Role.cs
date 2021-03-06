namespace WS20
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Role")]
    public partial class Role
    {
        public int RoleId { get; set; }

        [Required]
        [StringLength(255)]
        public string RoleName { get; set; }
    }
}
