namespace AppGerenciamento
{
    internal class Pessoa
    {
        private string cpf;

        public string Temp
        {
            get
            {
                return cpf;
            }
            set 
            { 
                cpf = value; 
            }
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
