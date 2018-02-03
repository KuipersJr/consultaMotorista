namespace MotoristaMvc5.Models.Cadastros.Motoristas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOT_AGREGADO_VEICULO
    {
        [Key]
        public int MAV_ID { get; set; }

        [Display(Name = "Tipo de proprietário")]
        [StringLength(1)]
        public string MAV_TIPO_PROPRIETARIO { get; set; }

        [Display(Name = "CPF")]
        [StringLength(15)]
        public string MAV_CPF { get; set; }

        [Display(Name = "Nome")]
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
        [Display(Name = "CPF proprietário")]
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
        [Column(TypeName = "date")]
        [DataType(DataType.Date, ErrorMessage = "Data incorreta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime MAV_PROP_DATA_NASCIMENTO { get; set; }

        [Required]
        [Display(Name = "RG")]
        [StringLength(20)]
        public string MAV_PROP_RG { get; set; }

        [Required]
        [Display(Name = "UF")]
        [StringLength(2)]
        public string MAV_PROP_UF { get; set; }
    }
}
