using POCThreads.Part1GettingStarted.IntroductionAndConcepts.POCS;
using System;

namespace POCThreads.Menu
{
    public class Part1IntroductionAndConceptsMenu  {

        public void DrawMainScreen() {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                                  dinowilliam.com                                                    |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                            Introduction And Concepts                                                |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|                                        1 - Thread Test 1                                                            |");
            Console.WriteLine("|                                        2 - Thread Test 2                                                            |");
            Console.WriteLine("|                                        3 - Thread Test 3                                                            |");
            Console.WriteLine("|                                        4 - Thread Test 4                                                            |");
            Console.WriteLine("|                                        5 - Thread Test 5                                                            |");
            Console.WriteLine("|                                        6 - Thread Safe                                                              |");            
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
                        var pocThreadTest1 = new PocThreadTest1();
                        pocThreadTest1.StartThreadTest1();

                        DrawMainScreen();
                        break;

                    case 2:

                        var pocThreadTest2 = new PocThreadTest2();
                        pocThreadTest2.StartThreadTest2();

                        DrawMainScreen();
                        break;

                    case 3:

                        var pocThreadTest3 = new PocThreadTest3();
                        pocThreadTest3.StartThreadTest3();

                        DrawMainScreen();
                        break;

                    case 4:

                        var pocThreadTest4 = new PocThreadTest4();
                        pocThreadTest4.StartThreadTest4();

                        DrawMainScreen();
                        break;

                    case 5:

                        var pocThreadTest5 = new PocThreadTest5();
                        pocThreadTest5.StartThreadTest5();

                        DrawMainScreen();
                        break;

                    case 6:

                        var pocThreadSafe = new PocThreadSafe();
                        pocThreadSafe.StartThreadSafe();

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
