using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.JoinYieldAndSleep.Threads {

    public class ThreadSleep{        

        public void Main() {

            Thread t = new Thread(Go);  
            t.Start();                        
        }

        private static void Go() {
           
            for (int i = 0; i< 1000; i++) Console.Write("y");

            Thread.Sleep(1500);
            Console.WriteLine("Thread t waited for 1500 mileseconds!");
        }
    }
}
