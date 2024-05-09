
using App_DemoDB.Entity;
using Microsoft.EntityFrameworkCore;

namespace App_DemoDB.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }   
        
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Nota> Notas { get; set; }
    }
}
