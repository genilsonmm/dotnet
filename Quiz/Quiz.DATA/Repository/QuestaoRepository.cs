using Quiz.DATA.Data;
using Quiz.DATA.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.DATA.Repository
{
    internal class QuestaoRepository
    {
        private readonly DataContext _context;

        public QuestaoRepository(DataContext context)
        {
            _context = context;
        }

        public Questao Insert(Questao questao)
        {
            _context.Questao.Add(questao);
            _context.SaveChanges();
            return questao;
        }

        public List<Questao> GetAll() => _context.Questao.ToList();
    }
}
