using System;
using System.Globalization;

namespace DateSystem
{
    public static class DateMethods
    {
        public static void UtcLocal(string option01)
        {
            switch (option01)
            {
                case "br":
                    {
                        UtcGenerator("Brasil", "pt-BR");
                        break;
                    }
                case "pt":
                    {
                        UtcGenerator("Portugal", "pt-PT");
                        break;
                    }
                case "us":
                    {
                        UtcGenerator("Estados Unidos", "en-US");
                        break;
                    }
                case "de":
                    {
                        UtcGenerator("Dinamarca", "de-De");
                        break;
                    }
                default: Menu.MenuOption01(); break;
            }
        }

        public static void UtcGenerator(string country, string countryCode)
        {
            Console.Clear();

            Console.WriteLine($"O UTC (padrão) agora em {country} é: ");
            Console.WriteLine(DateTime.Now.ToString("D", new CultureInfo(countryCode)));

            Console.ReadKey();
            Menu.Show();
        }

        public static void LocalMahcineDate()
        {
            Console.Clear();

            var dataLocal = DateTime.Now;

            Console.WriteLine($"A data local da sua máquina é: {dataLocal.ToString("D")}.");

            Console.ReadKey();
            Menu.Show();
        }

        public static void TimeZonesGenerator()
        {
            Console.Clear();

            var utcDate = DateTime.UtcNow;
            var timeZones = TimeZoneInfo.GetSystemTimeZones();

            foreach (var timezone in timeZones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("----------------------");
            }

            Console.ReadKey();
            Menu.Show();
        }

        public static void MonthDaysCheck(int year, int month)
        {
            Console.Clear();
            var monthDays = DateTime.DaysInMonth(year, month);

            Console.WriteLine($"O mês {month} no ano {year} possui: {monthDays} dias.");

            Console.ReadKey();
            Menu.Show();
        }
    }
}