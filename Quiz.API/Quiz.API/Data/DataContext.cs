using Microsoft.EntityFrameworkCore;
using Quiz.API.Data.Entity;

namespace Quiz.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options) { }
        

        public DbSet<Ask> Asks { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
