using Api_gyakszi.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace Api_gyakszi.DAL.Data
{
    public class MySQLDBContext : DbContext
    {
        public MySQLDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> products { get; set; }
    }
}
