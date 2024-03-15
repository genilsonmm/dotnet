using Agendamento.Interfaces;

namespace Agendamento.Model
{
    public class Usuario : Pessoa, IPessoa
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public string Exibir()
        {
            return $"Nome: {base.Nome} | {Email}";
        }
    }
}
