using System;
using System.Threading;

namespace Console_Backup
{
    public class Game
    {
        public Game()
        {
            Introduction();
            Player player = new Player();
            Console.Clear();
            Map map = new Map();
        }
        public void Introduction()
        {
            Console.WriteLine("You just got off of work, and all you want to do is go home and watch some Netflix");
            Thread.Sleep(3000);
            Console.WriteLine("However on your walk home you risk running into people");
            Thread.Sleep(3000);
            Console.WriteLine("And today you are just in no mood for any sort of human interaction.");
            Thread.Sleep(3000);
            Console.WriteLine("If you unfortunately run into someone, you typically have about 5 seconds to hide");
            Thread.Sleep(3000);
            Console.WriteLine("And if you manage to hide, your health stays in tact.");
            Thread.Sleep(3000);
            Console.WriteLine("However if you are spotted, you will be forced to fight them until one of you dies.");
            Thread.Sleep(3000);
            Console.WriteLine("If manage to make it out of a fight alive. Congrats!");
            Thread.Sleep(3000);
            Console.WriteLine("There will be areas in the game where you can pick up more health");
            Thread.Sleep(3000);
            Console.WriteLine("Good luck!");
            Thread.Sleep(5000);
            Console.Clear();


        }
    }
}
