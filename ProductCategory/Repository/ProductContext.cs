using ProductCategory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProductCategory.Repository
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("aspnet - ProductCategory - 20170922070621")
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Product>();

        }

    }
}