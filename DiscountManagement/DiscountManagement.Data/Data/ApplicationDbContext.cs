using DiscountManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Data.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
           
        }

        public DbSet<DiscountType> DiscountTypes { get; set; }
        public DbSet<DiscountRule> DiscountRules { get; set; }
        public DbSet<ItemDiscount> ItemDiscounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<DiscountType>().ToTable(nameof(DiscountType));
            //modelBuilder.Entity<DiscountRule>().ToTable(nameof(DiscountRule));
            //modelBuilder.Entity<ItemDiscount>().ToTable("ItemDiscount");
        }
    }
}
