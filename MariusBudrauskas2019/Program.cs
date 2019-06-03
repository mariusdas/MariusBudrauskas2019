using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariusBudrauskas2019
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: Exchange <currency pair> <amount to exchange>");
                return;
            }

            var currencies = InitCurrencies();

            var currencyPair = args[0].ToUpper();

            int amountToExchange = 0;
            if(int.TryParse(args[1], out amountToExchange))
            {
                var findCurrency = currencies.Where(x => x.CurrencyPair == currencyPair).FirstOrDefault();
                if(findCurrency != null)
                {
                    double result = findCurrency.ExchangeRatio * amountToExchange;
                    Console.WriteLine(result);
                    return;
                }
                else
                {
                    Console.WriteLine("Currency in program do not exist!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Amount must be number value and integer type!");
                return;
            }
        }

        public static List<Currency> InitCurrencies()
        {
            var currencies = new List<Currency>();

            currencies.Add(new Currency() { CurrencyPair = "EUR/DKK", ExchangeRatio = 7.4394 });
            currencies.Add(new Currency() { CurrencyPair = "USD/DKK", ExchangeRatio = 6.6311 });
            currencies.Add(new Currency() { CurrencyPair = "GBP/DKK", ExchangeRatio = 8.5285 });
            currencies.Add(new Currency() { CurrencyPair = "SEK/DKK", ExchangeRatio = 0.7610 });
            currencies.Add(new Currency() { CurrencyPair = "NOK/DKK", ExchangeRatio = 0.7840 });
            currencies.Add(new Currency() { CurrencyPair = "CHF/DKK", ExchangeRatio = 6.8358 });
            currencies.Add(new Currency() { CurrencyPair = "JPY/DKK", ExchangeRatio = 0.059740 });

            currencies.Add(new Currency() { CurrencyPair = "EUR/USD", ExchangeRatio = Math.Round(7.4394 / 6.6311, 4) });
            currencies.Add(new Currency() { CurrencyPair = "USD/EUR", ExchangeRatio = Math.Round(1/(7.4394 / 6.6311), 4) });

            currencies.Add(new Currency() { CurrencyPair = "EUR/GBP", ExchangeRatio = Math.Round(7.4394 / 8.5285, 4) });
            currencies.Add(new Currency() { CurrencyPair = "GBP/EUR", ExchangeRatio = Math.Round(1 / (7.4394 / 8.5285), 4) });

            currencies.Add(new Currency() { CurrencyPair = "EUR/SEK", ExchangeRatio = Math.Round(7.4394 / 0.7610, 4) });
            currencies.Add(new Currency() { CurrencyPair = "SEK/EUR", ExchangeRatio = Math.Round(1/(7.4394 / 0.7610), 4) });

            currencies.Add(new Currency() { CurrencyPair = "EUR/NOK", ExchangeRatio = Math.Round(7.4394 / 0.7840, 4) });
            currencies.Add(new Currency() { CurrencyPair = "NOK/EUR", ExchangeRatio = Math.Round(1 / (7.4394 / 0.7840), 4) });

            currencies.Add(new Currency() { CurrencyPair = "EUR/CHF", ExchangeRatio = Math.Round(7.4394 / 6.8358, 4) });
            currencies.Add(new Currency() { CurrencyPair = "CHF/EUR", ExchangeRatio = Math.Round(1 / (7.4394 / 6.8358), 4) });

            currencies.Add(new Currency() { CurrencyPair = "EUR/JPY", ExchangeRatio = Math.Round(7.4394 / 0.059740, 4) });
            currencies.Add(new Currency() { CurrencyPair = "JPY/EUR", ExchangeRatio = Math.Round(1 / (7.4394 / 0.059740), 4) });

            return currencies;
        }
    }
}
