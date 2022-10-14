using Quiz.DATA.Data;
using Quiz.DATA.DTO;
using Quiz.DATA.Entity;
using Quiz.DATA.Repository;
using System.Collections.Generic;

namespace Quiz.DATA.Service
{
    public class QuestaoService
    {
        private readonly QuestaoRepository _repository;

        public QuestaoService(DataContext context)
        {
            _repository = new QuestaoRepository(context);
        }

        public List<QuestaoDTO> GetAll()
        {
            var questoes = _repository.GetAll();
            return ToDTOList(questoes);
        }

        public QuestaoDTO Insert(NovaQuestaoDTO novaQuestao)
        {
            var questaoCadastrada = _repository.Insert(ToEntity(novaQuestao));
            return ToDTO(questaoCadastrada);
        }

        private Questao ToEntity(NovaQuestaoDTO novaQuestao)
        {
            Questao questao = new Questao();
            questao.Titulo = novaQuestao.Titulo;
            questao.AlternativaA = novaQuestao.AlternativaA;
            questao.AlternativaB = novaQuestao.AlternativaB;
            questao.AlternativaC = novaQuestao.AlternativaC;
            questao.AlternativaD = novaQuestao.AlternativaD;
            questao.AlternativaE = novaQuestao.AlternativaE;
            questao.Resposta = new Resposta(novaQuestao.AlternativaCorreta);
            return questao;
        }

        private QuestaoDTO ToDTO(Questao questao)
        {
            QuestaoDTO questaoDTO = new QuestaoDTO();
            questaoDTO.QuestaoId = questao.QuestaoId;
            questaoDTO.Titulo = questao.Titulo;
            questaoDTO.AlternativaA = questao.AlternativaA; 
            questaoDTO.AlternativaB = questao.AlternativaB; 
            questaoDTO.AlternativaC = questao.AlternativaC; 
            questaoDTO.AlternativaD = questao.AlternativaD; 
            questaoDTO.AlternativaE = questao.AlternativaE;
            return questaoDTO;
        }

        private List<QuestaoDTO> ToDTOList(List<Questao> questoes)
        {
            List<QuestaoDTO> list = new List<QuestaoDTO>();
            questoes.ForEach(item =>
            {
                list.Add(ToDTO(item));
            });
            return list;
        }
    }
}
