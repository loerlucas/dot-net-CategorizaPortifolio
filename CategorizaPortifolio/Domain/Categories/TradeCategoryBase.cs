using CategorizaPortifolio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizaPortifolio.Domain.Categories
{
    // Implementação base para categorias
    public abstract class TradeCategoryBase : ITradeCategory
    {
        public abstract string CategoryName { get; }
        public abstract bool IsMatch(ITrade trade, DateTime referenceDate);
    }
}
