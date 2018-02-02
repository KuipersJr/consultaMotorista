namespace MotoristaMvc5.Models.Cadastros.Motoristas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENDERECO_MOTORISTA
    {
        [Key]
        public int END_ID { get; set; }

        public int END_MOT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string END_DESCRICAO { get; set; }

        [Required]
        [StringLength(10)]
        public string END_NUMERO { get; set; }

        [Required]
        [StringLength(10)]
        public string END_CEP { get; set; }

        [StringLength(50)]
        public string END_COMPLEMENTO { get; set; }
    }
}
