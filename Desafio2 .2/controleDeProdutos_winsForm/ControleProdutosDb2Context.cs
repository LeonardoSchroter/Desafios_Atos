using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace controleDeProdutos_winsForm;

public partial class ControleProdutosDb2Context : DbContext
{
    public ControleProdutosDb2Context()
    {
    }

    public ControleProdutosDb2Context(DbContextOptions<ControleProdutosDb2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Notum> Nota { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=controleProdutos_db2;User ID=controle1; password=controle1; language=Portuguese;Trusted_Connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdClientes).HasName("PK__clients__470BDBA022FFE2EA");

            entity.ToTable("clients");

            entity.Property(e => e.IdClientes).HasColumnName("idClientes");
            entity.Property(e => e.Cpf)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cpf");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Notum>(entity =>
        {
            entity.HasKey(e => e.IdNota).HasName("PK__nota__AD5F462EE5080442");

            entity.ToTable("nota");

            entity.Property(e => e.IdNota).HasColumnName("idNota");
            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.FkIdClientes).HasColumnName("fk_idClientes");
            entity.Property(e => e.FkIdProdutos).HasColumnName("fk_idProdutos");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.Valor).HasColumnName("valor");

            entity.HasOne(d => d.FkIdClientesNavigation).WithMany(p => p.Nota)
                .HasForeignKey(d => d.FkIdClientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_idClientes");

            entity.HasOne(d => d.FkIdProdutosNavigation).WithMany(p => p.Nota)
                .HasForeignKey(d => d.FkIdProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_idProdutos");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProdutos).HasName("PK__products__3BD57160B3B59F76");

            entity.ToTable("products");

            entity.Property(e => e.IdProdutos).HasColumnName("idProdutos");
            entity.Property(e => e.FkIdFornecedor).HasColumnName("fk_idFornecedor");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Preco).HasColumnName("preco");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo");

            entity.HasOne(d => d.FkIdFornecedorNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.FkIdFornecedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_IdFonecedor");
        });

        modelBuilder.Entity<Provider>(entity =>
        {
            entity.HasKey(e => e.IdFornecedor).HasName("PK__provider__CBE1227C454AF162");

            entity.ToTable("providers");

            entity.Property(e => e.IdFornecedor).HasColumnName("idFornecedor");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
