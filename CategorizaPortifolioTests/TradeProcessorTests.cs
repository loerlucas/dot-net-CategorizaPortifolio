using CategorizaPortifolio.Domain.Factories;
using CategorizaPortifolio.Domain.Interfaces;
using CategorizaPortifolio.Domain.Models;
using CategorizaPortifolio.Services;
using System.Diagnostics;
using Xunit;

namespace CategorizaPortifolioTests
{
    public class TradeProcessorTests
    {
        [Fact]
        public void ProcessTrades_ShouldReturnCorrectCategories()
        {
            // Arrange
            var factory = new TradeCategoryFactory();
            var processor = new TradeProcessor(factory);
            var referenceDate = new DateTime(2022, 10, 10);
            var trades = new List<ITrade>
        {
            new Trade(2000000, "Private", new DateTime(2025, 12, 29)),
            new Trade(400000, "Public", new DateTime(2020, 7, 1)),
            new Trade(5000000, "Public", new DateTime(2024, 1, 2)),
            new Trade(3000000, "Public", new DateTime(2023, 10, 26))
        };

            // Act
            var categories = processor.ProcessTrades(trades, referenceDate);

            // Assert
            Xunit.Assert.Equal("HIGHRISK", categories[0]);
            Xunit.Assert.Equal("EXPIRED", categories[1]);
            Xunit.Assert.Equal("MEDIUMRISK", categories[2]);
            Xunit.Assert.Equal("MEDIUMRISK", categories[3]);
        }
    }
}