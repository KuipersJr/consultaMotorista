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
        [StringLength(20)]
        public string EMP_CNPJ { get; set; }

        [Required]
        [StringLength(20)]
        public string EMP_IE { get; set; }

        [StringLength(100)]
        public string EMP_NOME_RAZAO_SOCIAL { get; set; }

        [Required]
        [StringLength(10)]
        public string EMP_CEP { get; set; }

        [StringLength(50)]
        public string EMP_ENDERECO { get; set; }

        [StringLength(20)]
        public string EMP_COMPLEMENTO { get; set; }

        [StringLength(50)]
        public string EMP_CIDADE { get; set; }

        [StringLength(50)]
        public string EMP_BAIRRO { get; set; }

        [StringLength(2)]
        public string EMP_UF { get; set; }
    }
}
