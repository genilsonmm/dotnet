using CryptoManagement.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace CryptoManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Coin> Coins { get; set; }
    }
}
