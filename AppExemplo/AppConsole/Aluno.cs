namespace AppConsole
{
    public class Aluno
    {
        public string Nome { get; set;} 
        public string Cpf { get; set;}
        public int Idade { get; set; }

        private string endereco;

        public string Endereco
        {
            get
            {
                //Fazer alguma coisa
                return endereco;
            }
            set
            {
                string temp = value;
                //Fazer alguma coisa
                endereco = temp;
            }
        }

        public Aluno(string nome, string cpf, int idade)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Idade = idade;
        }

        public Aluno()
        {
            
        }

        public bool Matriculado() => true;

        public override string ToString()
        {
            return "Nome: " + Nome + " | CPF: " + Cpf + " | Idade: " + Idade;
        }
    }
}
