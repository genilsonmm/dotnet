using App_DemoDB.Entity;
using System.ComponentModel.DataAnnotations;

namespace App_DemoDB.Entity
{
    public class Nota
    {
        public int NotaId { get; set; }
        public string Periodo { get; set; }
        public decimal Pontuacao { get; set; }

        //relacionamento
        public virtual Aluno Aluno { get; set; }
        public int AlunoId { get; set; }
    }
}
