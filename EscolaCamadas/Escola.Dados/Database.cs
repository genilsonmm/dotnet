using Escola.Dados.Entidades;
using System.ComponentModel;

namespace Escola.Dados
{
    public class Database
    {
        private static Database instance = null;
        private List<Aluno> alunos = new List<Aluno>();

        public static Database Instance()
        {
            if(instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        public List<Aluno> Alunos() => alunos;
    }
}

// Database.Instance().Alunos()