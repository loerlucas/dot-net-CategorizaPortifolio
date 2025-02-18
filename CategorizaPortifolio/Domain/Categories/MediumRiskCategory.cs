using CategorizaPortifolio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizaPortifolio.Domain.Categories
{
    public class MediumRiskCategory : TradeCategoryBase
    {
        public override string CategoryName => "MEDIUMRISK";
        public override bool IsMatch(ITrade trade, DateTime referenceDate) =>
            trade.Value > 1000000 && trade.ClientSector == "Public";
    }
}
