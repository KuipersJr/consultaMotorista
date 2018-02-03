namespace MotoristaMvc5.Models.Cadastros.Empresa
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Empresa : DbContext
    {
        public Empresa()
            : base("name=Motorisadb")
        {
        }

        public virtual DbSet<MOT_EMPRESA> MOT_EMPRESA { get; set; }
        public virtual DbSet<MOTORISTA_EMPRESA> MOTORISTA_EMPRESA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MOT_EMPRESA>()
                .Property(e => e.EMP_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_EMPRESA>()
                .Property(e => e.EMP_IE)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_EMPRESA>()
                .Property(e => e.EMP_NOME_RAZAO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_EMPRESA>()
                .Property(e => e.EMP_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_EMPRESA>()
                .Property(e => e.EMP_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_EMPRESA>()
                .Property(e => e.EMP_COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_EMPRESA>()
                .Property(e => e.EMP_CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_EMPRESA>()
                .Property(e => e.EMP_BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_EMPRESA>()
                .Property(e => e.EMP_UF)
                .IsUnicode(false);
        }
    }
}
