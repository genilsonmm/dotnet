using app_books.Data;
using app_books.Entity;
using Microsoft.EntityFrameworkCore;

namespace app_books.Repository
{
    public class AuthorRepository
    {
        private readonly DataContext _dataContext;

        public AuthorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Author Create(Author author)
        {
            _dataContext.Authors.Add(author);
            _dataContext.SaveChanges();
            return author;
        }

        public List<Author> GetAll() => _dataContext.Authors.ToList();

        public Author GetById(int id) => 
            _dataContext.Authors.Where(a => a.AuthorId == id).FirstOrDefault();

        public void Delete(Author author)
        {
            _dataContext.Authors.Remove(author);
            _dataContext.SaveChanges();
        }

        public Author Update(Author author)
        {
            _dataContext.Entry(author).State = EntityState.Modified;
            _dataContext.SaveChanges();
            return author;
        }
        
    }
}
