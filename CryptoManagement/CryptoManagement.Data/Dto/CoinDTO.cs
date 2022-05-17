namespace CryptoManagement.Data.Dto
{
    public class CoinDTO
    {
        public int CoinId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Quantity { get; set; }
        public DateTime DateTime { get; set; }
    }
}
