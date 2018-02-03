namespace MotoristaMvc5.Models.Cadastros.Motoristas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOT_AUTONOMO
    {
        [Key]
        public int MOT_AUT_ID { get; set; }

        [Required]
        [Display(Name = "Brasileiro")]
        [StringLength(1)]
        public string MOT_AUT_NACIONALIDADE { get; set; }

        [Display(Name = "Nome")]
        [StringLength(50)]
        public string MOT_AUT_NOME { get; set; }

        [Display(Name = "Sexo")]
        [StringLength(1)]
        public string MOT_AUT_SEXO { get; set; }

        [Display(Name = "Data de nascimento")]
        [Column(TypeName = "date")]
        [DataType(DataType.Date, ErrorMessage = "Data incorreta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime MOT_AUT_DATA_NASCIMENTO { get; set; }

        [Display(Name = "CPF")]
        public int MOT_AUT_CPF { get; set; }

        [Display(Name = "RG/RGE")]
        public int MOT_AUT_RG_RGE { get; set; }

        [Display(Name = "Org�o Emissor")]
        [MaxLength(5)]
        public string MOT_AUT_RG_ORG_EMISSAO { get; set; }

        [Display(Name = "Data de emiss�o")]
        [Column(TypeName = "date")]
        [DataType(DataType.Date, ErrorMessage = "Data incorreta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? MOT_AUT_RG_DATA_EMISSAO { get; set; }

        [Required]
        [Display(Name = "CNH")]
        [StringLength(20)]
        public string MOT_AUT_CNH { get; set; }

        [Required]
        [Display(Name = "UF")]
        [StringLength(2)]
        public string MOT_AUT_CNH_UF { get; set; }

        [Display(Name = "1� CNH")]
        [StringLength(20)]
        public string MOT_AUT_P_CNH { get; set; }

        [Display(Name = "Validade")]
        [Column(TypeName = "date")]
        [DataType(DataType.Date, ErrorMessage = "Data incorreta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime MOT_AUT_CNH_VALIDADE { get; set; }

        [Display(Name = "Seguran�a")]
        [StringLength(20)]
        public string MOT_AUT_CNH_SEGURANCA { get; set; }

        [Display(Name = "Categoria")]
        public int? MOT_AUT_CNH_CAT_ID { get; set; }

        [Display(Name = "Telefone")]
        [StringLength(20)]
        public string MOT_AUT_TELEFONE { get; set; }

        [Display(Name = "Celular I")]
        [StringLength(20)]
        public string MOT_AUT_CELULAR_I { get; set; }

        [Display(Name = "Celular II")]
        [StringLength(20)]
        public string MOT_AUT_CELULAR_II { get; set; }

        [Display(Name = "Email")]
        [StringLength(50)]
        public string MOT_AUT_EMAIL { get; set; }

        [Display(Name = "Retri��o financeira")]
        [StringLength(1)]
        public string MOT_AUT_FLG_SERASA { get; set; }

        [Display(Name = "Retri��o crimnal")]
        [StringLength(1)]
        public string MOT_AUT_FLG_CRIMINAL { get; set; }
    }
}