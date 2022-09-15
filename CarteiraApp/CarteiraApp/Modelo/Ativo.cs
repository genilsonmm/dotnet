namespace CarteiraApp.Modelo
{
    public class Ativo
    {
        public string Id { get; }
        public string Codigo { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCompra { get; set; }

        public Ativo(string codigo, int quantidade, decimal preco, DateTime dataCompra)
        {
            Id = DateTime.Now.Ticks.ToString().Substring(14);
            Codigo = codigo;
            Quantidade = quantidade;
            Preco = preco;
            DataCompra = dataCompra;
        }

        public override string ToString()
        {
            return $"Id: {Id} | Quantidade: {Quantidade} | Preço: {Preco} | Data da compra: {DataCompra}";
        }
    }
}
