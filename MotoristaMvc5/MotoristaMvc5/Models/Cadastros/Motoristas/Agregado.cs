namespace MotoristaMvc5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Agregado
    {
        [Key]
        public int MAV_ID { get; set; }

        [Display(Name ="Tipo de proprietário")]
        public short? MAV_TIPO_PROPRIETARIO { get; set; }

        [Display(Name = "Cpf do agregado")]
        public int MAV_CPF { get; set; }

        [Display(Name = "Nome do agregado")]
        [StringLength(50)]
        public string MAV_NOME { get; set; }

        [Display(Name = "Placa")]
        [StringLength(10)]
        public string MAV_PLACA { get; set; }

        [Display(Name = "Renavam")]
        [StringLength(20)]
        public string MAV_RENAVAM { get; set; }

        [Required]
        [Display(Name = "UF")]
        [StringLength(2)]
        public string MAV_RENA_UF { get; set; }

        [Required]
        [Display(Name = "CPF/CNPJ do proprietário")]
        [StringLength(20)]
        public string MAV_PROP_CPF_CNPJ { get; set; }

        [Display(Name = "Nome/Razão social")]
        [StringLength(100)]
        public string MAV_PROP_NOME_RAZAO_SOCIAL { get; set; }

        [Display(Name = "Nome da mãe")]
        [StringLength(50)]
        public string MAV_PROP_NOME_MAE { get; set; }

        [Display(Name = "Nome do pai")]
        [StringLength(50)]
        public string MAV_PROP_NOME_PAI { get; set; }

        [Display(Name = "Sexo")]
        [StringLength(1)]
        public string MAV_PROP_SEXO { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime MAV_PROP_DATA_NASCIMENTO { get; set; }

        [Required]
        [Display(Name = "Rg do proprietário")]
        [StringLength(20)]
        public string MAV_PROP_RG { get; set; }

        [Required]
        [Display(Name = "UF")]
        [StringLength(2)]
        public string MAV_PROP_UF { get; set; }
    }
}
