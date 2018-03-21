namespace web_loja_dal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EstoqueModel : DbContext
    {
        public EstoqueModel()
            : base("name=estoque")
        {
        }

        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<ITEM_VENDA> ITEM_VENDA { get; set; }
        public virtual DbSet<PRODUTO> PRODUTO { get; set; }
        public virtual DbSet<VENDA> VENDA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.VENDA)
                .WithRequired(e => e.CLIENTE)
                .HasForeignKey(e => e.ID_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.MARCA)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.VALOR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.ITEM_VENDA)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA>()
                .HasMany(e => e.ITEM_VENDA)
                .WithRequired(e => e.VENDA)
                .HasForeignKey(e => e.ID_VENDA)
                .WillCascadeOnDelete(false);
        }
    }
}
