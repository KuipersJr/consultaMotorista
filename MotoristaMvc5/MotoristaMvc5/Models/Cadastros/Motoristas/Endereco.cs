namespace MotoristaMvc5.Models.Cadastros.Motoristas
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Endereco : DbContext
    {
        public Endereco()
            : base("name=Motorisadb")
        {
        }

        public virtual DbSet<ENDERECO_MOTORISTA> ENDERECO_MOTORISTA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ENDERECO_MOTORISTA>()
                .Property(e => e.END_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_MOTORISTA>()
                .Property(e => e.END_NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_MOTORISTA>()
                .Property(e => e.END_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_MOTORISTA>()
                .Property(e => e.END_COMPLEMENTO)
                .IsUnicode(false);
        }
    }
}
