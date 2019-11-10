using Microsoft.EntityFrameworkCore;

using Portfolio.API.Models;

namespace Portfolio.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option)
        {
            
        }

        public DbSet<Value> Values { get; set; }
    }
}