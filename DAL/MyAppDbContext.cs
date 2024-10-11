using CRUD_WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD_WebAPI.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
