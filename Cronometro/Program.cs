using System;
using System.Threading;

namespace Cronometro
{
    class Program

    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("****** Menu Cronômetro ******");
            Console.WriteLine("*****************************");
            Console.WriteLine("");
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Digite quanto tempo você deseja contar: ");

            string data = Console.ReadLine().ToLower(); //.ToLower() - vai converter tudo para minúsculo

            //(método).Substring - serve para pegar uma parte da cadeia de caracter
            //método .Length - pega o total de carcteres (nesse caso vamos subtrair por 1 para trazer o último caracter)
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(1000);
            Menu();
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.Write("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!");
            Thread.Sleep(1000);

            Start(time);
        }

    }
}
