using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_1_КОРОТИЧ_МАКСИМ
{
    class Converter
    {
        private readonly double UsdToUah;
        private readonly double EurToUah;
        private readonly double PlnToUah;

        public Converter(double usd, double eur, double pln)
        {
            UsdToUah = usd;
            EurToUah = eur;
            PlnToUah = pln;
        }

        public double ConvertFromUah(double amount, string currency) =>
            currency switch
            {
                "usd" => amount / UsdToUah,
                "eur" => amount / EurToUah,
                "pln" => amount / PlnToUah,
                _ => throw new ArgumentException("Неправильна валюта. Доступні: usd, eur, pln."),
            };

        public double ConvertToUah(double amount, string currency) =>
            currency switch
            {
                "usd" => amount * UsdToUah,
                "eur" => amount * EurToUah,
                "pln" => amount * PlnToUah,
                _ => throw new ArgumentException("Неправильна валюта. Доступні: usd, eur, pln."),
            };
    }

    class Program
    {
        static void Main()
        {
            try
            {
                // Введення курсів валют
                Console.WriteLine("Введіть курс долара (USD) до гривні:");
                double usdRate = ReadDouble();

                Console.WriteLine("Введіть курс євро (EUR) до гривні:");
                double eurRate = ReadDouble();

                Console.WriteLine("Введіть курс злотого (PLN) до гривні:");
                double plnRate = ReadDouble();

                var converter = new Converter(usdRate, eurRate, plnRate);

                Console.WriteLine("Оберіть тип операції:");
                Console.WriteLine("1 - З гривні в іноземну валюту");
                Console.WriteLine("2 - З іноземної валюти в гривню");
                int operation = ReadInt();

                Console.WriteLine("Введіть кількість:");
                double amount = ReadDouble();

                Console.WriteLine("Введіть валюту (usd, eur, pln):");
                string currency = Console.ReadLine()?.Trim().ToLower();

                if (currency != "usd" && currency != "eur" && currency != "pln")
                {
                    Console.WriteLine("Неправильна валюта. Доступні: usd, eur, pln.");
                    return;
                }

                if (operation == 1)
                {
                    double result = converter.ConvertFromUah(amount, currency);
                    Console.WriteLine($"Результат: {amount} грн = {result:F2} {currency.ToUpper()}");
                }
                else if (operation == 2)
                {
                    double result = converter.ConvertToUah(amount, currency);
                    Console.WriteLine($"Результат: {amount} {currency.ToUpper()} = {result:F2} грн");
                }
                else
                {
                    Console.WriteLine("Неправильний вибір операції.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Натисніть Enter, щоб завершити програму.");
                Console.ReadLine();
            }
        }

        static double ReadDouble()
        {
            if (!double.TryParse(Console.ReadLine(), out double value))
            {
                Console.WriteLine("Неправильний формат числа. Спробуйте ще раз.");
                Environment.Exit(0); // Завершуємо програму
            }
            return value;
        }

        static int ReadInt()
        {
            if (!int.TryParse(Console.ReadLine(), out int value))
            {
                Console.WriteLine("Неправильний формат числа. Спробуйте ще раз.");
                Environment.Exit(0); // Завершуємо програму
            }
            return value;
        }
    }
}