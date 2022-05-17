using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CryptoManagement.Data.Model
{
    public class Coin
    {
        public int CoinId { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [Precision(18, 4)]
        public decimal Price { get; set; }
        public double Quantity { get; set; }
        public DateTime DateTime { get; set; }
    }
}
