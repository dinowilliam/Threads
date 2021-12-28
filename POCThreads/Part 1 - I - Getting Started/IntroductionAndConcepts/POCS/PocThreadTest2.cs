using POCThreads.Part1GettingStarted.IntroductionAndConcepts.Threads;
using System;

namespace POCThreads.Part1GettingStarted.IntroductionAndConcepts.POCS {

    public class PocThreadTest2
    {
        ThreadTest2 threadTest2;

        public PocThreadTest2(){
            threadTest2 = new ThreadTest2();
        }

        public void StartThreadTest2() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                           Exercise about ThreadTest 2                        |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

            threadTest2.Main();

            Console.ReadLine();            
            Console.ResetColor();

        }
    }
}
