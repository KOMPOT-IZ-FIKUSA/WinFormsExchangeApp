using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleksei_Spiridonov_OOP_Final_Project
{

    class Currency
    {
        public string name;
        public string country;
        public double value;
        public Currency(string name, string country, double value)
        {
            this.name = name;
            this.country = country;
            this.value = value;
        }
    }

    internal class CurrencyStorageAccess
    {
        private static Currency[] currencies = { };


        public static Action UpdateEvent = () => { };

        public static void SaveData()
        {
            using (StreamWriter writer = new StreamWriter("Rates.txt"))
            {
                foreach (Currency currency in currencies)
                {
                    writer.WriteLine(currency.country);
                    writer.WriteLine(currency.name);
                    writer.WriteLine(currency.value.ToString());
                }

            }
        }
        public static void LoadData()
        {

            currencies = new Currency[0];
            try
            {
                using (StreamReader reader = new StreamReader("Rates.txt"))
                {
                    while (true)
                    {
                        Currency? currency = readCurrencyFromThreeLines(reader);
                        if (currency != null)
                        {
                            AddCurrency(currency);
                        }
                        else if (reader.EndOfStream)
                        {
                            UpdateEvent();
                            return;
                        }
                    }

                }

            }
            catch (FileNotFoundException ex)
            {
                currencies = new Currency[0];
            }
            UpdateEvent();
        }

        private static Currency? readCurrencyFromThreeLines(StreamReader reader)
        {
            try
            {
                string country = reader.ReadLine();
                string name = reader.ReadLine();
                double value = double.Parse(reader.ReadLine());
                return new Currency(name, country, value);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Adds currency object to the array by extending the array (provdes list functionality)
        /// </summary>
        public static void AddCurrency(Currency currency)
        {
            Currency[] oldCurrencies = currencies;
            currencies = new Currency[oldCurrencies.Length + 1];
            System.Array.Copy(oldCurrencies, currencies, oldCurrencies.Length);
            currencies[currencies.Length - 1] = currency;
            UpdateEvent();
        }

        public static Currency GetCurrency(int index)
        {
            return currencies[index];
        }

        public static int? GetCurrencyIndexByName(string? name)
        {
            for (int i = 0; i < currencies.Length; i++)
            {
                if (currencies[i].name == name)
                {
                    return i;
                }
            }
            return null;
        }

        public static int GetAvailableCurrenciesCount()
        {
            return currencies.Length;
        }

        public static void RemoveCurrency(string name)
        {
            for (int i = 0; i < currencies.Length; i++)
            {
                if (currencies[i].name == name)
                {
                    RemoveCurrency(i);
                    return;
                }
            }
        }

        public static void RemoveCurrency(int index)
        {
            Currency[] oldCurrerencies = currencies;
            currencies = new Currency[currencies.Length - 1];
            for (int i = 0; i < currencies.Length; i++)
            {
                if (i >= index)
                {
                    currencies[i] = oldCurrerencies[i + 1];
                }
                else
                {
                    currencies[i] = oldCurrerencies[i];
                }
            }
            UpdateEvent();
        }

        public static Currency? GetCurrencyByName(string name)
        {
            foreach (Currency currency in currencies)
            {
                if (currency.name == name) { return currency; }
            }
            return null;
        }
    }
}
