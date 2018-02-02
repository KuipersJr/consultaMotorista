namespace MotoristaMvc5.Models.Cadastros.Motoristas
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Contato : DbContext
    {
        public Contato()
            : base("name=Motorisadb")
        {
        }

        public virtual DbSet<CONTATO_MOTORISTA> CONTATO_MOTORISTA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CONTATO_MOTORISTA>()
                .Property(e => e.CONT_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CONTATO_MOTORISTA>()
                .Property(e => e.CONT_TELEFONE)
                .IsUnicode(false);
        }
    }
}
