using POCThreads.Part1GettingStarted.IntroductionAndConcepts.Threads;
using System;

namespace POCThreads.Part1GettingStarted.IntroductionAndConcepts.POCS {

    public class PocThreadSafe {

        ThreadSafe threadSafe;

        public PocThreadSafe(){
            threadSafe = new ThreadSafe();
        }

        public void StartThreadSafe() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                           Exercise about ThreadSafe                          |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

            threadSafe.Main();

            Console.ReadLine();            
            Console.ResetColor();

        }
    }
}
