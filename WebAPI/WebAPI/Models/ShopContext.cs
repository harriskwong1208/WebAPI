﻿using HPlusSport.API.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class ShopContext: DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

  
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(a => a.Category)
                .HasForeignKey(a => a.CategoryId);

            modelBuilder.Seed(); //sample data
        }
        public DbSet<Products> Products { get; set; }   
        public DbSet<Category> Categories { get; set; }
    }
}
