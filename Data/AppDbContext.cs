using Microsoft.EntityFrameworkCore;
using NorthWind_API.Models.Categories;
using System.Transactions;

namespace NorthWind_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<Category> Categories { get; set; }
    }
}
