using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TESTAPI.Models
{
    public partial class KALBEContext : DbContext
    {
        public KALBEContext()
        {
        }

        public KALBEContext(DbContextOptions<KALBEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MCurrency> MCurrencys { get; set; }
        public virtual DbSet<MPo> MPos { get; set; }
        public virtual DbSet<MTo> MTos { get; set; }
        public virtual DbSet<TInvoiceD> TInvoiceDs { get; set; }
        public virtual DbSet<TInvoiceH> TInvoiceHs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=DESKTOP-LECTQ14\\SQLSERVER2017; Database=KALBE; User ID=sa;Password=P@ssw0rd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<MCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyID);

                entity.ToTable("MCurrency");

                entity.Property(e => e.CurrencyID)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencyDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPo>(entity =>
            {
                entity.HasKey(e => e.PONo);

                entity.ToTable("MPo");

                entity.Property(e => e.PONo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PONo");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTo>(entity =>
            {
                entity.HasKey(e => e.ToID);

                entity.ToTable("MTo");

                entity.Property(e => e.ToID)
                    .ValueGeneratedNever()
                    .HasColumnName("ToID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TInvoiceD>(entity =>
            {
                entity.HasKey(e => e.InvoiceDetailID);

                entity.ToTable("TInvoiceD");

                entity.Property(e => e.InvoiceDetailID)
                    .ValueGeneratedNever()
                    .HasColumnName("InvoiceDetailID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceHID)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceHID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TInvoiceH>(entity =>
            {
                entity.HasKey(e => e.InvoiceHID);

                entity.ToTable("TInvoiceH");

                entity.Property(e => e.InvoiceHID)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceHID");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Discount)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDue).HasColumnType("datetime");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Percent)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Pono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PONo");

                entity.Property(e => e.ToID)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ToID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
