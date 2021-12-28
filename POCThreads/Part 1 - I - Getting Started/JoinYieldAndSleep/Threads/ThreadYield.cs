using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.JoinYieldAndSleep.Threads {

    public class ThreadYield {        

        public void Main() {

            Thread t = new Thread(Go);  
            t.Start();                        
        }

        private static void Go() {
            Thread.Yield();
            for (int i = 0; i< 1000; i++) Console.Write("y");

            Thread.Yield(); 
            Console.WriteLine("Thread t waited for 1500 mileseconds!");
        }
    }
}
