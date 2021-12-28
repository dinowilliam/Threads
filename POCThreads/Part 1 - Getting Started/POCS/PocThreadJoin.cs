using POCThreads.Part1GettingStarted.Threads;
using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.POCS
{
    public class PocThreadJoin {

        ThreadJoin threadJoin;

        public PocThreadJoin(){
            threadJoin = new ThreadJoin();
        }

        public void StartThreadJoin() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                           Exercise about ThreadJoin                          |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

            threadJoin.Main();

            Console.ReadLine();            
            Console.ResetColor();

        }
    }
}
