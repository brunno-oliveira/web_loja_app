namespace web_loja_dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUTO")]
    public partial class PRODUTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUTO()
        {
            CESTA_ITEM = new HashSet<CESTA_ITEM>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string NOME { get; set; }

        [StringLength(250)]
        public string MARCA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VALOR { get; set; }

        public int QUANTIDADE { get; set; }

        public byte? ATIVO { get; set; }

        public DateTime DATA_CRIACAO { get; set; }

        public DateTime? DATA_ATUALIZACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CESTA_ITEM> CESTA_ITEM { get; set; }
    }
}
