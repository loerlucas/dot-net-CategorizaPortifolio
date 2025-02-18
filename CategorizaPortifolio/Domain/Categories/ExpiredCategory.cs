using CategorizaPortifolio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizaPortifolio.Domain.Categories
{
    public class ExpiredCategory : TradeCategoryBase
    {
        public override string CategoryName => "EXPIRED";
        public override bool IsMatch(ITrade trade, DateTime referenceDate) =>
            (referenceDate - trade.NextPaymentDate).Days > 30;
    }
}
