namespace web_loja_dal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTE")]
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            CESTA = new HashSet<CESTA>();
            VENDA = new HashSet<VENDA>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string NOME { get; set; }

        [Required]
        [StringLength(250)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(50)]
        public string CPF { get; set; }

        [Required]
        [StringLength(1)]
        public string SEXO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TELEFONE { get; set; }

        public DateTime DATA_CRIACAO { get; set; }

        public DateTime? DATA_ATUALIZACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CESTA> CESTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA> VENDA { get; set; }
    }
}
