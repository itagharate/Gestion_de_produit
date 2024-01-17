using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Gestion_Produit.Models;

public partial class BasealpachinoContext : DbContext
{
    public BasealpachinoContext()
    {
    }

    public BasealpachinoContext(DbContextOptions<BasealpachinoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Produit> Produits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Produits__3213E83FFA2E1A43");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Categorie)
                .HasMaxLength(50)
                .HasColumnName("categorie");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Prix)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("prix");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.Titre)
                .HasMaxLength(255)
                .HasColumnName("titre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
