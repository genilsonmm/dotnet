using Quiz.DATA.Data;
using Quiz.DATA.DTO;
using Quiz.DATA.Entity;
using Quiz.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.DATA.Service
{
    public class RespostasService
    {
        private readonly RespostaRepository _repository;

        public RespostasService(DataContext context)
        {
            _repository = new RespostaRepository(context);

        }

        public ResultadoDTO Calcular(List<RespostasDTO> respostas)
        {
            ResultadoDTO resultadoDTO = new ResultadoDTO();

            List<Resposta> respostasCorretas = _repository.GetAll();

            respostas.ForEach(res =>
            {
                var questaoAtual = respostasCorretas.Find(x => x.QuestaoId == res.QuestaoId);
                if (questaoAtual.AlternativaCorreta.Equals(res.Resposta))
                {
                    resultadoDTO.Corretas += 1;
                } else
                {
                    resultadoDTO.Erradas += 1;
                }
            });

            return resultadoDTO;
        }
    }
}
