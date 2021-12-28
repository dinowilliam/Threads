using POCThreads.Part1GettingStarted.Threads;
using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.POCS
{
    public class PocThreadTest4
    {
        ThreadTest4 threadTest4;

        public PocThreadTest4(){
            threadTest4 = new ThreadTest4();
        }

        public void StartThreadTest4() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                           Exercise about ThreadTest 4                        |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

            threadTest4.Main();

            Console.ReadLine();            
            Console.ResetColor();

        }
    }
}
