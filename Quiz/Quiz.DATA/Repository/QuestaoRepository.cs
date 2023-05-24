using Microsoft.EntityFrameworkCore;
using Quiz.DATA.Data;
using Quiz.DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.DATA.Repository
{
    public class QuestaoRepository
    {
        private readonly DataContext _dataContext;

        public QuestaoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Questao> GetAll()
        {
            return _dataContext.Questoes.Include(a => a.Alternativa).ToList();
        }

        public Questao Insert(Questao questao)
        {
            questao.Alternativa.Correta.ToUpper();
            _dataContext.Questoes.Add(questao);
            _dataContext.SaveChanges();
            return questao;
        }

        public Questao GetById(int id) => 
            _dataContext.Questoes.Include(a => a.Alternativa).Where(q => q.QuestaoId == id).FirstOrDefault();

        public void DeleteById(int id)
        {
            Questao questaoParaRemover = GetById(id);
            _dataContext.Alternativas.Remove(questaoParaRemover.Alternativa);
            _dataContext.Questoes.Remove(questaoParaRemover);
            _dataContext.SaveChanges();
        }
    }
}
