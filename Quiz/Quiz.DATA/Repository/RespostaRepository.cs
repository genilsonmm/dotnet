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
    internal class RespostaRepository
    {
        private readonly DataContext _context;

        public RespostaRepository(DataContext context)
        {
            _context = context;
        }

        public List<Resposta> GetAll() => _context.Resposta.ToList();

        public void Update(Resposta resposta)
        {
            _context.Entry(resposta).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
