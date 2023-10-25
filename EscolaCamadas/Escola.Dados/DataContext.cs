using Escola.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Escola.Dados
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Nota> Nota { get; set; }
    }
}
