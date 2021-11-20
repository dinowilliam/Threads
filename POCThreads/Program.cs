using System;
using System.IO;
using System.Threading;

namespace POCThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fileForTest = new StreamWriter(@"C:\Garbage\threads.txt", true);

            Thread Y = new Thread(WriteY); // Kick off a new thread
            Thread X = new Thread(WriteX); // Kick off a new thread            

            X.Start(fileForTest);
            Y.Start();                       
        }

        static void WriteX(object print)
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

        static void WriteY(object print)
        {
            StreamWriter fileForTest;            

            fileForTest = (StreamWriter)print;
            for (int i = 0; i < 50000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Y");
                Thread.Sleep(30);
                Console.ResetColor();
            }                 
        }

        static void WriteZ()
        {
            for (int i = 0; i < 50000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Z");
                Console.ResetColor();
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
                        Console.ForegroundColor = (ConsoleColor) consoleColor;

                        if(i >= 25) throw new Exception();

                        Console.Write("Thread L");
                        Thread.Sleep(30);
                        Console.ResetColor();
                      
                    }
                    catch(Exception ex)
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
