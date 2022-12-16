using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(String[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir o arquivo");
            Console.WriteLine("2 - Criar um novo arquivo");
            Console.WriteLine("0 - Sair da Aplicação");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: OpenFile(); break;
                case 2: CreateFile(); break;
                default: Menu(); break;
            }
        }
        static void OpenFile()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo que você deseja abrir: ");
            Console.WriteLine("***************************************************");
            string path = Console.ReadLine();

            // Using - Abrir e Fechar o arquivo automaticamente
            using (var file = new StreamReader(path)) //StreamRead ler o caminho do arquivo
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void CreateFile()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair): ");
            Console.WriteLine("*****************************************");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            SaveFile(text);
        }

        static void SaveFile(string text)
        {
            Console.Clear();
            Console.WriteLine("DDigite o caminho / endereço para o arquivo ser salvo: ");
            var path = Console.ReadLine();

            //Abrir e fechar o arquivo
            using (var file = new StreamWriter(path)) //StreamWriter - Salvar o arquivo
            {
                file.Write(text);
            }

            Console.WriteLine($"O arquivo foi salvo com sucesso no endereço: {path}");
            Console.ReadLine();
            Menu();
        }

    }
}