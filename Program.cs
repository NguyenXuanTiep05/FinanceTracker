













using System;

namespace FinanceTracker
{
    class Program
    {
        static void Main()
        {

    		int selected = 0;
            while (true)
            {
    			UserInterface.DrawMainMenu(selected);
                ConsoleKeyInfo key = Console.ReadKey(false);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        selected++;
                        break;
                    case ConsoleKey.UpArrow:
                        selected--;
                        break;
                }
            }

        }
    }
}















