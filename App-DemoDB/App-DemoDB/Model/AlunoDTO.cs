using App_DemoDB.Entity;

namespace App_DemoDB.Model
{
    public class AlunoDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Aluno ToAluno(AlunoDTO aluno)
        {
            return new Aluno()
            {
                Name = aluno.Name,
                Age = aluno.Age
            };
        }
    }
}
