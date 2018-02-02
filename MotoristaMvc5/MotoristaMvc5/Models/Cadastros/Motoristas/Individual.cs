namespace MotoristaMvc5.Models.Cadastros.Motoristas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOT_INDIVIDUAL
    {
        [Key]
        public int MOT_INDI_ID { get; set; }

        [Required]
        [Display(Name = "Brasileiro")]
        [StringLength(1)]
        public string MOT_INDI_NACIONALIDADE { get; set; }

        [Display(Name = "Nome")]
        [StringLength(50)]
        public string MOT_INDI_NOME { get; set; }

        [Display(Name = "Sexo")]
        [StringLength(1)]
        public string MOT_INDI_SEXO { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime MOT_INDI_DATA_NASCIMENTO { get; set; }

        [Display(Name = "CPF")]
        public int MOT_INDI_CPF { get; set; }

        [Display(Name = "RG/RGE")]
        public int MOT_INDI_RG_RGE { get; set; }

        [Display(Name = "Org�o emissor")]
        [MaxLength(5)]
        public byte[] MOT_INDI_RG_ORG_EMISSAO { get; set; }

        [Display(Name = "Data da emiss�o")]
        [Column(TypeName = "date")]
        public DateTime? MOT_INDI_RG_DATA_EMISSAO { get; set; }

        [Required]
        [Display(Name = "N� CNH")]
        [StringLength(20)]
        public string MOT_INDI_CNH { get; set; }

        [Required]
        [Display(Name = "UF CNH")]
        [StringLength(1)]
        public string MOT_INDI_CNH_UF { get; set; }

        [Display(Name = "1� CNH")]
        [StringLength(20)]
        public string MOT_INDI_P_CNH { get; set; }

        [Display(Name = "Validade")]
        [Column(TypeName = "date")]
        public DateTime MOT_INDI_CNH_VALIDADE { get; set; }

        [Display(Name = "CNH seguran�a")]
        [StringLength(20)]
        public string MOT_INDI_CNH_SEGURANCA { get; set; }

        [Display(Name = "Categoria")]
        public int? MOT_INDI_CNH_CAT_ID { get; set; }

        [Display(Name = "Telefone")]
        [StringLength(20)]
        public string MOT_INDI_TELEFONE { get; set; }

        [Display(Name = "Celular I")]
        [StringLength(20)]
        public string MOT_INDI_CELULAR_I { get; set; }

        [Display(Name = "Celular II")]
        [StringLength(20)]
        public string MOT_INDI_CELULAR_II { get; set; }

        [Display(Name = "E-mail")]
        [StringLength(50)]
        public string MOT_INDI_EMAIL { get; set; }

        [Display(Name = "Documento extrangeiro")]
        [StringLength(30)]
        public string MOT_INDI_EX_DOCUMENTO { get; set; }

        [Display(Name = "Validade do documento")]
        [Column(TypeName = "date")]
        public DateTime? MOT_INDI_EX_DOC_VALIDADE { get; set; }

        [Required]
        [Display(Name = "CNH")]
        [StringLength(20)]
        public string MOT_INDI_EX_CNH { get; set; }

        [Display(Name = "Validade")]
        [Column(TypeName = "date")]
        public DateTime MOT_INDI_EX_CNH_VALIDADE { get; set; }

        [Display(Name = "Pais origem")]
        [StringLength(30)]
        public string MOT_INDI_EX_PAIS_ORG { get; set; }

        [Display(Name = "Cidade origem")]
        [StringLength(30)]
        public string MOT_INDI_EX_CIDADE { get; set; }
    }
}
