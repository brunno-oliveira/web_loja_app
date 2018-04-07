namespace web_loja_dal.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelLocal")
        {
        }

        public virtual DbSet<CESTA> CESTA { get; set; }
        public virtual DbSet<CESTA_ITEM> CESTA_ITEM { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<PRODUTO> PRODUTO { get; set; }
        public virtual DbSet<VENDA> VENDA { get; set; }
        public virtual DbSet<VENDA_ITEM> VENDA_ITEM { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CESTA>()
                .HasMany(e => e.CESTA_ITEM)
                .WithRequired(e => e.CESTA)
                .HasForeignKey(e => e.ID_CESTA)
                .WillCascadeOnDelete(false);

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
                .Property(e => e.SEXO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.TELEFONE)
                .HasPrecision(25, 0);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.CESTA)
                .WithRequired(e => e.CLIENTE)
                .HasForeignKey(e => e.ID_CLIENTE)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.CESTA_ITEM)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA>()
                .HasMany(e => e.VENDA_ITEM)
                .WithRequired(e => e.VENDA)
                .HasForeignKey(e => e.ID_VENDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA_ITEM>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_ITEM>()
                .Property(e => e.MARCA)
                .IsUnicode(false);
        }
    }
}
