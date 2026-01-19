using System.ComponentModel.DataAnnotations;

namespace CryptoTrends.Models
{
    public class CryptoCurrency
    {
        public int Id { get; set; }

        [Required]
        public string Symbol { get; set; }   // BTC, ETH

        [Required]
        public string Name { get; set; }     // Bitcoin, Ethereum
    }
}
