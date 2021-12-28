using POCThreads.Part1GettingStarted.Threads;
using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.POCS
{
    public class PocThreadSleep {

        ThreadSleep threadSleep;

        public PocThreadSleep(){
            threadSleep = new ThreadSleep();
        }

        public void StartThreadSleep() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                          Exercise about Thread Sleep                         |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

            threadSleep.Main();

            Console.ReadLine();            
            Console.ResetColor();

        }
    }
}
