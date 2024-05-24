using App_DemoDB.Data;
using App_DemoDB.Entity;
using App_DemoDB.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App_DemoDB.Repository
{
    public class AlunoRepository
    {
        private readonly DataContext dataContext;

        public AlunoRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public Aluno Cadastrar(Aluno aluno)
        {
            this.dataContext.Alunos.Add(aluno);
            this.dataContext.SaveChanges();
            return aluno;
        }

        public List<Aluno> ObterTodos() => this.dataContext.Alunos.Include(a => a.Notas).ToList();

        public Aluno ObterPorId(int id) => this.dataContext.Alunos.Find(id);

        public List<Aluno> ObterMaiores() => this.dataContext.Alunos.Where(aluno => aluno.Age > 18).ToList();
        
        public void Deletar(int id)
        {
            this.dataContext.Alunos.Remove(ObterPorId(id));
            this.dataContext.SaveChanges();
        }

        public Aluno Atualizar(Aluno aluno)
        {
            this.dataContext.Entry(aluno).State = EntityState.Modified;
            this.dataContext.SaveChanges();
            return aluno;
        }
    }
}
