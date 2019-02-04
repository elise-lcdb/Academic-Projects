using System;
namespace Console_Backup
{
    public class Map
    {
        public string[,] TheMap = new string[5, 7];
        public int PositionX; //Column
        public int PositionY; //Row
        public string CurrentPos;
        public string Empty;
        public string DirectionChoice;


        public Map()
        {
            StartPosition();
            while (CurrentPos != "BOSS")
            {
                Console.WriteLine("Choose a direction to go in?");
                PrintDirectionChoices();
                UpdatePosition();
                Cases();
                Attack combat = new Attack(CurrentPos);
            }
        }
        public void StartPosition()
        {
            PositionX = 0;
            PositionY = 2;
            TheMap[PositionX, PositionY] = CurrentPos;

        }
        public void PrintDirectionChoices()
        {
            if (PositionX == 0 && PositionY == 0)
            {
                Console.WriteLine("1 - Go Right");
                Console.WriteLine("2 - Go Down");
                int direction = Convert.ToInt32(Console.ReadLine());
                switch (direction)
                {
                    case 1:
                        DirectionChoice = "RIGHT";
                        break;
                    case 2:
                        DirectionChoice = "DOWN";
                        break;
                    default:
                        Console.WriteLine("Direction not found");
                        break;
                }
            }
            else if (PositionX == 0 && PositionY == 4)
            {
                Console.WriteLine("1 - Go Up");
                Console.WriteLine("2 - Go Right");
                int direction = Convert.ToInt32(Console.ReadLine());
                switch (direction)
                {
                    case 1:
                        DirectionChoice = "UP";
                        break;
                    case 2:
                        DirectionChoice = "RIGHT";
                        break;
                    default:
                        Console.WriteLine("Direction not found");
                        break;
                }
            }
            else if (PositionX == 0 && PositionY != 0 && PositionY != 4)
            {
                Console.WriteLine("1 - Go Up");
                Console.WriteLine("2 - Go Right");
                Console.WriteLine("3 - Go Down");
                int direction = Convert.ToInt32(Console.ReadLine());
                switch (direction)
                {
                    case 1:
                        DirectionChoice = "UP";
                        break;
                    case 2:
                        DirectionChoice = "RIGHT";
                        break;
                    case 3:
                        DirectionChoice = "DOWN";
                        break;
                    default:
                        Console.WriteLine("Direction not found");
                        break;
                }
            }
            else
            {
                Console.WriteLine("1 - Go Up");
                Console.WriteLine("2 - Go Left");
                Console.WriteLine("3 - Go Right");
                Console.WriteLine("4 - Go Down");
                int direction = Convert.ToInt32(Console.ReadLine());
                switch (direction)
                {
                    case 1:
                        DirectionChoice = "UP";
                        break;
                    case 2:
                        DirectionChoice = "LEFT";
                        break;
                    case 3:
                        DirectionChoice = "RIGHT";
                        break;
                    case 4:
                        DirectionChoice = "DOWN";
                        break;
                    default:
                        Console.WriteLine("Direction not found");
                        break;
                }
            }

        }
        public void UpdatePosition()
        {
            switch (DirectionChoice)
            {
                case "UP":
                    PositionY = PositionY + 1;
                    break;
                case "DOWN":
                    PositionY = PositionY - 1;
                    break;
                case "RIGHT":
                    PositionX = PositionX + 1;
                    break;
                case "LEFT":
                    PositionX = PositionX - 1;
                    break;
            }
        }

        public void Cases()
        {
            if ((PositionX == 0 && PositionY == 1) || (PositionX == 0 && PositionY == 3) || (PositionX == 1 && PositionY == 2) || (PositionX == 2 && PositionY == 0) || (PositionX == 2 && PositionY == 4) || (PositionX == 4 && PositionY == 0) || (PositionX == 4 && PositionY == 2))
            {
                Console.WriteLine("So far so good...");
            }
            else if ((PositionX == 0 && PositionY == 0) || (PositionX == 0 && PositionY == 4) || (PositionX == 2 && PositionY == 2))
            {
                CurrentPos = "ELVL1";
            }
            else if ((PositionX == 0 && PositionY == 1) || (PositionX == 2 && PositionY == 1) || (PositionX == 2 && PositionY == 3) || (PositionX == 3 && PositionY == 0) || (PositionX == 3 && PositionY == 2))
            {
                CurrentPos = "ELVL2";
            }
            else if ((PositionX == 1 && PositionY == 4) || (PositionX == 3 && PositionY == 4) || (PositionX == 4 && PositionY == 1) || (PositionX == 4 && PositionY == 3) || (PositionX == 5 && PositionY == 0) || (PositionX == 5 && PositionY == 2))
            {
                CurrentPos = "ELVL3";
            }
            else if ((PositionX == 1 && PositionY == 1) || (PositionX == 1 && PositionY == 3) || (PositionX == 3 && PositionY == 1) || (PositionX == 3 && PositionY == 3) || (PositionX == 4 && PositionY == 4) || (PositionX == 5 && PositionY == 1) || (PositionX == 5 && PositionY == 3) || (PositionX == 5 && PositionY == 4))
            {
                CurrentPos = "MOREHEALTH";
            }
            else
            {
                CurrentPos = "BOSS";
            }
        }
        public void EnemyLvl2()
        {
            CurrentPos = "ELVL2";

        }
        public void EnemyLvl3()
        {
            CurrentPos = "ELVL3";

        }
        public void EnemyBoss()
        {
            CurrentPos = "BOSS";
        }

    }
}
