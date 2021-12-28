using POCThreads.Part1GettingStarted.Threads;
using System;

namespace POCThreads.Part1GettingStarted.POCS
{
    public class PocThreadTest1
    {
        ThreadTest1 threadTest1;

        public PocThreadTest1(){
            threadTest1 = new ThreadTest1();
        }

        public void StartThreadTest1() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                           Exercise about ThreadTest 1                        |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

            threadTest1.Main();

            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();
            Console.ResetColor();

        }
    }
}
