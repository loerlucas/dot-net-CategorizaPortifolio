using CategorizaPortifolio.Domain.Interfaces;
using CategorizaPortifolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizaPortifolio.Services
{
    public class InputReader
    {
        public DateTime ReadReferenceDate()
        {
            Console.WriteLine("Enter the reference date (MM/dd/yyyy):");
            return DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public List<ITrade> ReadTrades()
        {
            Console.WriteLine("Enter the number of trades:");
            int n = int.Parse(Console.ReadLine());

            var trades = new List<ITrade>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter trade {i + 1} (Value Sector NextPaymentDate):");
                string[] input = Console.ReadLine().Split(' ');
                double value = double.Parse(input[0], CultureInfo.InvariantCulture);
                string sector = input[1];
                DateTime nextPaymentDate = DateTime.Parse(input[2], CultureInfo.InvariantCulture);
                trades.Add(new Trade(value, sector, nextPaymentDate));
            }

            return trades;
        }
    }
}
