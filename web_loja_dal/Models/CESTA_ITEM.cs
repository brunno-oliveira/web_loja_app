namespace web_loja_dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CESTA_ITEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int ID_CESTA { get; set; }

        public int ID_PRODUTO { get; set; }

        public int QUANTIDADE { get; set; }

        public DateTime DATA_CRIACAO { get; set; }

        public DateTime? DATA_ATUALIZACAO { get; set; }

        public virtual CESTA CESTA { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
