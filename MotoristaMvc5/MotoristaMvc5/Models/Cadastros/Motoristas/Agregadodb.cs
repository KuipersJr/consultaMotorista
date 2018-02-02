namespace MotoristaMvc5.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Agregadodb : DbContext
    {
        public Agregadodb()
            : base("name=Motorisadb")
        {
        }

        public virtual DbSet<Agregado> Agregado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agregado>()
                .Property(e => e.MAV_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<Agregado>()
                .Property(e => e.MAV_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<Agregado>()
                .Property(e => e.MAV_RENAVAM)
                .IsUnicode(false);

            modelBuilder.Entity<Agregado>()
                .Property(e => e.MAV_RENA_UF)
                .IsUnicode(false);

            modelBuilder.Entity<Agregado>()
                .Property(e => e.MAV_PROP_CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Agregado>()
                .Property(e => e.MAV_PROP_NOME_RAZAO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<Agregado>()
                .Property(e => e.MAV_PROP_NOME_MAE)
                .IsUnicode(false);

            modelBuilder.Entity<Agregado>()
                .Property(e => e.MAV_PROP_NOME_PAI)
                .IsUnicode(false);

            modelBuilder.Entity<Agregado>()
                .Property(e => e.MAV_PROP_SEXO)
                .IsUnicode(false);

            modelBuilder.Entity<Agregado>()
                .Property(e => e.MAV_PROP_RG)
                .IsUnicode(false);

            modelBuilder.Entity<Agregado>()
                .Property(e => e.MAV_PROP_UF)
                .IsUnicode(false);
        }
    }
}
