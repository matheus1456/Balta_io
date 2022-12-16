using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        //FUNÇÃO PARA APARECER O EDITOR (CHAMA A FUNÇÃO STARTMODE())
        public static void EditorShow()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            StartMode();
        }

        //FUNÇÃO PARA INICIALIZAÇÃO DO MODO EDITOR (CHAMANDO A FUNÇÃO VIEWER.SHOW())
        public static void StartMode()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-------------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            Viewer.Show(file.ToString());
        }
    }
}