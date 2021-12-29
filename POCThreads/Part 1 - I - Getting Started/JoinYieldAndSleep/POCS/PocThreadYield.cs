using POCThreads.Part1GettingStarted.JoinYieldAndSleep.Threads;
using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.JoinYieldAndSleep.POCS
{
    public class PocThreadYield {

        ThreadYield threadYield;

        public PocThreadYield(){
            threadYield = new ThreadYield();
        }

        public void StartThreadYield() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                           Exercise about ThreadYield                         |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

            threadYield.Main();

            Console.ReadLine();            
            Console.ResetColor();

        }
    }
}
