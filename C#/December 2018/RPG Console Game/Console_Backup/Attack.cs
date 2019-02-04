using System;
using System.Threading;

namespace Console_Backup
{
    public class Attack
    {
        protected int PlayerHealth;
        protected int Enemy1Health;
        protected int Enemy2Health;
        protected int Enemy3Health;
        protected int Boss1Health;
        protected string AttackType;
        public int DodgeChoice;
        public int a;

        public Attack(string compare)
        {
            PlayerHealth = 100;
            Enemy1Health = 10;
            Enemy2Health = 15;
            Enemy3Health = 25;
            Boss1Health = 35;

            if (compare == "MOREHEALTH")
            {
                PlayerHealth = PlayerHealth + 15;
                Console.WriteLine("You found more health!");
                Console.WriteLine("Your health is now:" + PlayerHealth);
            }
            else if (compare == "ELVL1")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Oh no! It is someone from Amnesty International volunteer trying to get you to sign their petition!");
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Quick you have 5 seconds to hide!");
                PrintDodgeChoices();
                DodgeTimer();
                switch (DodgeChoice)
                {
                    case 1:
                        Console.WriteLine("Thank god. You managed to escape the Amnesty International volunteer");
                        break;
                    case 2:
                        Console.WriteLine("Thank god. You managed to escape the Amnesty International volunteer");
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You were spotted!");
                        Console.BackgroundColor = ConsoleColor.White;
                        while (a == 0)
                        {
                            PlayerAttackOptions();
                            PlayerAttack1();
                            if (Enemy1Health <= 0)
                            {
                                break;
                            }
                            else if (PlayerHealth <= 0)
                            {
                                Console.WriteLine("You have been killed... Guess you won't be able to go home and watch some Netflix. ");
                                Console.WriteLine("Atleast when you are dead, you don't have to talk to others");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                EnemyAttack(0, 1);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Are you serious? Do you think this is Harry Potter?");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You were spotted!");
                        Console.BackgroundColor = ConsoleColor.White;
                        while (a == 0)
                        {
                            PlayerAttackOptions();
                            PlayerAttack1();
                            if (Enemy1Health <= 0)
                            {
                                Console.WriteLine("Great you killed them! Let's keep going");
                                break;
                            }
                            else if (PlayerHealth <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have been killed... Guess you won't be able to go home and watch some Netflix. ");
                                Console.WriteLine("Atleast when you are dead, you don't have to talk to others");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                EnemyAttack(0, 1);
                            }
                        }
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You were spotted!");
                        Console.BackgroundColor = ConsoleColor.White;
                        while (a == 0)
                        {
                            PlayerAttackOptions();
                            PlayerAttack1();
                            if (Enemy1Health <= 0)
                            {
                                Console.WriteLine("Great you killed them! Let's keep going");
                                break;
                            }
                            else if (PlayerHealth <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have been killed... Guess you won't be able to go home and watch some Netflix. ");
                                Console.WriteLine("Atleast when you are dead, you don't have to talk to others");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                EnemyAttack(0, 1);
                            }
                        }
                        break;
                }

            }
            else if (compare == "ELVL2")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Oh no! It is someone from High School!");
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Quick you have 5 seconds to hide!");
                PrintDodgeChoices();
                DodgeTimer();
                switch (DodgeChoice)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You were spotted!");
                        Console.BackgroundColor = ConsoleColor.White;
                        while (a == 0)
                        {
                            PlayerAttackOptions();
                            PlayerAttack2();
                            if (Enemy2Health <= 0)
                            {
                                Console.WriteLine("Great you killed them! Let's keep going");
                                break;
                            }
                            else if (PlayerHealth <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have been killed... Guess you won't be able to go home and watch some Netflix. ");
                                Console.WriteLine("Atleast when you are dead, you don't have to talk to others");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                EnemyAttack(0, 2);
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Thank god. You managed to escape your old classmate");
                        break;
                    case 3:
                        Console.WriteLine("Thank god. You managed to escape your old classmate");
                        break;
                    case 4:
                        Console.WriteLine("Are you serious? Do you think this is Harry Potter?");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You were spotted!");
                        Console.BackgroundColor = ConsoleColor.White;
                        while (a == 0)
                        {
                            PlayerAttackOptions();
                            PlayerAttack2();
                            if (Enemy2Health <= 0)
                            {
                                Console.WriteLine("Great you killed them! Let's keep going");
                                break;
                            }
                            else if (PlayerHealth <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have been killed... Guess you won't be able to go home and watch some Netflix. ");
                                Console.WriteLine("Atleast when you are dead, you don't have to talk to others");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                EnemyAttack(0, 2);
                            }
                        }
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You were spotted!");
                        Console.BackgroundColor = ConsoleColor.White;
                        while (a == 0)
                        {
                            PlayerAttackOptions();
                            PlayerAttack2();
                            if (Enemy2Health <= 0)
                            {
                                Console.WriteLine("Great you killed them! Let's keep going");
                                break;
                            }
                            else if (PlayerHealth <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have been killed... Guess you won't be able to go home and watch some Netflix. ");
                                Console.WriteLine("Atleast when you are dead, you don't have to talk to others");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                EnemyAttack(0, 2);
                            }
                        }
                        break;
                }

            }
            else if (compare == "ELVL3")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Oh no! It is Aunt Lynda! She probably hates you and complains about you all of the time");
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Quick you have 5 seconds to hide!");
                PrintDodgeChoices();
                DodgeTimer();
                switch (DodgeChoice)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You were spotted!");
                        Console.BackgroundColor = ConsoleColor.White;
                        while (a == 0)
                        {
                            PlayerAttackOptions();
                            PlayerAttack3();
                            if (Enemy3Health <= 0)
                            {
                                Console.WriteLine("Great you killed them! Let's keep going");
                                break;
                            }
                            else if (PlayerHealth <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have been killed... Guess you won't be able to go home and watch some Netflix. ");
                                Console.WriteLine("Atleast when you are dead, you don't have to talk to others");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                EnemyAttack(0, 3);
                            }
                        }
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You were spotted!");
                        Console.BackgroundColor = ConsoleColor.White;
                        while (a == 0)
                        {
                            PlayerAttackOptions();
                            PlayerAttack3();
                            if (Enemy3Health <= 0)
                            {
                                Console.WriteLine("Great you killed them! Let's keep going");
                                break;
                            }
                            else if (PlayerHealth <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have been killed... Guess you won't be able to go home and watch some Netflix. ");
                                Console.WriteLine("Atleast when you are dead, you don't have to talk to others");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                EnemyAttack(0, 3);
                            }
                        }
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You were spotted!");
                        Console.BackgroundColor = ConsoleColor.White;
                        while (a == 0)
                        {
                            PlayerAttackOptions();
                            PlayerAttack3();
                            if (Enemy3Health <= 0)
                            {
                                Console.WriteLine("Great you killed them! Let's keep going");
                                break;
                            }
                            else if (PlayerHealth <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have been killed... Guess you won't be able to go home and watch some Netflix. ");
                                Console.WriteLine("Atleast when you are dead, you don't have to talk to others");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                EnemyAttack(0, 3);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Are you serious? Do you think this is Harry Potter?");
                        Thread.Sleep(2000);
                        Console.WriteLine("Hold on. Did that actually work?");
                        Thread.Sleep(2000);
                        Console.WriteLine("No I'm not invisible... I think she finally disowned me...");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You were spotted!");
                        Console.BackgroundColor = ConsoleColor.White;
                        while (a == 0)
                        {
                            PlayerAttackOptions();
                            PlayerAttack3();
                            if (Enemy3Health <= 0)
                            {
                                Console.WriteLine("Great you killed them! Let's keep going");
                                break;
                            }
                            else if (PlayerHealth <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have been killed... Guess you won't be able to go home and watch some Netflix. ");
                                Console.WriteLine("Atleast when you are dead, you don't have to talk to others");
                                Thread.Sleep(5000);
                                Environment.Exit(0);
                            }
                            else
                            {
                                EnemyAttack(0, 3);
                            }
                        }
                        break;
                }

            }
            else if (compare == "BOSS")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Oh God No! It is your Ex!");
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Quick you have 5 seconds to hide!");
                PrintDodgeChoices();
                DodgeTimer();
                Console.WriteLine("I gueess there is no escaping your ex...");
                while (a == 0)
                {
                    PlayerAttackOptions();
                    PlayerAttack4();
                    if (Boss1Health <= 0)
                    {
                        Console.WriteLine("Great you killed them! Congrats!");
                        Console.WriteLine("You have finally made it home to watch some netflix");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("   +--------------+\n   |.------------.|\n   ||            ||\n   ||  NETFLIX   ||\n   ||            ||\n   ||            ||\n   |+------------+|\n   +-..--------..-+\n   .--------------.\n  / /============\\ \\\n / /==============\\ \\\n/____________________\\\n\\____________________/");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("   +--------------+\n   |.------------.|\n   ||            ||\n   ||  Game Over ||\n   ||            ||\n   ||            ||\n   |+------------+|\n   +-..--------..-+\n   .--------------.\n  / /============\\ \\\n / /==============\\ \\\n/____________________\\\n\\____________________/");
                        Thread.Sleep(5000);
                        Environment.Exit(0);
                    }
                    else if (PlayerHealth <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have been killed... Guess you won't be able to go home and watch some Netflix. ");
                        Console.WriteLine("Atleast when you are dead, you don't have to talk to others");
                        Thread.Sleep(5000);
                        Environment.Exit(0);
                    }
                    else
                    {
                        EnemyAttack(0, 4);
                    }
                }
            }
        }
        public void PrintDodgeChoices()
        {
            Console.WriteLine("1 - Run to the other side of the street");
            Console.WriteLine("2 - Hide behind a car");
            Console.WriteLine("3 - Put on sunglasses and a hoodie");
            Console.WriteLine("4 - Use your invisibility cloak");
        }
        public void DodgeTimer()
        {
            //I'll admit this part of the code is not entirely me. I found how to do it from this StackOverFlowQuestion
            //https://stackoverflow.com/questions/57615/how-to-add-a-timeout-to-console-readline
            for (int cnt = 5; cnt > 0; cnt--)
            {
                if (Console.KeyAvailable == true)
                {
                    DodgeChoice = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }
        public void EnemyAttack(int min, int max)
        {
            //The random won't continuly generate new numbers?
            int seed = 12345678;
            Random r = new Random(seed);
            int m = r.Next(min, max);
            switch (m)
            {
                case 0:
                    AttackType = "BITE";
                    Console.WriteLine("You were bitten!");
                    PlayerHealth = PlayerHealth - 1;
                    break;
                case 1:
                    AttackType = "SLAP";
                    Console.WriteLine("You have been slapped");
                    PlayerHealth = PlayerHealth - 5;
                    break;
                case 2:
                    AttackType = "PUNCH";
                    Console.WriteLine("You have been punched");
                    PlayerHealth = PlayerHealth - 8;
                    break;
                case 3:
                    AttackType = "KICK";
                    Console.WriteLine("You have been kicked");
                    PlayerHealth = PlayerHealth - 15;
                    break;

            }
        }
        public void PlayerAttackOptions()
        {
            Console.WriteLine("How are you going to respond?");
            Console.WriteLine("1 - Bite them");
            Console.WriteLine("2 - Slap them");
            Console.WriteLine("3 - Punch them");
            Console.WriteLine("4 - Kick them");
        }
        public void PlayerAttack1()
        {
            int PlayerAttackChoice = Convert.ToInt32(Console.ReadLine());
            switch (PlayerAttackChoice)
            {
                case 1:
                    Enemy1Health = Enemy1Health - 1;
                    break;
                case 2:
                    Enemy1Health = Enemy1Health - 5;
                    break;
                case 3:
                    Enemy1Health = Enemy1Health - 8;
                    break;
                case 4:
                    Enemy1Health = Enemy1Health - 15;
                    break;
                default:
                    break;
            }
        }
        public void PlayerAttack2()
        {
            int PlayerAttackChoice = Convert.ToInt32(Console.ReadLine());
            switch (PlayerAttackChoice)
            {
                case 1:
                    Enemy2Health = Enemy2Health - 1;
                    break;
                case 2:
                    Enemy2Health = Enemy2Health - 5;
                    break;
                case 3:
                    Enemy2Health = Enemy2Health - 8;
                    break;
                case 4:
                    Enemy2Health = Enemy2Health - 15;
                    break;
                default:
                    break;
            }
        }
        public void PlayerAttack3()
        {
            int PlayerAttackChoice = Convert.ToInt32(Console.ReadLine());
            switch (PlayerAttackChoice)
            {
                case 1:
                    Enemy3Health = Enemy3Health - 1;
                    break;
                case 2:
                    Enemy3Health = Enemy3Health - 5;
                    break;
                case 3:
                    Enemy3Health = Enemy3Health - 8;
                    break;
                case 4:
                    Enemy3Health = Enemy3Health - 15;
                    break;
                default:
                    break;
            }
        }
        public void PlayerAttack4()
        {
            int PlayerAttackChoice = Convert.ToInt32(Console.ReadLine());
            switch (PlayerAttackChoice)
            {
                case 1:
                    Boss1Health = Boss1Health - 1;
                    break;
                case 2:
                    Boss1Health = Boss1Health - 5;
                    break;
                case 3:
                    Boss1Health = Boss1Health - 8;
                    break;
                case 4:
                    Boss1Health = Boss1Health - 15;
                    break;
                default:
                    break;
            }
        }
    }
}