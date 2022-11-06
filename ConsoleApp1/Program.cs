namespace name
{
    class program
    {


        static void Main(string[] args)
        {
            string[] menuItems = new string[] { "Ввести A", "Ввести B", "Сложение", "Вычитание", "Умножение", "Деление", "Выход", };

            Console.WriteLine("Меню");
            Console.WriteLine();

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            int result = 0;
            int A = 0;
            int B = 0;
            while (true)
            {
                DrawMenu(menuItems, row, col, index, result);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (index)
                        {
                            case 6:
                                Console.WriteLine("Выход");
                                return;
                        }

                        break;
                }
            }
        }

        private static void DrawMenu(string[] items, int row, int col, int index, int result)
        {
            Console.SetCursorPosition(col, row);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(items[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}