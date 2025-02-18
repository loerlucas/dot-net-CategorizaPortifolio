using CategorizaPortifolio.Domain.Factories;
using CategorizaPortifolio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizaPortifolio.Services
{
    public class TradeProcessor
    {
        private readonly TradeCategoryFactory _categoryFactory;

        public TradeProcessor(TradeCategoryFactory categoryFactory)
        {
            _categoryFactory = categoryFactory;
        }

        public List<string> ProcessTrades(List<ITrade> trades, DateTime referenceDate)
        {
            return trades.Select(trade => _categoryFactory.Categorize(trade, referenceDate)).ToList();
        }
    }
}
