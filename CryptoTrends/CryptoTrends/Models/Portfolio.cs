using Microsoft.AspNetCore.Identity;
using CryptoTrends.Models;

namespace CryptoTrends.Models
{
    public class Portfolio
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        public ICollection<PortfolioAsset> Assets { get; set; }
    }
}
