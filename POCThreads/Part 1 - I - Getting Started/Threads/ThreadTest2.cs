using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.Threads
{
    public class ThreadTest2 {        

        public void Main() {

            new Thread(Go).Start();  // Call Go() a new thread
            Go();                    // Call Go() on the main thread
        }

        private static void Go() {

            // Declare and use a local variable - 'cycles'
            for (int cycles = 0; cycles < 5; cycles++) Console.Write("?");
        }
    }
}
