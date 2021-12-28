using POCThreads.Part1GettingStarted.IntroductionAndConcepts.Threads;
using System;

namespace POCThreads.Part1GettingStarted.IntroductionAndConcepts.POCS {

    public class PocThreadTest5
    {
        ThreadTest5 threadTest5;

        public PocThreadTest5(){
            threadTest5 = new ThreadTest5();
        }

        public void StartThreadTest5() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                           Exercise about ThreadTest 5                        |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

            threadTest5.Main();

            Console.ReadLine();            
            Console.ResetColor();

        }
    }
}
