using System;
using System.Text;

namespace HTML_Editor {
    public static class Editor {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("--------------------");
            Start();
        }

        public static void Start() {
            var file = new StringBuilder();

            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("--------------------");
            Console.WriteLine("Do you want to save the file? Y/N");
            var option = Console.ReadKey();
            if (option.KeyChar == 'Y' || option.KeyChar == 'y') {
                Console.WriteLine("Enter the file name: ");
                var fileName = Console.ReadLine();
                Save(file.ToString(), fileName);
            }
            else {
                Menu.Show();
            }
        }

        public static void Save(string text, string fileName) {
            var path = $"g:/programacao/balta/Csharp/HTML_Editor/{fileName}.html";
            using var file = new System.IO.StreamWriter(path);
            file.Write(text);

            Console.WriteLine($"File {fileName} saved successfully at {path}");
            Console.ReadLine();
            Menu.Show();
        }
    }
}