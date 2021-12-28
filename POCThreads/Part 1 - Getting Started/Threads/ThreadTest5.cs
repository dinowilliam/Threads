using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.Threads {
    public class ThreadTest5 {

        static bool done = false;  // Static fields are shared between all threads

        public void Main() {
            
            new Thread(Go).Start();  
            Go();                    
        }
        
        private static void Go() {
            // Because the done was being setted after write line it can be written two times in the screen (usually!)
            // Because is not thread safe 
            if (!done) { Console.WriteLine("Done"); done = true; }     
        }
    }
}
