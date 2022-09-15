namespace LojaVirtualAPI.Model
{
    public class Produto
    {
        public string Lote { get; }
        public string Nome { get; set; }
        public int Quantidade { get; }
                
        public Produto(string lote, string nome, int quantidade)
        {
            Lote = lote;
            Nome = nome;
            Quantidade = quantidade;
        }
    }
}
