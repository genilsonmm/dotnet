using Escola.Dados.Dto;
using Escola.Dados.Entidades;
using Escola.Dados.Repository;

namespace Escola.Dados.Service
{
    public class AlunoService
    {
        private AlunoRepository _alunoRepository;
        public AlunoService(AlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public void Add(AlunoDTO aluno)
        {
            _alunoRepository.Add(ToAluno(aluno));
        }

        private Aluno ToAluno(AlunoDTO aluno)
        {
            return new Aluno() { Nome = aluno.Nome };
        }

    }
}
