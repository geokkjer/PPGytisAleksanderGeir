namespace Nissens_liste_og_hans_hjelpere
{
    internal static class UI
    {
        private static List<string> CenterOptionText(int width, List<string> options)
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


        private static int MenuMaker(List<string> options)
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
                        if (selectedMenuOption != options.Count - 1) { selectedMenuOption++; }
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


        public static void ShowGoodChildren(Factory objectAssets)
        {
            List<string> goodKids = new List<string>();

            foreach (var child in objectAssets.Children)
            {
                if (child.IsGood)
                {
                    goodKids.Add(child.Name);
                }
            }

            foreach (var child in goodKids)
            {
                Console.WriteLine(child);
            }

            var input = Console.ReadKey(false).Key;
        }


        public static void ShowBadChildre(Factory objectAssets)
        {
            List<string> badKids = new List<string>();

            foreach (var child in objectAssets.Children)
            {
                if (!child.IsGood)
                {
                    badKids.Add(child.Name);
                }
            }

            foreach (var child in badKids)
            {
                Console.WriteLine(child);
            }

            var input = Console.ReadKey(false).Key;
        }


        public static void ShowChildren(Factory objectAssets)
        {
            List<string> behaviour = new List<string>
            {
                "Show good children",
                "Show bad children"
            };

            while (true)
            {
                Console.WriteLine(ASCII.ChildArt);
                Console.Clear();
                Console.WriteLine("You may move the children in each list.");

                switch (MenuMaker(behaviour))
                {
                    case 0:
                        ShowGoodChildren(objectAssets);
                        break;
                    case 1:
                        ShowBadChildre(objectAssets);
                        break;
                    case 404:
                        return;
                }
            }
        }


        public static void ShowChildrenOrHelpers(Factory objectAssets)
        {
            List<string> behaviour = new List<string>
            {
                "Show helpers",
                "Show children"
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine(ASCII.HelperArt);

                switch (MenuMaker(behaviour))
                {
                    case 0:
                        ShowHelpers(objectAssets);
                        break;
                    case 1:
                        ShowChildren(objectAssets);
                        break;
                    case 404:
                        return;
                }
            }
        }


        public static void ShowHelpers(Factory objectAssets)
        {
            Console.Clear();
            Console.Write(ASCII.HelperArt);
            Console.Write(
                    "----------------------------------------------\n" +
                    "             All of Santas helpers\n" +
                    "----------------------------------------------\n");

            foreach (var helper in objectAssets.Helpers)
            {
                Console.WriteLine($"Type: {helper.type}, Name: {helper.name}, About: {helper.description}");
            }

            var input = Console.ReadKey(false).Key;
        }


        public static void Menu(Factory objectAssets)
        {
            List<string> menu = new List<string>
            {
                "Show helpers and children",
                "Add helper or child"
            };

            while (true)
            {
                switch (MenuMaker(menu))
                {
                    case 0:
                        ShowChildrenOrHelpers(objectAssets);
                        break;
                    case 1:
                        break;
                    case 404:
                        Console.Clear();
                        Console.CursorVisible = true;
                        return;
                }
            }
        }

    }
}
