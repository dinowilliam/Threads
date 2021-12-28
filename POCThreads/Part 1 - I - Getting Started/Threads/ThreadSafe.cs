using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.Threads {
    public class ThreadSafe {

        static bool done = false;  
        static readonly object locker = new object();

        public void Main() {
            
            new Thread(Go).Start();  
            Go();                    
        }
        
        private static void Go() {
            // Lock the resource for one of the threads wait the resource be avaiable
            lock (locker){
                if (!done) { Console.WriteLine("Done"); done = true; }
            }
        }
    }
}
