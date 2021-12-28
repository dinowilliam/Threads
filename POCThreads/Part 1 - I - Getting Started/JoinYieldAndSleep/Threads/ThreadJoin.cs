using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.JoinYieldAndSleep.Threads {
    public class ThreadJoin {        

        public void Main() {

            Thread t = new Thread(Go);  
            t.Start();
            t.Join();
            Console.WriteLine("Thread t has ended!");
        }

        private static void Go() {
           
            for (int i = 0; i< 1000; i++) Console.Write("y");
        }
    }
}
