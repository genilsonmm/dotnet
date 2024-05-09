
using System.ComponentModel.DataAnnotations.Schema;

namespace App_DemoDB.Entity
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }
        
        public int Age { get; set; }

        public List<Nota> Notas { get; set; }
    }
}
