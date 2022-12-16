using System;

namespace EditorHtml
{
    public static class Menu
    {
        //FUNÇÃO PRINCIPAL
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            DrawScreen();
            MenuOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        //FUNÇÃO PARA DESENHAR O CADRO
        public static void DrawScreen()
        {
            MainScope("+", "-");
            MiddleLine();
            MainScope("+", "-");
        }

        //FUNÇÃO PARA DESENHAR O ESCOPO PADRÃO DO QUADRO
        public static void MainScope(string first, string second)
        {
            Console.Write(first);

            for (int i = 0; i <= 30; i++)
                Console.Write(second);

            Console.Write(first);
            Console.Write("\n");
        }

        //FUNÇÃO PARA DESENHAR AS LINHAS CENTRAIS DO QUADRO
        public static void MiddleLine()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                MainScope("|", " ");
            }
        }

        //FUNÇÃO PARA ESCREVER AS OPÇÕES DO MENU
        public static void MenuOptions()
        {
            WriteOption(3, 2, "Editor HTML");
            WriteOption(3, 3, "===========");
            WriteOption(3, 4, "Selecione uma opção abaixo:");
            WriteOption(3, 6, "1 - Novo arquivo");
            WriteOption(3, 7, "2 - Abrir arquivo");
            WriteOption(3, 9, "0 - Sair do Programa");
            WriteOption(3, 10, "Opção: ");
        }

        //FUNÇÃO PRINCIPAL DE ESCRITA DAS OPÇÕES (MODELO PADRÃO)
        public static void WriteOption(short left, short top, string text)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(text);
        }

        //MANIPULADOR DAS OPÇÕES DO MENU (ESTÁ VINCULADA AO ARQUIVO EDITOR.CS)
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.EditorShow(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Console.WriteLine("A aplicação foi encerrada...");
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}