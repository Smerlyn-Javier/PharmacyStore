using Microsoft.EntityFrameworkCore;

namespace Pharmacy.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Drug> Drugs { get; set; }
    }
}