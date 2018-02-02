namespace MotoristaMvc5.Models.Cadastros.Veiculo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Veiculo
    {
        [Key]
        public int VEI_ID { get; set; }
        [Display(Name = "Tipo de proprietário")]
        public short? VEI_TIPO_PROPRIETARIO { get; set; }

        [Display(Name = "CPF")]
        public int VEI_CPF { get; set; }

        [Display(Name = "Modelo")]
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
        [Display(Name = "CPF/CNPJ")]
        [StringLength(20)]
        public string VEI_PROP_CPF_CNPJ { get; set; }

        [Display(Name = "Nome/Razão Social")]
        [StringLength(100)]
        public string VEI_PROP_NOME_RAZAO_SOCIAL { get; set; }
    }
}
