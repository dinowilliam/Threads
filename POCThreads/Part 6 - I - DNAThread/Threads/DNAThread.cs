using System;
using System.IO;
using System.Threading;

namespace POCThreads.Part6DNAThread.Threads
{
    public class DNAThread
    {
        public void Main() {

            StreamWriter fileForTest = new StreamWriter(@"C:\Garbage\threads.txt", true);

            Thread F = new Thread(WriteF); // Kick off a new thread
            Thread C = new Thread(WriteC); // Kick off a new thread
            Thread T = new Thread(WriteT); // Kick off a new thread            
            Thread A = new Thread(WriteA); // Kick off a new thread            
            Thread G = new Thread(WriteG); // Kick off a new thread            

            F.Start(fileForTest);
            C.Start();
            T.Start();
            Thread.Sleep(1000);
            A.Start();
            Thread.Sleep(1000);
            G.Start();
        }

        static void WriteF(object print)
        {
            StreamWriter fileForTest;

            fileForTest = (StreamWriter)print;

            for (int i = 0; i < 50000; i++)
            {
                fileForTest.WriteLine(" Thread WriteX ");
                Thread.Sleep(50);
            }

            fileForTest.Close();
        }

        static void WriteC(object print)
        {
            StreamWriter fileForTest;

            fileForTest = (StreamWriter)print;
            for (int i = 0; i < 50000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("C");
                Thread.Sleep(30);
                //Console.ResetColor();
            }
        }

        static void WriteT(object print)
        {
            StreamWriter fileForTest;

            fileForTest = (StreamWriter)print;
            for (int i = 0; i < 50000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("T");
                Thread.Sleep(30);
                //Console.ResetColor();
            }
        }

        static void WriteA()
        {
            for (int i = 0; i < 50000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("A");
                Thread.Sleep(10);
                //Console.ResetColor();
            }
        }

        static void WriteG()
        {
            for (int i = 0; i < 50000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("G");
                Thread.Sleep(20);
                //Console.ResetColor();
            }
        }

        static void WriteL(object consoleColor)
        {
            var thread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    try
                    {
                        Console.ForegroundColor = (ConsoleColor)consoleColor;

                        if (i >= 25) throw new Exception();

                        Console.Write("Thread L");
                        Thread.Sleep(30);
                        Console.ResetColor();

                    }
                    catch (Exception ex)
                    {

                    }
                }

            }));

            //thread.IsBackground = true;
            thread.Name = "Thread L";
            thread.Start();
        }

    }
}
