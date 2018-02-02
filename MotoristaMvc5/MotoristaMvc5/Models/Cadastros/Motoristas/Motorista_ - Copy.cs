namespace MotoristaMvc5.Models.Cadastros.Motoristas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MOTORISTA")]
    public partial class Motorista_
    {
        [Key]
        public int MOT_ID { get; set; }

        [Required]
        [StringLength(1)]
        public string MOT_NACIONALIDADE { get; set; }

        [StringLength(50)]
        public string MOT_NOME { get; set; }

        [StringLength(1)]
        public string MOT_SEXO { get; set; }

        public DateTime MOT_DATA_NASCIMENTO { get; set; }

        public int MOT_CPF { get; set; }

        public int MOT_RG_RGE { get; set; }

        [MaxLength(5)]
        public byte[] MOT_RG_ORG_EMISSAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MOT_RG_DATA_EMISSAO { get; set; }

        [Required]
        [StringLength(20)]
        public string MOT_CNH { get; set; }

        [Required]
        [StringLength(1)]
        public string MOT_CNH_UF { get; set; }

        [StringLength(20)]
        public string MOT_P_CNH { get; set; }

        [Column(TypeName = "date")]
        public DateTime MOT_CNH_VALIDADE { get; set; }

        [StringLength(20)]
        public string MOT_CNH_SEGURANCA { get; set; }

        public int? MOT_CNH_CAT_ID { get; set; }

        [StringLength(20)]
        public string MOT_TELEFONE { get; set; }

        [StringLength(20)]
        public string MOT_CELULAR_I { get; set; }

        [StringLength(20)]
        public string MOT_CELULAR_II { get; set; }

        [StringLength(50)]
        public string MOT_EMAIL { get; set; }

        [StringLength(1)]
        public string MOT_FLG_SERASA { get; set; }

        [StringLength(1)]
        public string MOT_FLG_CRIMINAL { get; set; }
    }
}
