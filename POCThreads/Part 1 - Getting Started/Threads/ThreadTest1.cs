using System;
using System.Threading;

namespace POCThreads.Part1GettingStarted.Threads
{
    public class ThreadTest1  {
        public ThreadTest1() {            
        }

        public void Main() {

            Thread t = new Thread(WriteY);  //Kick off a new thread
            t.Start();                      //Runnig WriteY

            for (int i = 0; i < 1000; i++) Console.Write("X");
        }

        private static void WriteY() {
            for (int i = 0; i < 1000; i++) Console.Write("Y");
        }
    }
}
