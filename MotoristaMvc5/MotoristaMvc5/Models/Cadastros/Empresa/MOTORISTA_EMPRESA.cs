namespace MotoristaMvc5.Models.Cadastros.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOTORISTA_EMPRESA
    {
        [Key]
        public int MEP_ID { get; set; }

        public int? MOD_MOT_ID { get; set; }

        public int? MOT_EMP_ID { get; set; }
    }
}
