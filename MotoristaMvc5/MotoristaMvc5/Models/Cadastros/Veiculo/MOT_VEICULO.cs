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

        public short? VEI_TIPO_PROPRIETARIO { get; set; }

        public int VEI_CPF { get; set; }

        [StringLength(50)]
        public string VEI_NOME { get; set; }

        [StringLength(10)]
        public string VEI_PLACA { get; set; }

        [StringLength(20)]
        public string VEI_RENAVAM { get; set; }

        [Required]
        [StringLength(2)]
        public string VEI_RENA_UF { get; set; }

        [Required]
        [StringLength(20)]
        public string VEI_PROP_CPF_CNPJ { get; set; }

        [StringLength(100)]
        public string VEI_PROP_NOME_RAZAO_SOCIAL { get; set; }
    }
}
