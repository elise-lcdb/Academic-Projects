using System;
using System.Threading;

namespace Console_Backup
{
    public class Menu
    {
        public Menu()
        {
            PrintMenu();
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    StartGame();
                    break;
                case 2:
                    About();
                    break;
                case 3:
                    Quit();
                    break;
                default:
                    Console.WriteLine("Please enter a valid character:");
                    break;

            }

        }
        public void PrintMenu()
        {
            Console.WriteLine(".___  ___.  _______ .__   __.  __    __  \n|   \\/   | |   ____||  \\ |  | |  |  |  | \n|  \\  /  | |  |__   |   \\|  | |  |  |  | \n|  |\\/|  | |   __|  |  . `  | |  |  |  | \n|  |  |  | |  |____ |  |\\   | |  `--'  | \n|__|  |__| |_______||__| \\__|  \\______/  \n                                         ");
            Console.WriteLine("1 - Start Game");
            Console.WriteLine("2 - About Game");
            Console.WriteLine("3 - Quit Game");
        }
        public void StartGame()
        {
            Console.Clear();
            Game game = new Game();
        }
        public void About()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my console text-based game made with C#");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("In this game your goal is to get home to watch some Netflix without running into other people.");
            Console.WriteLine("Sometimes you just don't want to socialize with others");
            Console.WriteLine("Sometimes it is just your lifestyle");
            Console.WriteLine("Like for me...");
            Thread.Sleep(10000);
            Console.Clear();
            Console.WriteLine("Anyway I hope you enjoy the game!");
            Console.WriteLine("Made by Elise");

        }
        public void Quit()
        {
            Environment.Exit(0);
        }
    }
}
