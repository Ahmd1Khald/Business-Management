using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery_Store.Entities
{
    public class Context:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> Order_Items { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "appdata.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, Name = "أقلام", Description = "أقلام جامدة اوي" },
                new Category { ID = 2, Name = "كشاكيل", Description = "كشاكشيل جامدة اوي" }
                );

            modelBuilder.Entity<Product>().HasData(
            new Product { ID = 1, Name= "قلم رصاص",CategoryId = 1,Description="قلم رصاص جامد جدا",Price=10F,Quantity=100},
            new Product { ID = 2, Name = "كراسة", CategoryId = 2, Description = "كراسة مربعات 80 ص", Price = 15F, Quantity = 120 });

            
            base.OnModelCreating(modelBuilder);
        }
    }
}
