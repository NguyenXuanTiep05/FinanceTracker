













using System;

namespace FinanceTracker
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;

    		int selected = 0;
            bool mainMenu = true;
            while (mainMenu)
            {
    			UserInterface.DrawMainMenu(selected);
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        selected++;
                        break;
                    case ConsoleKey.UpArrow:
                        selected--;
                        break;
                    case ConsoleKey.Enter:
                        UserInterface.HandleUI();
                        break;
                    case ConsoleKey.Q:
                        Console.Clear();
                        mainMenu = false;
                        break;
                }
            }

        }
    }
}















