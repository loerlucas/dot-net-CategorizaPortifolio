using CategorizaPortifolio.Domain.Factories;
using CategorizaPortifolio.Domain.Interfaces;
using CategorizaPortifolio.Domain.Models;
using CategorizaPortifolio.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


// Aplicação Console
class Program
{
    static void Main()
    {
        var inputReader = new InputReader();
        DateTime referenceDate = inputReader.ReadReferenceDate();
        List<ITrade> trades = inputReader.ReadTrades();

        var categoryFactory = new TradeCategoryFactory();
        var tradeProcessor = new TradeProcessor(categoryFactory);

        List<string> categories = tradeProcessor.ProcessTrades(trades, referenceDate);

        Console.WriteLine("Trade Categories:");
        foreach (var category in categories)
        {
            Console.WriteLine(category);
        }
    }
}