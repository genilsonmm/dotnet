using Quiz.DATA.Data;
using Quiz.DATA.Entity;
using Quiz.DATA.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.DATA.Repository
{
    public class RespostaRepository
    {
        private readonly DataContext _dataContext;
        public RespostaRepository(DataContext dataContext) => _dataContext = dataContext;


        public Resposta Insert(Resposta resposta)
        {
            resposta.Correta.ToUpper();
            _dataContext.Respostas.Add(resposta);
            _dataContext.SaveChanges();

            return resposta;
        }

        public Resposta GetByQuestaoId(int questaoId)
        {
            return _dataContext.Respostas
                        .Where(r => r.QuestaoId == questaoId).FirstOrDefault();
        }
    }
}
