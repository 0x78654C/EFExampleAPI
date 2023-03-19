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
            return new DbContextOptionsBuilder().UseSqlServer(connectionString)
                .Options;
        }

        public ExampleDbContext(DbContextOptions<ExampleDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserLogin> UserLogin { get; set; } = null!;
        public virtual DbSet<UserData> UserData { get; set; } = null!;
        public virtual DbSet<Books> Books { get; set; } = null!;
        public virtual DbSet<UseRole> UseRoles { get; set; } = null!;


        /// <summary>
        /// Structure the db tables.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UseRole>(entity =>
            {
                entity.HasIndex(e => e.Id).IsUnique();
                entity.ToTable("User_Role");
                entity.HasData(Enum.GetValues<Roles>().Select(w => new Role { Id = (int)w, Role_Name = w.ToString() }));

            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.ToTable("UserLogin");
                entity.HasIndex(u => u.id)
                  .IsUnique();
                entity.Property(e => e.User_name).HasMaxLength(150);
                entity.Property(e => e.Password).HasMaxLength(150);
                entity.Property(e => e.User_Role).HasMaxLength(3).HasDefaultValue(3);
                entity.Property(e => e.Login_date).HasColumnType("date");
            });

            modelBuilder.Entity<UserData>(entity =>
            {
                entity.ToTable("UserData");
                entity.HasIndex(u => u.id)
                  .IsUnique();
                entity.Property(e => e.User_id);
                entity.Property(e => e.Book_Name).HasMaxLength(150);
                entity.Property(e => e.Amount);
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.ToTable("Books");
                entity.HasIndex(u => u.id)
                  .IsUnique();
                entity.Property(e => e.ISBN).HasMaxLength(13);
                entity.Property(e => e.Book_Name).HasMaxLength(250);
                entity.Property(e => e.Author);
                entity.Property(e => e.Category);
                entity.Property(e => e.Amount);
                entity.Property(e => e.Price);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
