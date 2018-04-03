namespace web_loja_dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CESTA")]
    public partial class CESTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CESTA()
        {
            CESTA_ITEM = new HashSet<CESTA_ITEM>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int ID_CLIENTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOTAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOTAL_COM_DESCONTO { get; set; }

        public DateTime DATA_CRIACAO { get; set; }

        public DateTime? DATA_ATUALIZACAO { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CESTA_ITEM> CESTA_ITEM { get; set; }
    }
}
