using POCThreads.Part1GettingStarted.Threads;
using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.POCS
{
    public class PocThreadTest3
    {
        ThreadTest3 threadTest3;

        public PocThreadTest3(){
            threadTest3 = new ThreadTest3();
        }

        public void StartThreadTest3() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                           Exercise about ThreadTest 3                        |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

            threadTest3.Main();

            Console.ReadLine();            
            Console.ResetColor();

        }
    }
}
