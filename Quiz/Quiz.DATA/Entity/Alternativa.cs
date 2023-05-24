using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.DATA.Entity
{
    public class Alternativa
    {
        public int AlternativaId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório"), MaxLength(100)]
        public string AlternativaA { get; set; }
        [Required(ErrorMessage = "Campo obrigatório"), MaxLength(100)]
        public string AlternativaB { get; set; }
        [Required(ErrorMessage = "Campo obrigatório"), MaxLength(100)]
        public string AlternativaC { get; set; }
        [Required(ErrorMessage = "Campo obrigatório"), MaxLength(100)]
        public string AlternativaD { get; set; }
        [Required(ErrorMessage = "Campo obrigatório"), MaxLength(100)]
        public string AlternativaE { get; set; }
        [Required(ErrorMessage = "Campo obrigatório"), MaxLength(100)]
        public string Correta { get; set; }


        public int QuestaoId { get; set; }
    }
}
