﻿using POCThreads.Part1GettingStarted.POCS;
using System;

namespace POCThreads
{
    class Program
    {
        static void Main(string[] args) {
            DrawMainScreen();
        }

        public static void DrawMainScreen()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                                  dinowilliam.com                                                    |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                               Exercises from Threads                                                |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                Getting Started                                                                      |");
            Console.WriteLine("|                                        1 - Thread Test 1                                                            |");
            Console.WriteLine("|                                        2 - Thread Test 2                                                            |");
            Console.WriteLine("|                                        3 - Thread Test 3                                                            |");
            Console.WriteLine("|                                        4 - Thread Test 4                                                            |");
            Console.WriteLine("|                                        5 - Thread Test 5                                                            |");
            Console.WriteLine("|                                        6 - Thread Safe                                                              |");
            Console.WriteLine("|                                        7 - Thread Join                                                              |");
            Console.WriteLine("|                                        8 - Thread Sleep                                                             |");
            Console.WriteLine("|                                        0 - Exit                                                                     |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("| Choose one option to continue...                                                                                    |");
            Console.WriteLine("|*********************************************************************************************************************|");

            var option = Console.ReadLine();

            ExecuteTheOption(option);
        }

        public static void ExecuteTheOption(string option)
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

                    case 7:

                        var pocThreadJoin = new PocThreadJoin();
                        pocThreadJoin.StartThreadJoin();

                        DrawMainScreen();
                        break;

                    case 8:

                        var pocThreadSleep = new PocThreadSleep();
                        pocThreadSleep.StartThreadSleep();

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
