namespace MotoristaMvc5.Models.IBGE
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Estados : DbContext
    {
        public Estados()
            : base("name=Motoristadb")
        {
        }

        public virtual DbSet<IBGE_UF> IBGE_UF { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IBGE_UF>()
                .Property(e => e.EST_SIGLA)
                .IsUnicode(false);

            modelBuilder.Entity<IBGE_UF>()
                .Property(e => e.EST_ESTADO)
                .IsUnicode(false);
        }
    }
}
