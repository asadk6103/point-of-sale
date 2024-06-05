using Microsoft.EntityFrameworkCore;
using posapp.Database.Models;
using posapp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posapp.Database.ContextProvider
{

    

    public class POSContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Demands> Demands{ get; set; }
        public DbSet<Order> Order{ get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=pos;user=root;password=P@kista9123", new MySqlServerVersion(new Version(8, 0, 21)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data
            modelBuilder.Entity<User>().HasData(
                new User { Id=1, DisplayName = "Administrator", UserName="admin", Email = "admin@pos.com", Password = PasswordHashing.EncodePassword("Admin123*"), Role = Role.Admin, Status = ActiveStatus.Active, createdAt = new DateOnly(), updateddAt = new DateOnly() }
            );
        }
    }
}
