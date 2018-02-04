namespace MotoristaMvc5.Models.Cadastros.Veiculo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOT_VEICULO
    {
        [Key]
        public int VEI_ID { get; set; }

        [Display(Name = "Tipo proprietário")]
        public short? VEI_TIPO_PROPRIETARIO { get; set; }

        [Display(Name = "CPF")]
        [StringLength(15)]
        public string VEI_CPF { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(50)]
        public string VEI_NOME { get; set; }

        [Display(Name = "Placa")]
        [StringLength(10)]
        public string VEI_PLACA { get; set; }

        [Display(Name = "Renavam")]
        [StringLength(20)]
        public string VEI_RENAVAM { get; set; }

        [Required]
        [Display(Name = "UF")]
        [StringLength(2)]
        public string VEI_RENA_UF { get; set; }

        [Required]
        [Display(Name = "CPF/CPNJ")]
        [StringLength(20)]
        public string VEI_PROP_CPF_CNPJ { get; set; }

        [Display(Name = "Proprietário")]
        [StringLength(100)]
        public string VEI_PROP_NOME_RAZAO_SOCIAL { get; set; }

        [Display(Name = "Código do veículo")]
        [StringLength(10)]
        public string VEI_CODIGO { get; set; }

        [Display(Name = "Data de cadastro")]
        [DataType(DataType.Date, ErrorMessage = "Data incorreta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime VEI_DATA_CADASTRO { get; set; }
    }
}
