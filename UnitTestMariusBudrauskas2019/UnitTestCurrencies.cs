using System;
using System.Linq;
using MariusBudrauskas2019;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMariusBudrauskas2019
{
    [TestClass]
    public class UnitTestCurrencies
    {
        [TestMethod]
        public void CheckCurrenciesExchangeRatio()
        {
            var currencies = MariusBudrauskas2019.Program.InitCurrencies();
            var amountToExchange = 100;
            Currency currency = null;
           
            // EUR/DKK
            currency = currencies.Where(x => x.CurrencyPair == "EUR/DKK").FirstOrDefault();
            Assert.AreNotEqual(null, currency);
            Assert.AreEqual(743.94, Math.Round(amountToExchange * currency.ExchangeRatio, 2));

            // USD/DKK
            currency = currencies.Where(x => x.CurrencyPair == "USD/DKK").FirstOrDefault();
            Assert.AreNotEqual(null, currency);
            Assert.AreEqual(663.11, Math.Round(amountToExchange * currency.ExchangeRatio, 2));

            // GBP/DKK
            currency = currencies.Where(x => x.CurrencyPair == "GBP/DKK").FirstOrDefault();
            Assert.AreNotEqual(null, currency);
            Assert.AreEqual(852.85, Math.Round(amountToExchange * currency.ExchangeRatio, 2));

            // SEK/DKK
            currency = currencies.Where(x => x.CurrencyPair == "SEK/DKK").FirstOrDefault();
            Assert.AreNotEqual(null, currency);
            Assert.AreEqual(76.10, Math.Round(amountToExchange * currency.ExchangeRatio, 2));

            // NOK/DKK
            currency = currencies.Where(x => x.CurrencyPair == "NOK/DKK").FirstOrDefault();
            Assert.AreNotEqual(null, currency);
            Assert.AreEqual(78.40, Math.Round(amountToExchange * currency.ExchangeRatio, 2));

            // CHF/DKK
            currency = currencies.Where(x => x.CurrencyPair == "CHF/DKK").FirstOrDefault();
            Assert.AreNotEqual(null, currency);
            Assert.AreEqual(683.58, Math.Round(amountToExchange * currency.ExchangeRatio, 2));

            // CHF/DKK
            currency = currencies.Where(x => x.CurrencyPair == "JPY/DKK").FirstOrDefault();
            Assert.AreNotEqual(null, currency);
            Assert.AreEqual(5.9740, Math.Round(amountToExchange * currency.ExchangeRatio, 4));

            // EUR/USD
            currency = currencies.Where(x => x.CurrencyPair == "EUR/USD").FirstOrDefault();
            Assert.AreNotEqual(null, currency);
            Assert.AreEqual(112.19, Math.Round(amountToExchange * currency.ExchangeRatio, 2));

            // USD/EUR
            currency = currencies.Where(x => x.CurrencyPair == "USD/EUR").FirstOrDefault();
            Assert.AreNotEqual(null, currency);
            Assert.AreEqual(89.13, Math.Round(amountToExchange * currency.ExchangeRatio, 2));

        }
    }
}
