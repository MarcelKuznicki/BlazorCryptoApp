using CryptoTrends.Client.Components.Pages;
using System.ComponentModel.DataAnnotations;

namespace CryptoTrends.Models
{
    public class PortfolioAsset
    {
        public int Id { get; set; }

        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }

        public int CryptoCurrencyId { get; set; }
        public CryptoCurrency CryptoCurrency { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

        public decimal BuyPrice { get; set; }
    }
}
