using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizaPortifolio.Domain.Interfaces
{
    // Interface para categorização
    public interface ITradeCategory
    {
        bool IsMatch(ITrade trade, DateTime referenceDate);
        string CategoryName { get; }
    }
}
