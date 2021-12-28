using POCThreads.Menu;
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
