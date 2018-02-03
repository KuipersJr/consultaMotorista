namespace MotoristaMvc5.Models.IBGE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IBGE_UF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IBGE_UF_ID { get; set; }

        [StringLength(2)]
        public string EST_SIGLA { get; set; }

        [StringLength(50)]
        public string EST_ESTADO { get; set; }
    }
}
