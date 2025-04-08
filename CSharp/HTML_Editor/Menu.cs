using System;
using System.Reflection.Metadata.Ecma335;

namespace HTML_Editor {
    public static class Menu {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        private static void DrawScreen() {
            DrawLine();
            DrawColumns();
            DrawLine();
        }

        private static void WriteOptions() {
            Console.SetCursorPosition(6, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(6, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(6, 4);
            Console.WriteLine("1 - New File");
            Console.SetCursorPosition(6, 5);
            Console.WriteLine("2 - Open File");
            Console.SetCursorPosition(6, 6);
            Console.WriteLine("0 - Exit");            
            Console.SetCursorPosition(6, 8);
            Console.Write("Choose an option: ");
        }

        private static void HandleMenuOption(short option) {
            switch (option) {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(""); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                    } 
                default: Show(); break;
            }
        }

       static void DrawLine(){
            Console.Write("+");
            for (int i = 0; i <= 30; i++) {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        static void DrawColumns(){
            for(int lines = 0; lines <= 10; lines++) {
                Console.Write("|");
                for (int i = 0; i <= 30; i++) {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}