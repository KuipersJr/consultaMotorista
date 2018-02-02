namespace MotoristaMvc5.Models.Cadastros.Motoristas
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Autonomodb : DbContext
    {
        public Autonomodb()
            : base("name=Motorisadb")
        {
        }

        public virtual DbSet<Autonomo> Autonomo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_NACIONALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_SEXO)
                .IsUnicode(false);

            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_CNH)
                .IsUnicode(false);

            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_CNH_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_P_CNH)
                .IsUnicode(false);

            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_CNH_SEGURANCA)
                .IsUnicode(false);

            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_CELULAR_I)
                .IsUnicode(false);

            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_CELULAR_II)
                .IsUnicode(false);

            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_FLG_SERASA)
                .IsUnicode(false);

            modelBuilder.Entity<Autonomo>()
                .Property(e => e.MOT_AUT_FLG_CRIMINAL)
                .IsUnicode(false);
        }
    }
}
