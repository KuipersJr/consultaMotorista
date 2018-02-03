namespace MotoristaMvc5.Models.Cadastros.Veiculo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Veiculos : DbContext
    {
        public Veiculos()
            : base("name=Motorisadb")
        {
        }

        public virtual DbSet<MOT_VEICULO> MOT_VEICULO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MOT_VEICULO>()
                .Property(e => e.VEI_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_VEICULO>()
                .Property(e => e.VEI_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_VEICULO>()
                .Property(e => e.VEI_RENAVAM)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_VEICULO>()
                .Property(e => e.VEI_RENA_UF)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_VEICULO>()
                .Property(e => e.VEI_PROP_CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_VEICULO>()
                .Property(e => e.VEI_PROP_NOME_RAZAO_SOCIAL)
                .IsUnicode(false);
        }
    }
}
