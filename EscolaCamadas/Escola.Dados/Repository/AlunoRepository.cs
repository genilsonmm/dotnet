using Escola.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Escola.Dados.Repository
{
    public class AlunoRepository
    {
        private readonly DataContext _dataContext;
        public AlunoRepository(DataContext dataContext) 
        { 
            _dataContext = dataContext;
        }

        public void Add(Aluno aluno)
        {
            _dataContext.Alunos.Add(aluno);
            _dataContext.SaveChanges();
        }

        public List<Aluno> GetAll()
        {
            return _dataContext.Alunos.ToList();
        }

        public void Delete(int id)
        {
            _dataContext.Alunos.Remove(_dataContext
                .Alunos
                .Where(a=>a.AlunoId == id)
                .FirstOrDefault());
            
            _dataContext.SaveChanges();
        }

        public void Update(Aluno aluno)
        {
            _dataContext.Entry(aluno).State = EntityState.Modified;
            _dataContext.SaveChanges();
        }
    }
}
