using POCThreads.Part6DNAThread.Threads;
using System;

namespace POCThreads.Part6DNAThread.POCS
{

    public class PocDNAThread  {

        DNAThread dnaThread;

        public PocDNAThread(){
            dnaThread = new DNAThread();
        }

        public void StartDNAThread() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                           Exercise about DNAThread                           |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

            dnaThread.Main();

            Console.ReadLine();            
            Console.ResetColor();

        }
    }
}
