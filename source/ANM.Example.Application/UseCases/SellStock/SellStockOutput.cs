﻿using System;
using ANM.Core.Application.Abstractions.UseCase;
using ANM.Example.Domain.Stocks;

namespace ANM.Example.Application.UseCases.SellStock
{
    public sealed class SellStockOutput : IUseCaseOutput
    {
        internal SellStockOutput(Stock stock)
        {
            this.Id = stock.StockId;
            this.Ticker = stock.Ticker;
            this.Quantity = stock.Quantity;
            this.Amount = stock.Amount;
        }

        public string Id { get; }
        public string Ticker { get; }
        public int Quantity { get; }
        public double Amount { get; }
    }
}
