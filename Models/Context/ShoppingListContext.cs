using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ShoppingList.Models
{
    public partial class ShoppingListContext : DbContext
    {
        public ShoppingListContext()
        {
        }

        public ShoppingListContext(DbContextOptions<ShoppingListContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BuyList> BuyLists { get; set; } = null!;
        public virtual DbSet<Meal> Meals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=sql112.main-hosting.eu;database=u604518715_ShoppingList;user=u604518715_ListUser;password=Kakemann2;treattinyasboolean=true", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.5.12-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_unicode_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<BuyList>(entity =>
            {
                entity.ToTable("BuyList");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("int(11)");

                entity.Property(e => e.Category).HasMaxLength(250);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Deactivated).HasColumnType("tinyint(4)");

                entity.Property(e => e.MealListId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MealListID");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Unit).HasMaxLength(250);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Category).HasMaxLength(250);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Deactivated).HasColumnType("tinyint(4)");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .UseCollation("utf8_unicode_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Persons).HasColumnType("int(11)");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
