using Microsoft.EntityFrameworkCore;
using Quiz.API.Data.Entity;

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

        public List<Ask> GetAll() => _context.Asks.Include(a=>a.Answers).ToList();

        public void Delete(int id)
        {
            var entity = _context.Asks.SingleOrDefault(e=>e.AskId == id);
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}
