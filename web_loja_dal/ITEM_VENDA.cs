namespace web_loja_dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ITEM_VENDA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int ID_VENDA { get; set; }

        public int ID_PRODUTO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual VENDA VENDA { get; set; }
    }
}
