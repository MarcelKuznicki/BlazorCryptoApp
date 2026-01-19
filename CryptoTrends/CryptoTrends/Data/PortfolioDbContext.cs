using CryptoTrends.Client.Components.Pages;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CryptoTrends.Models;

namespace CryptoTrends.Data
{
    // Inherit from DbContext to satisfy the generic constraint for DbContextOptions<TContext>
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioAsset> PortfolioAssets { get; set; }
        public DbSet<CryptoCurrency> CryptoCurrencies { get; set; }
    }
}
