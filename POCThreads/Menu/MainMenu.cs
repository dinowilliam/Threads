using POCThreads.Part1GettingStarted.POCS;
using System;

namespace POCThreads.Menu
{
    public class MainMenu {
        public void DrawMainScreen() {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                                  dinowilliam.com                                                    |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                               Exercises from Threads                                                |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|                                        1 - Part 1 - Getting Started                                                 |");
            Console.WriteLine("|                                        2 -                                                                          |");
            Console.WriteLine("|                                        3 -                                                                          |");
            Console.WriteLine("|                                        4 -                                                                          |");
            Console.WriteLine("|                                        5 -                                                                          |");
            Console.WriteLine("|                                        6 -                                                                          |");
            Console.WriteLine("|                                        7 -                                                                          |");
            Console.WriteLine("|                                        8 -                                                                          |");
            Console.WriteLine("|                                        0 - Exit                                                                     |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("| Choose one option to continue...                                                                                    |");
            Console.WriteLine("|*********************************************************************************************************************|");

            var option = Console.ReadLine();

            ExecuteTheOption(option);
        }

        public void ExecuteTheOption(string option)
        {

            if (!String.IsNullOrWhiteSpace(option))
            {

                int value = Int32.Parse(option);

                switch (value)
                {

                    case 1:
                        var part1GettingStartedMenu = new Part1GettingStartedMenu();
                        part1GettingStartedMenu.DrawMainScreen();

                        DrawMainScreen();
                        break;

                    case 2:                        

                        DrawMainScreen();
                        break;

                    case 3:                        

                        DrawMainScreen();
                        break;

                    case 4:                        

                        DrawMainScreen();
                        break;

                    case 5:                        

                        DrawMainScreen();
                        break;

                    case 6:

                        DrawMainScreen();
                        break;

                    case 7:                        

                        DrawMainScreen();
                        break;

                    case 8:

                        DrawMainScreen();
                        break;

                    case 0:
                        
                        Environment.Exit(0);
                        break;

                    default:
                        DrawMainScreen();
                        break;
                }
            }
            else
            {
                DrawMainScreen();
            }
        }
    }
}
