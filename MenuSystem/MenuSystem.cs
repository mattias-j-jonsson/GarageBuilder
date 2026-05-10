using System;
using System.Collections.Generic;

namespace GarageBuilder
{
    public static class MenuSystem
    {
        public static void LoadGarageFromFile()
        {
            return;
        }

        public static string DrawMenu(List<string> menuOptions)
        {
            string chosenOption = string.Empty;
            int menuIndex = 0;
            // Console.Clear();

            while (chosenOption == string.Empty)
            {
                Console.Clear();
                for(int i = 0; i < menuOptions.Count; i++)
                {
                    if(i == menuIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(menuOptions[i]);
                    Console.ResetColor();
                }

                ConsoleKeyInfo pressedKey = Console.ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (menuIndex < menuOptions.Count-1)
                        {
                            menuIndex++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (menuIndex > 0)
                        {
                            menuIndex--;
                        }
                        break;
                    case ConsoleKey.Enter:
                        chosenOption = menuOptions[menuIndex];
                        break;
                    default:
                        break;
                }
                // Console.Clear();

            }
            
            return chosenOption;
        }
    }
}