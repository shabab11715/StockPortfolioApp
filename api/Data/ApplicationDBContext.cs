using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Portfolio>(x => x.HasKey(p => new { p.AppUserId, p.StockId }));

            builder.Entity<Portfolio>()
                .HasOne(u => u.AppUser)
                .WithMany(u => u.Portfolios)
                .HasForeignKey(p => p.AppUserId);

            builder.Entity<Portfolio>()
                .HasOne(u => u.Stock)
                .WithMany(u => u.Portfolios)
                .HasForeignKey(p => p.StockId);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = "b4f2a3a6-6c8c-4a8b-9e4d-8c94f7c9e8e3",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "b4f2a3a6-6c8c-4a8b-9e4d-8c94f7c9e8e3"
                },
                new IdentityRole
                {
                    Id = "7a1c49b2-2c7d-4db0-9c72-3af62f97c30b",
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = "7a1c49b2-2c7d-4db0-9c72-3af62f97c30b"
                },
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}