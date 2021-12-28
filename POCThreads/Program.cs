using POCThreads.Menu;
using POCThreads.Part1GettingStarted.POCS;
using System;

namespace POCThreads
{
    class Program {
        
        static void Main(string[] args) {
            MainScreen();
        }

        static void MainScreen() {
            var mainMenu = new MainMenu();
            mainMenu.DrawMainScreen();
        }
        

    }
}
