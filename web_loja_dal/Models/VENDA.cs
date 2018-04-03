namespace web_loja_dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENDA")]
    public partial class VENDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDA()
        {
            VENDA_ITEM = new HashSet<VENDA_ITEM>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int ID_CLIENTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOTAL { get; set; }

        public DateTime DATA_CRIACAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOTAL_DESCONTO { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_ITEM> VENDA_ITEM { get; set; }
    }
}
