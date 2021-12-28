using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.Threads {
    public class ThreadTest4 {

        static bool done;  // Static fields are shared between all threads

        public void Main() {
            
            new Thread(Go).Start();  
            Go();                    
        }
        
        private static void Go() {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }
    }
}
