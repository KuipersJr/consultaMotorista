namespace MotoristaMvc5.Models.Cadastros.Empresa
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Empresadb : DbContext
    {
        public Empresadb()
            : base("name=Motorisadb")
        {
        }

        public virtual DbSet<Empresa> Empresa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>()
                .Property(e => e.EMP_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.EMP_IE)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.EMP_NOME_RAZAO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.EMP_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.EMP_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.EMP_COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.EMP_CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.EMP_BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.EMP_UF)
                .IsUnicode(false);
        }
    }
}
