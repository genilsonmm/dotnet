namespace PrimeiroProjeto
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }

        public int Idade { get; private set; }

        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Sobrenome = sobrenome;
        }

        public string NomeCompleto() => Nome + " " + Sobrenome;

    }
}