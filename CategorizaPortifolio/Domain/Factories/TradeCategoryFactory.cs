using CategorizaPortifolio.Domain.Categories;
using CategorizaPortifolio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizaPortifolio.Domain.Factories
{
    // Classe de fábrica para categorias
    public class TradeCategoryFactory
    {
        private readonly List<ITradeCategory> _categories;

        public TradeCategoryFactory()
        {
            _categories = new List<ITradeCategory>
        {
            new ExpiredCategory(),
            new HighRiskCategory(),
            new MediumRiskCategory()
        };
        }

        public string Categorize(ITrade trade, DateTime referenceDate)
        {
            return _categories.First(category => category.IsMatch(trade, referenceDate)).CategoryName;
        }
    }
}
