using AutoMapper;
using Quiz.API.Data.Entity;
using Quiz.API.Dto;

namespace Quiz.API.Conf
{
    public class AutoMapping : Profile
    {
        public AutoMapping() 
        {
            CreateMap<Ask, AskDTO>();
            CreateMap<AskDTO, Ask>();

            CreateMap<AnswerDTO, Answer>();
            CreateMap<Answer, AnswerDTO>();
        }
    }
}
