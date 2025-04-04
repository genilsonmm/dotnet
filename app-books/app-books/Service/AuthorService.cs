using app_books.Data;
using app_books.Dto;
using app_books.Entity;
using app_books.Repository;
using AutoMapper;

namespace app_books.Service
{
    public class AuthorService
    {
        private AuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(AuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public AuthorResponse Create(AuthorRequest authorRequest)
        {
            Author author = _mapper.Map<Author>(authorRequest);
            return _mapper.Map<AuthorResponse>(_authorRepository.Create(author));
        }

        public List<AuthorResponse> GetAll()
        {
            List<AuthorResponse> authorResponses = new List<AuthorResponse>();  
            var authors = _authorRepository.GetAll();
            foreach (var item in authors)
            {
                authorResponses.Add(_mapper.Map<AuthorResponse>(item));
            }
            return authorResponses;
        }

        public void Delete(int id)
        {
            var author = _authorRepository.GetById(id);
            if (author == null)
            {
                throw new Exception("O autor não existe");
            }

            _authorRepository.Delete(author);
        }

        public AuthorResponse Update(int id, AuthorRequest authorRequest)
        {
            Author author = _mapper.Map<Author>(authorRequest);
            author.AuthorId = id;
            
            Author authorTemp = _authorRepository.Update(author);

            return _mapper.Map<AuthorResponse>(authorTemp);

        }
    }
}
