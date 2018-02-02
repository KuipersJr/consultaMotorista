namespace MotoristaMvc5.Models.Cadastros.Motoristas
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Motoristadb : DbContext
    {
        public Motoristadb()
            : base("name=Motoristadb")
        {
        }

        public virtual DbSet<MOTORISTA> MOTORISTAs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_NACIONALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_SEXO)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_CNH)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_CNH_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_P_CNH)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_CNH_SEGURANCA)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_CNH_CAT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_CELULAR_I)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_CELULAR_II)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_FLG_SERASA)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_FLG_CRIMINAL)
                .IsUnicode(false);

            modelBuilder.Entity<MOTORISTA>()
                .Property(e => e.MOT_COD_INT)
                .IsUnicode(false);
        }
    }
}
