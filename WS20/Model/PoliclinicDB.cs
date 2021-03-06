namespace WS20
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PoliclinicDB : DbContext
    {
        public PoliclinicDB()
            : base("name=PoliclinicDB")
        {
        }

        public virtual DbSet<Biomaterial> Biomaterial { get; set; }
        public virtual DbSet<InsureCompany> InsureCompany { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Pacients> Pacients { get; set; }
        public virtual DbSet<Rendering> Rendering { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<SetService> SetService { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
