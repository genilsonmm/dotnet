using Microsoft.EntityFrameworkCore;
using Quiz.DATA.Entity;

namespace Quiz.DATA.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Questao> Questao { get; set; }
    }
}
