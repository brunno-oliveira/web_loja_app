namespace web_loja_dal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDA_ITEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int ID_VENDA { get; set; }

        [Required]
        [StringLength(250)]
        public string NOME { get; set; }

        [StringLength(250)]
        public string MARCA { get; set; }

        public int QUANTIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VALOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TOTAL { get; set; }

        public byte? DESCONTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOTAL_COM_DESCONTO { get; set; }

        public virtual VENDA VENDA { get; set; }
    }
}
