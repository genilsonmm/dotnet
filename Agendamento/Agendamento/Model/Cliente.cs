using Agendamento.Interfaces;

namespace Agendamento.Model
{
    public class Cliente : Pessoa, IPessoa
    {
        public Guid Id { get; set; }
        public string CPF { get; set; }

        public string Exibir()
        {
            return $"Nome: {base.Nome} | CPF: {CPF}";
        }
    }
}
