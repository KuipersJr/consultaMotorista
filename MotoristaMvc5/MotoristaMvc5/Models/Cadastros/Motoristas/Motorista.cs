namespace MotoristaMvc5.Models.Cadastros.Motoristas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MOTORISTA")]
    public partial class MOTORISTA
    {
        [Key]
        public int MOT_ID { get; set; }

        [Required]
        [Display(Name = "Brasileiro")]
        [StringLength(1)]
        public string MOT_NACIONALIDADE { get; set; }

        [Display(Name = "Nome")]
        [StringLength(50)]
        public string MOT_NOME { get; set; }

        [Display(Name = "Sexo")]
        [StringLength(1)]
        public string MOT_SEXO { get; set; }

        [Display(Name = "Data de nascimento")]
        [Column(TypeName = "date")]
        [DataType(DataType.Date,ErrorMessage = "Data incorreta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime MOT_DATA_NASCIMENTO { get; set; }

        [Display(Name = "CPF")]        
        public string MOT_CPF { get; set; }

        [Display(Name = "RG/RGE")]
        public string MOT_RG_RGE { get; set; }

        [Display(Name = "Orgão Emissor")]
        [StringLength(5)]
        public string MOT_RG_ORG_EMISSAO { get; set; }

        [Display(Name = "Data de emissão")]
        [Column(TypeName = "date")]
        [DataType(DataType.Date, ErrorMessage = "Data incorreta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? MOT_RG_DATA_EMISSAO { get; set; }

        [Required]
        [Display(Name = "CNH")]
        [StringLength(20)]
        public string MOT_CNH { get; set; }

        [Required]
        [Display(Name = "UF")]
        [StringLength(2)]
        public string MOT_CNH_UF { get; set; }

        [Display(Name = "1ª CNH")]
        [StringLength(20)]
        public string MOT_P_CNH { get; set; }

        [Display(Name = "Validade CNH")]
        [Column(TypeName = "date")]
        [DataType(DataType.Date, ErrorMessage = "Data incorreta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime MOT_CNH_VALIDADE { get; set; }

        [Display(Name = "Segurança")]
        [StringLength(20)]
        public string MOT_CNH_SEGURANCA { get; set; }

        [Display(Name = "Categoria")]
        public string MOT_CNH_CAT_ID { get; set; }

        [Display(Name = "Telefone")]
        [StringLength(20)]
        public string MOT_TELEFONE { get; set; }

        [Display(Name = "Celular I")]
        [StringLength(20)]
        public string MOT_CELULAR_I { get; set; }

        [Display(Name = "Celular II")]
        [StringLength(20)]
        public string MOT_CELULAR_II { get; set; }

        [Display(Name = "E-mail")]
        [StringLength(50)]
        public string MOT_EMAIL { get; set; }

        [Display(Name = "Retrição financeira")]
        [StringLength(1)]
        public string MOT_FLG_SERASA { get; set; }

        [Display(Name = "Retrição criminal")]
        [StringLength(1)]
        public string MOT_FLG_CRIMINAL { get; set; }

        [Display(Name = "Código motorista")]
        [StringLength(10)]
        public string MOT_COD_INT { get; set; }

        [Display(Name = "Data de cadastro")]
        [DataType(DataType.Date, ErrorMessage = "Data incorreta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime MOT_DATA_CADASTRO { get; set; }

        //.:: Dados de endereço ::.
        [Display(Name="Enderço")]
        [StringLength(50)]
        public string END_DESCRICAO { get; set; }

        [Display(Name = "Número")]
        [StringLength(10)]
        public string END_NUMERO { get; set; }

        [Display(Name ="CEP")]
        [StringLength(10)]
        public string END_CEP { get; set; }

        [Display(Name ="Complemento")]
        [StringLength(50)]
        public string END_COMPLEMENTO { get; set; }

        [Display(Name ="UF")]
        [StringLength(2)]
        public string END_UF { get; set; }

        [Display(Name ="País")]
        [StringLength(30)]
        public string END_PAIS { get; set; }

        //.:: dados de contato ::.
        [Display(Name ="Celular II")]
        public string CONT_CELULARII { get; set; }

        [Display(Name = "Celular I")]
        public string CONT_CELULARI { get; set; }

        [Display(Name ="Telefone")]
        [StringLength(10)]
        public string CONT_TELEFONE { get; set; }

        [Display(Name ="Tipo do Contado")]
        public string CONT_REFERENCIA { get; set; }

        [Display(Name ="Nome do contato")]   
        [StringLength(30)] 
        public string CONT_NOME { get; set; }
        
    }
}
