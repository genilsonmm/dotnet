using Microsoft.EntityFrameworkCore;
using Quiz.DATA.Entity;

namespace Quiz.DATA.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Questao> Questoes { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
    }
}
