using AutoMapper;
using Quiz.API.Data.Entity;
using Quiz.API.Data.Repository;
using Quiz.API.Dto;

namespace Quiz.API.Data.Services
{
    public class AskService
    {
        private readonly AskRepository _skRepository;
        private readonly IMapper _mapper;

        public AskService(AskRepository repository, IMapper mapper)
        {
            _skRepository = repository;
            _mapper = mapper;
        }

        public AskDTO Insert(AskDTO dto)
        {
            var ask = _mapper.Map<Ask>(dto);
            ask.Answers.Add(_mapper.Map<Answer>(dto.Answer));

            var result = _skRepository.Insert(ask);

            return _mapper.Map<AskDTO>(result);
        }

        public List<AskDTO> GetAll()
        {
            var result = _skRepository.GetAll();
            var asks = _mapper.Map<List<AskDTO>>(result);
            return asks;
        }

        public void Delete(int id)
        {
            _skRepository.Delete(id);
        }
    }
}
