using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escola.Dados.Entidades
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        [Column("name", TypeName="varchar(100)")]
        [Required]
        public string Nome { get; set; }
    }
}
