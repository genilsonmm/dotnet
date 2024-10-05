using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Quiz.API.Data.Entity;
using System.Diagnostics.CodeAnalysis;

namespace Quiz.API.Data.Repository
{
    public class AskRepository
    {
        private readonly DataContext _context;
        public AskRepository(DataContext context)
        {
            _context = context;
        }

        public Ask Insert(Ask ask)
        {
            _context.Asks.Add(ask);
            _context.SaveChanges();
            return ask;
        }

        public List<Ask> GetAll() => _context.Asks.ToList();

        public void Delete(int id)
        {
            var entity = _context.Asks.SingleOrDefault(e=>e.AskId == id);
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}
