using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.Threads {
    public class ThreadTest3 {

        bool done;

        public void Main() {

            ThreadTest3 tt = new ThreadTest3(); // Create a common instance
            new Thread(tt.Go).Start();  
            tt.Go();                    
        }

        // Note that Go is now an instance method
        private void Go() {

            if (!done) { done = true; Console.WriteLine("Done"); }
        }
    }
}
