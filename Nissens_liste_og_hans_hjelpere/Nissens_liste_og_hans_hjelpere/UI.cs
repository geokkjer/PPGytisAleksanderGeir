using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nissens_liste_og_hans_hjelpere
{
    internal static class UI
    {
        private static List<string> CenterOptionText(int width, string[] options)
        {
            List<string> CenteredMenuOptions = new List<string>();

            foreach (string option in options)
            {
                int flankWidth = (width - option.Length) / 2;

                string flank = "";
                for (int i = 0; i < flankWidth; i++) { flank = flank + " "; }

                string centered = $"{flank}{option}{flank}";

                if (centered.Length < width) { CenteredMenuOptions.Add(centered + " "); }
                else { CenteredMenuOptions.Add(centered); }
            }

            return CenteredMenuOptions;
        }


        private static void ColorMenuOption(string option)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(option);
            Console.ResetColor();
        }


        private static int MenuMaker(string[] options)
        {
            List<string> new_options = CenterOptionText(46, options);

            int selectedMenuOption = 0;

            while (true)
            {
                Console.CursorVisible = false;
                Console.Clear();
                Console.WriteLine(ASCII.MenuArt);

                for (int i = 0; i < new_options.Count; i++)
                {
                    if (i == selectedMenuOption) { ColorMenuOption(new_options[i]); }
                    else { Console.WriteLine(new_options[i]); }
                }

                var input = Console.ReadKey(false).Key;

                switch (input)
                {
                    case ConsoleKey.DownArrow:
                        if (selectedMenuOption != options.Length - 1) { selectedMenuOption++; }
                        break;
                    case ConsoleKey.UpArrow:
                        if (selectedMenuOption != 0) { selectedMenuOption--; }
                        break;
                    case ConsoleKey.Enter:
                        return selectedMenuOption;
                    case ConsoleKey.Q:
                        Console.CursorVisible = true;
                        return 404;
                }
            }
        }


        public static void Menu(Factory factory)
        {
            string[] menu = new string[]
            {
                "Show helpers and children",
                "Add helper or child"
            };

            switch (MenuMaker(menu))
            {
                case 0:
                    factory.ShowHelpers();
                    break;
                case 1:
                    break;
                case 404:
                    break;
            }
        }
        
    }
}
