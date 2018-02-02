namespace MotoristaMvc5.Models.Cadastros.Motoristas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTATO_MOTORISTA
    {
        [Key]
        public int CONT_ID { get; set; }

        public int CONT_MOT_ID { get; set; }

        public int CONT_REFERENCIA { get; set; }

        [Required]
        [StringLength(30)]
        public string CONT_NOME { get; set; }

        [StringLength(20)]
        public string CONT_TELEFONE { get; set; }

        public int? CONT_CELULARI { get; set; }

        public int? CONT_CELULARII { get; set; }
    }
}
