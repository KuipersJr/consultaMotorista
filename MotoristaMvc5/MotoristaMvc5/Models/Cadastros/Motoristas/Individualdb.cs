namespace MotoristaMvc5.Models.Cadastros.Motoristas
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Individualdb : DbContext
    {
        public Individualdb()
            : base("name=Motorisadb")
        {
        }

        public virtual DbSet<MOT_INDIVIDUAL> Individual { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_NACIONALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_SEXO)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_CNH)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_CNH_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_P_CNH)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_CNH_SEGURANCA)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_CELULAR_I)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_CELULAR_II)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_EX_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_EX_CNH)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_EX_PAIS_ORG)
                .IsUnicode(false);

            modelBuilder.Entity<MOT_INDIVIDUAL>()
                .Property(e => e.MOT_INDI_EX_CIDADE)
                .IsUnicode(false);
        }
    }
}
