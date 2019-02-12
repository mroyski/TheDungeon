using System;

namespace VideoGameThing
{
    class Program
    {
        static void Main(string[] args)
        {
            var hero = new Player();
            var villain = new Baddie();
            var superVillain = new Baddie();
            int currentHealth = hero.HealthPoints;
            Title();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("As you enter the dark and frigid emptiness of the dungeon you feel your soul wretch. The air is bare...and the walls so molded you sense it in your flesh. Beware what wanders here.");
            Console.ReadKey();
            Console.Clear();
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== What Next Brave Wanderer? ===");
                Console.WriteLine("m to move");
                Console.WriteLine("x to escape the hell hole");
                string picker = Console.ReadLine();
                switch (picker)
                {
                    case "m":
                        hero.Move();
                        Console.ReadKey();
                        break;
                    case "x":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Fool...");
                        Console.ReadKey();
                        break;
                }
                if (hero.Movement >= 30)
                {
                    hero.Movement = 5;
                    Console.WriteLine("An enemy approaches!");
                    while (villain.HealthPoints > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("a to attack");
                        Console.WriteLine("r to flee");
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "a":
                                Combat(hero, villain);
                                Console.ReadKey();
                                break;
                            case "r":
                                Console.WriteLine("You got away safely.");
                                Console.ReadKey();
                                break;
                        }
                    }
                }
            }
        }

        public static void Combat(Player player, Baddie baddie)
        {
            player.Attack(baddie, player);
        }

        public static void Title()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" _____ _   _  _____  ______ _   _ _   _ _____  _____ _____ _   _ 
|_   _| | | ||  ___| |  _  \ | | | \ | |  __ \|  ___|  _  | \ | |
  | | | |_| || |__   | | | | | | |  \| | |  \/| |__ | | | |  \| |
  | | |  _  ||  __|  | | | | | | | . ` | | __ |  __|| | | | . ` |
  | | | | | || |___  | |/ /| |_| | |\  | |_\ \| |___\ \_/ / |\  |
  \_/ \_| |_/\____/  |___/  \___/\_| \_/\____/\____/ \___/\_| \_/
                                                                 
                                                                 ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

