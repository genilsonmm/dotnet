using Microsoft.EntityFrameworkCore;
using Quiz.DATA.Data;
using Quiz.DATA.Entity;
using System;
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

        public Questao GetById(int id)
        {
            return _context.Questao
                .Where(questao => questao.QuestaoId == id)
                .Include(r => r.Resposta)
                .First();
        }

        internal void Update(Questao questao)
        {
            try
            {
                _context.Entry(questao).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch(Exception er)
            {

            }
        }
    }
}
