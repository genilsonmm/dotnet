using Quiz.DATA.Entity;
using Quiz.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.DATA.Service
{
    public class QuestaoService
    {
        private readonly QuestaoRepository _questaoRepository;
        private readonly RespostaRepository _respostaRepository;

        public QuestaoService(
            QuestaoRepository questaoRepository,
            RespostaRepository respostaRepository)
        {
            _questaoRepository = questaoRepository;
            _respostaRepository = respostaRepository;
        }


        public List<Questao> GetAll() => _questaoRepository.GetAll();


        public Questao Insert(Questao questao) =>
             _questaoRepository.Insert(questao);
        

        public Questao GetById(int id) => _questaoRepository.GetById(id);

        public void DeleteById(int id) => _questaoRepository.DeleteById(id);

        public void Resultado(out double nota, out int corretas, out int qntQuestoes)
        {
            List<Questao> questoes = GetAll();
            double notaCalc = 0;
            int corretasCalc = 0;

            questoes.ForEach(questao =>
            {
                Resposta? resp = _respostaRepository.GetByQuestaoId(questao.QuestaoId);

                if (questao.Alternativa.Correta.Equals(resp?.Correta))
                {
                    notaCalc = notaCalc + 1.0;
                    corretasCalc++;
                }
            });

            nota = notaCalc;
            corretas = corretasCalc;
            qntQuestoes = questoes.Count();    
        }
    }
}
