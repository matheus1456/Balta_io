using System;
using System.Threading;

namespace DateSystem
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Bem-vindo usuário!!!");
            Drawn();
            MainMenu();
        }

        public static void Drawn()
        {
            Console.WriteLine("|-----------------------------------------------|");

            for (int lines = 0; lines < 11; lines++)
                Console.WriteLine("|                                               |");

            Console.WriteLine("|-----------------------------------------------|");
        }

        public static void MainMenu()
        {
            WriteOption(3, 2, "DATE SYSTEM");
            WriteOption(3, 4, "Menu de Opções:");
            WriteOption(3, 5, "1 - Verificar UTC Local");
            WriteOption(3, 6, "2 - Verificar data atual da sua máquina");
            WriteOption(3, 7, "3 - Listar time zones ao redor do mundo");
            WriteOption(3, 8, "4 - Verificar quantos dias tem o ano/mês desejado");
            WriteOption(3, 9, "5 - Fechar Aplicação");
            WriteOption(3, 11, "Digite uma das opções acima: ");

            Console.SetCursorPosition(3, 12);
            var option = short.Parse(Console.ReadLine());
            HandleMainMenu(option);
        }

        public static void MenuOption01()
        {
            Console.Clear();
            Drawn();
            WriteOption(3, 1, "DATE SYSTEM");
            WriteOption(3, 3, "Menu de Opções:");
            WriteOption(3, 4, "br - Gerar UTC (padrão) do Brasil");
            WriteOption(3, 5, "us - Gerar UTC (padrão) dos Estados Unidos");
            WriteOption(3, 6, "de - Gerar UTC (padrão) da Dinamarca");
            WriteOption(3, 7, "pt - Gerar UTC (padrão) de Portugal");
            WriteOption(3, 8, "menu - Voltar para o menu principal");
            WriteOption(3, 10, "Digite uma das opções acima: ");

            Console.SetCursorPosition(32, 10);
            var option01 = Console.ReadLine().ToLower();
            DateMethods.UtcLocal(option01);
        }

        public static void WriteOption(short left, short top, string text)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(text);
        }

        public static void MenuOption04()
        {
            Console.Clear();
            Drawn();
            WriteOption(3, 1, "DATE SYSTEM");
            WriteOption(3, 3, "Menu de Opções:");
            WriteOption(3, 4, "Digite o ano desejado: ");
            WriteOption(3, 6, "(Exemplo ano: 2022, 2023, 2024...)");

            Console.SetCursorPosition(27, 4);
            var year = int.Parse(Console.ReadLine());

            Console.Clear();
            Drawn();
            WriteOption(3, 1, "DATE SYSTEM");
            WriteOption(3, 3, "Menu de Opções:");
            WriteOption(3, 4, "Digite o número do mês desejado: ");
            WriteOption(3, 6, "(Exemplo ano: 1-Jan, 2-Fev, 3-Mar...)");

            Console.SetCursorPosition(36, 4);
            var month = int.Parse(Console.ReadLine());

            DateMethods.MonthDaysCheck(year, month);
        }

        public static void HandleMainMenu(short option)
        {
            switch (option)
            {
                case 1: MenuOption01(); break;
                case 2: DateMethods.LocalMahcineDate(); break;
                case 3: DateMethods.TimeZonesGenerator(); break;
                case 4: MenuOption04(); break;
                case 5:
                    {
                        Console.Clear();
                        Console.WriteLine("A aplicação está sendo encerrada em...");
                        MiniCounter();
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
            }
        }

        public static void MiniCounter()
        {
            short currentTime = 4;

            while (currentTime != 1)
            {
                currentTime--;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Encerrando...");
            Thread.Sleep(1000);
        }
    }
}
