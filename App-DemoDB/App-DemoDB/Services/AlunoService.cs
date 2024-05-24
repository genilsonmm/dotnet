using App_DemoDB.Entity;
using App_DemoDB.Model;
using App_DemoDB.Repository;
using AutoMapper;

namespace App_DemoDB.Services
{
    public class AlunoService
    {
        private readonly AlunoRepository _repository;
        private readonly IMapper _mapper;

        public AlunoService(AlunoRepository alunoRepository, IMapper mapper)
        {
            _repository = alunoRepository;
            _mapper = mapper;
        }

        public AlunoResponse Cadastrar(AlunoDTO alunoDTO)
        {
            Aluno novoAluno = _mapper.Map<Aluno>(alunoDTO);
            
            Aluno alunoCadastrado = _repository.Cadastrar(novoAluno);

            return _mapper.Map<AlunoResponse>(alunoCadastrado);
        }

        public List<AlunoResponse> ObterTodos()
        {
            List<Aluno> alunos = _repository.ObterTodos();
            return _mapper.Map<List<AlunoResponse>>(alunos);
        }

        public Aluno ObterPorId(int id) => _repository.ObterPorId(id);

        public List<Aluno> ObterMaiores() => _repository.ObterMaiores();

        public void Deletar(int id) => _repository.Deletar(id);

        public Aluno Atualizar(Aluno aluno) => _repository.Atualizar(aluno);
    }
}
