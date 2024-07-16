using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Products_.Models;
using Products_.Controllers;

namespace Products_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        
       
    }
}
