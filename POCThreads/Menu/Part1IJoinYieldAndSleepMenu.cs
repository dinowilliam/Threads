using POCThreads.Part1GettingStarted.JoinYieldAndSleep.POCS;
using System;

namespace POCThreads.Menu
{
    public class Part1IJoinYieldAndSleepMenu  {

        public void DrawMainScreen() {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                                  dinowilliam.com                                                    |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                            Join, Yield And Sleep                                                    |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                                                                                                     |");            
            Console.WriteLine("|                                        1 - Thread Join                                                              |");
            Console.WriteLine("|                                        2 - Thread Sleep                                                             |");
            Console.WriteLine("|                                        3 - Thread Yield                                                             |");
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

                        var pocThreadJoin = new PocThreadJoin();
                        pocThreadJoin.StartThreadJoin();

                        DrawMainScreen();
                        break;

                    case 2:

                        var pocThreadSleep = new PocThreadSleep();
                        pocThreadSleep.StartThreadSleep();

                        DrawMainScreen();
                        break;

                    case 3:

                        //var pocThreadYield = new PocThreadYield();
                        //pocThreadYield.StartThreadYield();

                        DrawMainScreen();
                        break;

                    case 0:                        
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
