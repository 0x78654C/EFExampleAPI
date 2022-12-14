using System;
using System.Collections.Generic;
using EF_Example.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EF_Example
{
    public partial class ExampleDbContext : DbContext
    {

        public ExampleDbContext()
        {
        }

        public ExampleDbContext(string connectionString) : base(GetOptions(connectionString))
        {
        }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString)
                .Options;
        }

        public ExampleDbContext(DbContextOptions<ExampleDbContext> options)
            : base(options)
        {
        }
  
        public virtual DbSet<UserLogin> UserLogin { get; set; } = null!;
        public virtual DbSet<UserData> UserData { get; set; } = null!;

        /// <summary>
        /// Structure the db tables.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.ToTable("UserLogin");
                entity.HasIndex(u => u.id)
                  .IsUnique();

                entity.Property(e => e.User_name).HasMaxLength(150);
                entity.Property(e => e.Password).HasMaxLength(150);
                entity.Property(e => e.Login_date).HasColumnType("date");
            });

            modelBuilder.Entity<UserData>(entity =>
            {
                entity.ToTable("UserData");
                entity.HasIndex(u => u.id)
                  .IsUnique();

                entity.Property(e => e.User_id);
                entity.Property(e => e.Item_name).HasMaxLength(150);
                entity.Property(e => e.Amount);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
