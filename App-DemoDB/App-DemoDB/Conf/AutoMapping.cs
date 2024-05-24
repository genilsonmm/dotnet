using App_DemoDB.Entity;
using App_DemoDB.Model;
using AutoMapper;

namespace App_DemoDB.Conf
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<AlunoDTO, Aluno>();
            CreateMap<Aluno, AlunoResponse>();
        }
    }
}
