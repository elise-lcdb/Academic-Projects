using System;
using System.Threading;

namespace Console_Backup
{
    public class Player
    {
        public string Name;


        public Player()
        {
            Console.WriteLine("What is your name?");
            string PlayerName = Console.ReadLine();
            Name = PlayerName;
            Console.Clear();
            Console.Clear();
            PlayerIntroduction();
        }
        public void PlayerIntroduction()
        {
            Console.WriteLine("Hello, " + Name + "!");
            Console.WriteLine("This player have 100 life points to start off with!");
            Console.WriteLine("Lets get started on your adventure!");
            Thread.Sleep(5000);
        }

    }
}
