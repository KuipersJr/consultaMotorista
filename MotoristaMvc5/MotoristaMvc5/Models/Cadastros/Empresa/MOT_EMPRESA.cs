namespace MotoristaMvc5.Models.Cadastros.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOT_EMPRESA
    {
        [Key]
        public int EMP_ID { get; set; }

        [Required]
        [Display(Name = "CPNJ")]
        [StringLength(20)]
        public string EMP_CNPJ { get; set; }

        [Required]
        [Display(Name = "Inscrição estadual")]
        [StringLength(20)]
        public string EMP_IE { get; set; }

        [Display(Name = "Nome/Razão social")]
        [StringLength(100)]
        public string EMP_NOME_RAZAO_SOCIAL { get; set; }

        [Required]
        [Display(Name = "CEP")]
        [StringLength(10)]
        public string EMP_CEP { get; set; }

        [Display(Name = "Edenreço")]
        [StringLength(50)]
        public string EMP_ENDERECO { get; set; }

        [Display(Name = "Complemento")]
        [StringLength(20)]
        public string EMP_COMPLEMENTO { get; set; }

        [Display(Name = "Cidade")]
        [StringLength(50)]
        public string EMP_CIDADE { get; set; }

        [Display(Name = "Bairro")]
        [StringLength(50)]
        public string EMP_BAIRRO { get; set; }

        [Display(Name = "UF")]
        [StringLength(2)]
        public string EMP_UF { get; set; }

        [Display(Name = "Data de cadastro")]
        [DataType(DataType.Date, ErrorMessage = "Data incorreta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EMP_DATA_CADASTRO { get; set; }

        [Display(Name = "Código")]
        [StringLength(10)]
        public String EMP_CODIGO { get; set; }
    }
}
