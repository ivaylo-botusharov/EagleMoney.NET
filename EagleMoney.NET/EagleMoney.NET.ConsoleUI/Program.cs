﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EagleMoney.NET.Library;

namespace EagleMoney.NET.ConsoleUI
{
    internal class Program
    {
        private static void Main()
        {
            var m1 = new Money(120M, new Currency(Currency.USD));

            Console.WriteLine($"m1.ToString(): {m1}");
            Console.WriteLine($"m1.Amount: {m1.Amount}");
            Console.WriteLine($"m1.Currency: {m1.Currency}");

            var m2 = new Money(120M, Currency.USD);

            Console.WriteLine($"Are m1 and m2 equal: {m1.Equals(m2)}");
            Console.WriteLine($"Is m1 equal to null: {m1.Equals(null)}");
            Console.WriteLine($"Is m2 equal to 'gosho': {m1.Equals("gosho")}");
            Console.WriteLine($"Is m2 equal to 5: {m1.Equals(5)}");

            int? nullableVar = 14;
            Console.WriteLine($"Is m2 equal to nullableVar: {m1.Equals(nullableVar)}");

            Console.WriteLine($"m1 == m2: {m1 == m2}");
            Console.WriteLine($"m1 == m1: {m1 == m1}");
            Console.WriteLine($"m1 != m2: {m1 != m2}");

            Money? m3 = null;
            Money? m4 = null;

            //Console.WriteLine($"m3.Equals(m4): {m3.Equals(m4)}");
            Console.WriteLine($"m3 == m4: {m3 == m4}");
            Console.WriteLine($"(object)null == (object)null: {(object) null == (object) null}");

            Money? m5 = null;
            Money m6 = new Money(65M, Currency.BGN);

            //Console.WriteLine($"m5.Equals(m5): {m5.Equals(m5)}");

            Console.WriteLine($"m6 == m5: {m6 == m5}");
            Console.WriteLine($"m5 == m6: {m5 == m6}");
            Console.WriteLine($"m5 != m6: {m5 != m6}");

            if (m5 is Money otherMoney1)
            {
                Console.WriteLine($"otherMoney: {otherMoney1}");
            }

            Console.WriteLine($"m5 is Money anotherMoney1: {m5 is Money anotherMoney1}");

            if (m6 is Money otherMoney2)
            {
                Console.WriteLine($"otherMoney2: {otherMoney2}");
            }

            Console.WriteLine($"m6 is Money anotherMoney2: {m6 is Money anotherMoney2}");

            var m7 = new Money(42, Currency.EUR);
            Money? m8 = new Money(42, Currency.EUR);
            Console.WriteLine($"m7.Equals(m8): {m7.Equals(m8)}");

            Money? m9 = null;
            Money? m10 = new Money(143, Currency.EUR);
            //Console.WriteLine($"m9.Equals(m10): {m9.Equals(m10)}");

            var m11 = new Money(470, Currency.EUR);
            var m12 = new Money(140, Currency.EUR);
            Console.WriteLine($"m11 > m12: {m11 > m12}");
            Console.WriteLine($"m11 >= m12: {m11 >= m12}");
            Console.WriteLine($"m11 < m12: {m11 < m12}");
            Console.WriteLine($"m11 <= m12: {m11 <= m12}");

            // Money m13 = null;
            // var m14 = new Money(140, Currency.EUR);
            // Console.WriteLine($"m13 > m14: {m13 > m14}");
            // Console.WriteLine($"m14 > m13: {m14 > m13}");
            // Console.WriteLine($"m13 > m13: {m13 > m13}");
            // Console.WriteLine($"m13 == m13: {m13 == m13}");

            var m15 = new Money(30, Currency.EUR);
            Money? m16 = new Money(70, Currency.EUR);
            Console.WriteLine($"m15 > m16: {m15 > m16}");
            Console.WriteLine($"m15 < m16: {m15 < m16}");

            var m17 = new Money(30.5M, Currency.EUR);
            var m18 = new Money(70, Currency.EUR);
            var m19 = m17 + m18;
            Console.WriteLine($"m19 = m17 + m18: {m19}");

            m19 += 10;
            Console.WriteLine($"m19 += 10: {m19}");

            var m20 = m19 + 10;
            Console.WriteLine($"m20 = m19 + 10: {m20}");

            var m21 = new Money(20.5M, Currency.BGN);
            var m22 = new Money(3M, Currency.BGN);
            var m23 = m21 * m22;
            Console.WriteLine($"m23 = m21 * m22: {m23}");

            var m24 = new Money(48.9M, Currency.BGN);
            var m25 = new Money(3M, Currency.BGN);
            var m26 = m24 / m25;
            Console.WriteLine($"m26 = m24 / m25: {m26}");

            var m27 = m24 / 3;
            Console.WriteLine($"m27 = m24 / 3: {m27}");

            var m28 = 90 / m25;
            Console.WriteLine($"m28 = 90 / m25: {m28}");

            var m29 = new Money(3M, Currency.BGN);
            var m30 = 100 / m29;
            Console.WriteLine($"m30 = 100 / m29: {m30}");

            var m30MoneyValue = (decimal) m30;
            Console.WriteLine($"m30MoneyValue = (decimal) m30: {m30MoneyValue}");

            // var m31 = new Money();
            // Console.WriteLine($"m31.ToString(): {m31.ToString()}");

            var m32 = new Money(5.5M, Currency.BGN);
            var m33 = m32 % 2;
            Console.WriteLine($"m33 = m32 % 3: {m33}");
            Console.WriteLine($"5.5M % 2: {5.5M % 2}");

            m33++;
            Console.WriteLine($"m33++: {m33}");
            Console.WriteLine($"m33++: {m33++}");
            Console.WriteLine($"++m33: {++m33}");
            Console.WriteLine($"m33 > 0: {m33 > 0}");
            Console.WriteLine($"m33 < 0: {m33 < 0}");
            Console.WriteLine($"m33 == 0: {m33 == 0}");
            Console.WriteLine($"0 == m33: {0 == m33}");

            var n1 = new Money(1M, Currency.BGN);

            Console.WriteLine($"n1 == 1: {n1 == 1}");
            Console.WriteLine($"1 == n1: {1 == n1}");
            
            Console.WriteLine($"n1 < 2: {n1 < 2}");
            Console.WriteLine($"2 > n1: {2 > n1}");
            
            Console.WriteLine($"n1 > 2: {n1 > 2}");
            Console.WriteLine($"2 < n1: {2 < n1}");
            
            Console.WriteLine($"n1 >= 2: {n1 >= 2}");
            Console.WriteLine($"n1 <= 2: {n1 <= 2}");
            
            Console.WriteLine($"n1 >= 1: {n1 >= 1}");
            Console.WriteLine($"n1 <= 1: {n1 <= 1}");
            
            Console.WriteLine($"1 >= n1: {1 >= n1}");
            Console.WriteLine($"1 <= n1: {1 <= n1}");

            var m33Casted = (decimal) m33;
            Console.WriteLine($"(decimal) m33: {m33Casted}");

            var emptyList = new List<int>();
            Console.WriteLine($"Is m2 equal to emptyList: {m1.Equals(emptyList)}");

            List<int> nullList = null;
            Console.WriteLine($"Is m2 equal to nullList: {m1.Equals(nullList)}");

            Console.WriteLine($"m1.GetHashCode(): {m1.GetHashCode()}");
            Console.WriteLine($"m1.GetHashCode(): {m1.GetHashCode()}");

            Console.WriteLine($"m2.GetHashCode(): {m2.GetHashCode()}");
            Console.WriteLine($"m2.GetHashCode(): {m2.GetHashCode()}");

            Console.WriteLine($"Are m1 and m2 Hash Codes equal: {m1.GetHashCode() == m2.GetHashCode()}");

            var searchedMoney = new Money(10M, Currency.BGN);

            var moneyList = new List<Money>
            {
                new(10M, Currency.EUR),
                new(10M, Currency.BGN),
                new(15.5M, Currency.BGN),
                new(120.50M, Currency.BGN),
                new(10M, Currency.BGN)
            };

            var moneyExists = moneyList.Contains(searchedMoney);

            Console.WriteLine($"moneyList.Contains(searchedMoney): {moneyExists}");

            var indexOfSearchedMoney = moneyList.IndexOf(searchedMoney);
            Console.WriteLine($"moneyList.IndexOf(searchedMoney): {indexOfSearchedMoney}");

            var lastIndexOfSearchedMoney = moneyList.LastIndexOf(searchedMoney);
            Console.WriteLine($"moneyList.IndexOf(searchedMoney): {lastIndexOfSearchedMoney}");

            var m34 = new Money(10M, Currency.BGN);

            // var dict4 = new Dictionary<Money, string>()
            // {
            //     { m34, "John"},
            //     { m34, "John"}
            // };

            //dict.Add(new Money(10M, CurrencyCode.Bgn), "Gosho");

            var dict = new Dictionary<Money, string>
            {
                [m34] = "John",
                [m34] = "John"
            };

            var containsMoneyKey = dict.ContainsKey(m34);

            Console.WriteLine($"dict.ContainsKey(new Money(10, CurrencyCode.BGN)):{containsMoneyKey}");
            Console.WriteLine($"dict.Count:{dict.Count}");

            var dict2 = new Dictionary<Money, string>
            {
                {new Money(10M, Currency.BGN), "Mike"},
                {new Money(15M, Currency.BGN), "John"},
                {new Money(25.5M, Currency.BGN), "Lisa"}
            };

            var containsMoneyKey2 = dict2.ContainsKey(new Money(15M, Currency.BGN));
            Console.WriteLine($"dict2.ContainsKey(new Money(15M, CurrencyCode.BGN)):{containsMoneyKey2}");

            var containsMoneyKey3 = dict2.ContainsKey(new Money(41.5M, Currency.BGN));
            Console.WriteLine($"dict2.ContainsKey(new Money(41.5M, CurrencyCode.BGN)):{containsMoneyKey3}");

            var containsMoneyKey4 = dict2.ContainsKey(new Money(10M, Currency.USD));
            Console.WriteLine($"dict2.ContainsKey(new Money(10M, CurrencyCode.USD)):{containsMoneyKey4}");

            //var m35 = new Money(-4.5M, CurrencyCode.BGN);
            
            // var m36 = new Money(8.5M, CurrencyCode.BGN);
            // var m37 = new Money(4.5M, CurrencyCode.USD);
            //
            // Console.WriteLine($"m36 > m37: {m36 > m37}");

            // var moneyCollection = new MoneyCollection(CurrencyCode.USD)
            // {
            //     new Money(15.5M, CurrencyCode.EUR),
            //     new Money(40.5M, CurrencyCode.USD)
            // };

            var moneyCollection2 = new MoneyCollection(Currency.USD)
            {
                new(15.5M, Currency.USD), 
                new(40.5M, Currency.USD), 
                new(130.72M, Currency.USD)
            };

            // moneyCollection2.Add(new Money(130.72M, Currency.AED));


            foreach (var money in moneyCollection2)
            {
                Console.WriteLine(money.ToString());
            }

            Console.WriteLine("-----------");

            var moneyCollection3 = moneyCollection2.Where(m => m.Amount == 130.72M);

            foreach (var money in moneyCollection3)
            {
                Console.WriteLine(money.ToString());
            }

            Console.WriteLine($"Money.USD(24.5M).ToString():{Money.USD(24.5M)}");
            Console.WriteLine($"Money.EUR(24.5M).ToString():{Money.EUR(24.5M)}");
            Console.WriteLine($"Money.BGN(24.5M).ToString():{Money.BGN(24.5M)}");

            string c = Currency.USD;
            var e = new Currency(Currency.USD);
            Console.WriteLine($"new Currency(Currency.USD).ToString():{e}");

            var d = new Currency("EUR");
            Console.WriteLine($"new Currency(Currency.USD).ToString():{d}");

            var m40 = new Money(0.3M, Currency.BGN);

            Money[] allocated = m40.AllocateEven(3);

            foreach (var item in allocated)
            {
                Console.WriteLine($"allocated element: {item.Amount} {item.Currency.Code}");
            }

            Console.WriteLine("----------------------");
            
            var m41 = new Money(0.5M, Currency.BGN);

            Money[] allocated2 = m41.AllocateEven(3);

            foreach (var item in allocated2)
            {
                Console.WriteLine($"allocated element: {item.Amount} {item.Currency.Code}");
            }
            
            Console.WriteLine("----------------------");
            
            var m42 = new Money(0.05M, Currency.BGN);

            Money[] allocated3 = m42.AllocateEven(3);

            foreach (var item in allocated3)
            {
                Console.WriteLine($"allocated element: {item.Amount} {item.Currency.Code}");
            }

            var m43 = new Money(12.45M, new Currency("Bitcoin", 2, "‡", "Bitcoin"));

            Console.WriteLine($"m43 (custom currency): {m43}");
            
            var m44 = new Money(15M, new Currency("Bitcoin", 2, "‡", "Bitcoin"));

            var m45 = m43 + m44;

            Console.WriteLine($"Adding custom currencies (m43 + m44):{m45.Amount} {m45.Currency.Code}");

            int[] allocation = {3, 10, 1, 4, 3};

            Money[] allocatedByRatios = Money.USD(100M).AllocateByRatios(allocation);

            for (int i = 0; i < allocatedByRatios.Length; i++)
            {
                Console.WriteLine($"Allocated by ratio {i}: {allocatedByRatios[i].Amount} {allocatedByRatios[i].Currency.Code}");
            }

            var m46 = Money.USD(10M);
            var m47 = m46.Percentage(20);
            Console.WriteLine($"m46.Percentage(20): {m47.Amount} {m47.Currency.Code}");
            
            m47 = m46.Percentage(21.5M);
            Console.WriteLine($"m46.Percentage(20): {m47.Amount} {m47.Currency.Code}");
            
            var m48 = new Money(3.445446M, MidpointRounding.AwayFromZero, Currency.USD);
            Console.WriteLine($"m48 - MidpointRounding.AwayFromZero: {m48.Amount} {m48.Currency.Code}");

            var m49 = new Money(124.5M, new Currency("AFN"));

            Console.WriteLine(m49);
            
            var m51 = Money.BGN(380.52M, MidpointRounding.AwayFromZero);

            Console.WriteLine(m51);

            var m52 = Money.USD(124.43M);

            Console.WriteLine(m51 == m52);

            // var m53 = Money.USD(79228162514264337593543950335M);
            
            // var m53 = Money.USD(Decimal.MaxValue / 99);

            var m54 = new Money(124.5M, new Currency("EUR"));

            foreach (var x in m54.Currency.Countries)
            {
                Console.WriteLine(x);
            }

            var m55 = new Money(12.3M, Currency.AFN);

            Console.WriteLine($"{m55.Amount} {m55.Currency}");
            
            Console.WriteLine("Currency Symbol: {0}",
                NumberFormatInfo.GetInstance(new CultureInfo("en-GB")).CurrencySymbol);
            
            // Gets a NumberFormatInfo associated with the en-US culture.
            NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;

            // Displays a negative value with the default number of decimal digits (2).
            Int64 myInt = -1234;
            Console.WriteLine( myInt.ToString( "C", nfi ) );

            // Displays the same value with four decimal digits.
            nfi.CurrencyDecimalDigits = 4;
            Console.WriteLine( myInt.ToString( "C", nfi ) );
            
            // CultureInfo[] custom = CultureInfo.GetCultures(CultureTypes.UserCustomCulture);
            // if (custom.Length == 0) {
            //     Console.WriteLine("There are no user-defined custom cultures.");
            // }
            // else {
            //     Console.WriteLine("Custom cultures:");
            //     foreach (var culture in custom)
            //         Console.WriteLine("   {0} -- {1}", culture.Name, culture.DisplayName);
            // }
            //
            // CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            //
            // foreach (var ci in cultures)
            // {
            //     Console.WriteLine($"{ci.Name} - {ci.DisplayName}");
            // }

            string symbol;
            var currencyProvider = new CurrencyProvider();
            
            bool symbolExists = currencyProvider.TryGetCurrencySymbol("USD", out symbol);
            
            bool symbolExists2 = currencyProvider.TryGetCurrencySymbol("USD", out symbol);

            Console.WriteLine(symbol);

            string symbol2;
            if(new CurrencyProvider().TryGetCurrencySymbol("BGN", out symbol2))
            {
                Console.WriteLine("symbol2 is {0}", symbol2);
            }

            // foreach (var curr in CurrencyTools.CurrencyCodes)
            // {
            //     Console.WriteLine(curr);
            // }

            var m56 = Money.CAD(120m);

            Console.WriteLine(m56);

            var m57 = Money.SAR(15.25M);

            var m58 = Money.AOA(15.34M, MidpointRounding.ToZero);

            Console.WriteLine(m58);

            Console.WriteLine($"m58.ToString('C'): {m58.ToString("C")}");

            Money[] allocatedEven = m58.AllocateEven(5);

            foreach (var ae in allocatedEven)
            {
                Console.WriteLine($"{ae.Amount} { ae.Currency.Symbol} {ae.Currency.Code}");
            }

            foreach (var ab in allocatedEven)
            {
                Console.WriteLine(ab.ToString("C"));
            }

            var m59 = Money.USD(12.34m);
            Console.WriteLine(m59.ToString("C"));
            
            var m60 = Money.EUR(40.15M);
            Console.WriteLine(m60.ToString("C"));
            
            var m61 = Money.GBP(72.13m);
            Console.WriteLine(m61.ToString("C"));
            
            var m62 = Money.BGN(83.95m);
            Console.WriteLine(m62.ToString("C"));
            
            var m63 = Money.CHF(100000.23m);
            Console.WriteLine(m63.ToString("C"));
            
            var m64 = Money.AFN(125.34m);
            Console.WriteLine(m64.ToString("C"));
            
            var m65 = Money.USD(1234.56m);
            Console.WriteLine(m65);
            
            var m66 = Money.USD(432100000009.24m);
            Console.WriteLine($"{m66.Amount} {m66.Currency.Symbol}");

            Console.WriteLine($"{(m66 + 0.01m).Amount}");

            var m67 = new Money(12.45m, Currency.BGN);

            var m68 = Money.MKD(12.45m);

            Console.WriteLine(m68);
            Console.WriteLine(m68.ToString("C"));
            
            var m69 = Money.BGN(12.45m);
            Console.WriteLine(m69.ToString("C"));

            var m70 = Money.Parse("678.423", Currency.BGN);

            Console.WriteLine(m70);
            Console.WriteLine(m70.ToString("C"));

            IMoney m71 = new Money(12.456m, Currency.AED);

            Console.WriteLine(m71);
            
            var m72 = new Money(
                14.32m,
                new Currency(
                    "GAC", 
                    new CurrencyFactory(new CustomCurrencyProvider(), new CustomCountriesProvider())));

            Console.WriteLine(m72);
            
            Console.WriteLine(m72.ToString("C"));

            var m73 = Money.USD(15.43M);

            foreach (var ca in m73.Currency.Countries)
            {
                Console.WriteLine($"{ca.Name} {ca.CodeAlpha2} {ca.CodeAlpha3}");
            }

            var m74 = new Money(14.2m, CountryCode.US);

            Console.WriteLine(m74);
            Console.WriteLine(m74.ToString("C"));

            var m75 = new Money(156.5m, CountryCodeAlpha3.USA);

            foreach (var country in m75.Currency.Countries)
            {
                Console.WriteLine($"currencyCountry: {country.Name}");
            }
        }
    }
    
    public struct CustomCurrencyProvider : ICurrencyProvider
    {
        public IEnumerable<CurrencyCountriesBasicInfo> GetCurrencies()
        {
            return new List<CurrencyCountriesBasicInfo>
            {
                new CurrencyCountriesBasicInfo("GAC", "","321", "^", 2, new HashSet<string>
                {
                    "Bulgaria",
                    "Tanzania"
                })
            };
        }
    }
    
    public struct CustomCountriesProvider : ICountryProvider
    {
        public IEnumerable<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country
                {
                    Name = "Bulgaria",
                    CodeAlpha2 = "DA",
                    CodeAlpha3 = "DAS",
                    NumericCode = "005"
                }
            };
        }
    }
}